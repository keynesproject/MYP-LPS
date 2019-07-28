using LPS.Model.DataAccessObject;
using LPS.Model.FileExport;
using LPS.Model.Log;
using LPS.Model.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LPS.View.Forms
{
    public partial class FormBackup : Form
    {
        private DaoMachine m_Machine = new DaoMachine();
        private string PathLocalBackup { get; set; }
        private string PathServer { get; set; }
        private string Account { get; set; }
        private string PW { get; set; }
        private string PathReport { get; set; }
        private string PathDb { get; set; }

        public FormBackup()
        {
            InitializeComponent();
        }

        internal void Setup(DaoMachine Machine)
        {
            m_Machine = Machine;

            DataTable dt = DaoSQL.Instance.GetBackupInfo();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                switch (dt.Rows[i]["Type"].ToString())
                {
                    case "Local":
                        PathLocalBackup = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Server":
                        PathServer = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerAccount":
                        Account = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerPW":
                        PW = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Report":
                        PathReport = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Database":
                        PathDb = dt.Rows[i]["ADDR"].ToString();
                        break;
                }
            }
        }

        private void SetMsg(string Mag)
        {
            lblMsg.Text = Mag;
            lblMsg.Refresh();
        }

        private void SetProcess(int Value)
        {
            if (Value < pbProcess.Maximum)
            {
                pbProcess.Value = Value + 1;
            }
            else
            {
                pbProcess.Value = pbProcess.Maximum;
                pbProcess.Value = pbProcess.Maximum - 1;
            }

            pbProcess.Value = Value;                        
        }

        private void FormBackup_Shown(object sender, EventArgs e)
        {
            //備份本機資料;//
            SetMsg("備份本機資料");
            BackupLocalData();
            SetProcess(33);
            Thread.Sleep(300);

            //檢查伺服器路徑是否可以連線;//
            if (MyNetworkPlacesTest(PathServer, false) == false)
            {
                SetMsg("無法備份資料至伺服器，請檢察網路狀態或備份路徑設定。");
                SetProcess(66);
                Thread.Sleep(500);

                SetMsg("無法匯出報表至伺服器，請檢察網路狀態或備份路徑設定。");
                SetProcess(100);
                Thread.Sleep(500);
            }
            else
            {
                //備份資料至Server;//
                SetMsg("備份資料至伺服器");
                BackupToServer();
                SetProcess(66);
                Thread.Sleep(300);

                //匯出報表至Server;//
                SetMsg("匯出報表至伺服器");
                ExportDaliyReport();
                SetProcess(100);
                Thread.Sleep(300);
            }

            NetTranslate.KillLink(PathServer);
            this.DialogResult = DialogResult.Cancel;
        }
        
        /// <summary>
        /// 備份本機資料
        /// </summary>
        private void BackupLocalData()
        {
            if (PathLocalBackup.Length <= 0)
                return;

            //檢查路徑是否存在;//
            if(Directory.Exists(PathLocalBackup) == false )
            {
                try
                {
                    //建立目錄;//
                    Directory.CreateDirectory(PathLocalBackup);
                }
                catch(Exception Ex)
                {
                    Logger.Error(string.Format("{0}\r\n路徑:{1}", Ex.Message, PathLocalBackup));
                    return;
                }
            }

            try
            {
                //將本地端的Data資料Copy至指定目錄;//
                CopyDirectory(DaoConfigFile.Instance.m_DirBase, PathLocalBackup);
            }
            catch(Exception Ex)
            {
                Logger.Error(string.Format("{0}", Ex.Message));
            }
        }

        /// <summary>
        /// 拷貝文件夾
        /// </summary>
        /// <param name="srcdir"></param>
        /// <param name="desdir"></param>
        private void CopyDirectory(string srcdir, string desdir)
        {
            string folderName = srcdir.Substring(srcdir.LastIndexOf("\\") + 1);

            string desfolderdir = desdir + "\\" + folderName;

            if (desdir.LastIndexOf("\\") == (desdir.Length - 1))
            {
                desfolderdir = desdir + folderName;
            }
            string[] filenames = Directory.GetFileSystemEntries(srcdir);

            foreach (string file in filenames) // loop所有的檔案及目錄 
            {
                //先當作目錄處理，如果存在此資料就遞迴COPY該資料夾下的文件
                if (Directory.Exists(file))    
                {
                    string currentdir = desfolderdir + "\\" + file.Substring(file.LastIndexOf("\\") + 1);
                    if (!Directory.Exists(currentdir))
                    {
                        Directory.CreateDirectory(currentdir);
                    }

                    CopyDirectory(file, desfolderdir);
                }
                else 
                {
                    // 否則直接COPY文件
                    string srcfileName = file.Substring(file.LastIndexOf("\\") + 1);

                    srcfileName = desfolderdir + "\\" + srcfileName;

                    if (!Directory.Exists(desfolderdir))
                    {
                        Directory.CreateDirectory(desfolderdir);
                    }

                    File.Copy(file, srcfileName,true);
                }
            }
        }

        private void BackupToServer()
        {
            if (PathServer.Length <= 0)
                return;

            string DestDir = PathServer + "\\Line_" + m_Machine.機台代碼;

            //檢查路徑是否存在;//
            if (Directory.Exists(DestDir) == false)
            {
                try
                {
                    //建立目錄;//
                    Directory.CreateDirectory(DestDir);
                }
                catch (Exception Ex)
                {
                    Logger.Error(string.Format("{0}\r\n路徑:{1}", Ex.Message, DestDir));
                    return;
                }
            }

            try
            {
                //將本地端的Data資料Copy至指定目錄;//
                CopyDirectory(DaoConfigFile.Instance.m_DirBase, DestDir);
            }
            catch (Exception Ex)
            {
                Logger.Error(string.Format("{0}", Ex.Message));
            }
        }
        
        private void ExportDaliyReport()
        {
            if (PathReport.Length <= 0)
                return;

            //先判斷今天是否有測試紀錄;//
            string DateFrom = DateTime.Today.ToString("yyyy-MM-dd") + " 00:00:00";
            string DateTo = DateTime.Today.ToString("yyyy-MM-dd") + " 23:59:59";
            DataTable dtTest = DaoSQL.Instance.GetTestHistory(DateFrom, DateTo);
            if (dtTest.Rows.Count <= 0)
                return;
            dtTest.TableName = DateTime.Today.ToString("yyyy-MM-dd");

            //先取得所有資料集;//
            DataSet Ds = new DataSet();
            Ds.Tables.Add(dtTest);

            String TimeForFileName = DateTime.Now.ToString("yyyy-MM-dd");
            string FileName = string.Format("./{0}-{1}_{2}.xls", m_Machine.機台代碼, m_Machine.描述, TimeForFileName);

            //輸出檔案成Excel檔;//
            try
            {
                FileExport.ExportDataSetToExcel(Ds, FileName);                
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("匯出報表檔案失敗!\r\n資訊:{0}", ex.Message));                
            }

            //將這檔案上傳到指定路徑;//
            try
            {
                NetTranslate.Transport(FileName, PathReport, Path.GetFileName(FileName));
            }
            catch(Exception Ex)
            {
                Logger.Error(string.Format("傳送報表資訊失敗!\r\n資訊:{0}", Ex.Message));
            }

            //刪除報表檔案;//
            File.Delete(FileName);
        }

        /// <summary>
        /// 檢查伺服器狀態
        /// </summary>
        /// <returns></returns>
        private bool MyNetworkPlacesTest(string Path, bool isClose)
        {
            if (Path.Length <= 0)
                return false;

            NetTranslate.KillLink(PathServer);

            if (NetTranslate.connectState(Path, Account, PW) == false)
                return false;

            if(isClose == true)
                NetTranslate.KillLink(Path);

            return true;
        }
    }
}
