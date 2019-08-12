using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.View.Component;
using LPS.Model.Network;
using System.IO;

namespace LPS.View.Pages
{
    public partial class PageBackup : UserControl
    {
        private enum DbCheckState
        {
            eDB_FOUND,
            eDB_NOT_FOUND,
            eDB_PATH_ERROR,
            eDB_PATH_FIELD_EMPTY,
        }

        public PageBackup()
        {
            InitializeComponent();
        }

        internal void Setup()
        {
#if !DEBUG
            DataTable dt = DaoSQL.Instance.GetBackupInfo();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                switch (dt.Rows[i]["Type"].ToString())
                {
                    case "Local":
                        tbPathBackup.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Server":
                        tbPathServer.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerAccount":
                        tbAccount.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerPW":
                        tbPW.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Report":
                        tbPathReport.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Database":
                        tbPathDb.Text = dt.Rows[i]["ADDR"].ToString();
                        break;
                }
            }
#endif
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("ADDR", typeof(string));

            dt.Rows.Add("Local", tbPathBackup.Text);
            dt.Rows.Add("Server", tbPathServer.Text);
            dt.Rows.Add("ServerAccount", tbAccount.Text);
            dt.Rows.Add("ServerPW", tbPW.Text);
            dt.Rows.Add("Report", tbPathReport.Text);
            dt.Rows.Add("Database", tbPathDb.Text);

            DaoErrMsg Msg = DaoSQL.Instance.UpdateBackupInfo(dt);
            if(Msg.isError == false)
            {
                MessageBoxEx.Show(this, "資訊儲存成功.", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult Ret = MessageBoxEx.Show(this, "確定要更新本地端[車型代號]及[操作員代號]資訊??", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ret != DialogResult.Yes)
                return;

            this.Cursor = Cursors.AppStarting;

            string Msg = string.Empty;
            DbCheckState DbState = MyNetworkPlacesDbTest(out Msg);

            switch (DbState)
            {
                case DbCheckState.eDB_FOUND:
                    DaoErrMsg Err = DaoSQL.Instance.UpdateLocalDatabase(tbPathDb.Text);

                    if (Err.isError)
                    {
                        MessageBoxEx.Show(this, Err.ErrorMsg, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBoxEx.Show(this, "[車型代號]及[操作員代號]已更新", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case DbCheckState.eDB_NOT_FOUND:
                case DbCheckState.eDB_PATH_ERROR:
                    MessageBoxEx.Show(this, string.Format("更新失敗!\r\n錯誤資訊:{0}", Msg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;                

                case DbCheckState.eDB_PATH_FIELD_EMPTY:
                    break;
            }

            this.Cursor = Cursors.Default;
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            DialogResult Ret = MessageBoxEx.Show(this, "確定要上傳本地端[車型代號]及[操作員代號]至伺服器??", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ret != DialogResult.Yes)
                return;

            this.Cursor = Cursors.AppStarting;

            string Msg = string.Empty;
            DbCheckState DbState = MyNetworkPlacesDbTest(out Msg);

            switch (DbState)
            {
                case DbCheckState.eDB_FOUND:
                    //查遠端資料庫存在,更新指定資料表;//
                    DaoErrMsg Err = DaoSQL.Instance.UploadLocalDatabase(tbPathDb.Text);
                    if (Err.isError)
                    {
                        MessageBoxEx.Show(this, Err.ErrorMsg, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBoxEx.Show(this, "[車型代號]及[操作員代號]資訊已上傳成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case DbCheckState.eDB_NOT_FOUND:
                    //查遠端資料庫不存在,直接上傳本地端的DB;//
                    DaoSQL.Instance.CloseDatabase();
                    string DestPath = Path.GetDirectoryName(tbPathDb.Text);
                    string FileName = Path.GetFileName(tbPathDb.Text);

                    if (DestPath == null)
                    {
                        DestPath = tbPathDb.Text;
                        FileName = DaoConfigFile.Instance.m_FileDatabase;
                    }
                    else if(FileName == null || FileName.Length == 0 || Path.GetExtension(FileName) != "mdb")
                    {
                        FileName = DaoConfigFile.Instance.m_FileDatabase;
                    }
                    
                    NetTranslate.Transport(DaoConfigFile.Instance.FileDatabase, DestPath, FileName);
                    MessageBoxEx.Show(this, "[車型代號]及[操作員代號]資訊已上傳成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DaoSQL.Instance.OpenDatabase();
                    break;
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 本地端路徑設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();

            if (this.tbPathBackup.Text.Length > 0)
                Path.SelectedPath = this.tbPathBackup.Text;
            else
                Path.SelectedPath = Directory.GetCurrentDirectory();

            if (Path.ShowDialog() == DialogResult.OK)
            {
                tbPathBackup.Text = Path.SelectedPath;
            }
        }

        /// <summary>
        /// 檢查Control元件是否有輸入數值
        /// </summary>
        /// <param name="Tb"></param>
        /// <param name="Lbl"></param>
        /// <returns></returns>
        private bool CheckControl(Control Com, Label Lbl)
        {
            if (string.IsNullOrEmpty(Com.Text))
            {
                MessageBoxEx.Show(this, string.Format("請輸入 [{0}] 欄位資訊.", Lbl.Text), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Com.Focus();
                return false;
            }

            return true;
        }

        private void BtnServerTest_Click(object sender, EventArgs e)
        {
            //檢查必要欄位;//
            if ( this.CheckControl(tbPathServer, lblTitleServer) == false)
                return;

            this.Cursor = Cursors.AppStarting;

            if( MyNetworkPlacesTest(tbPathServer.Text, true) == false)
            {
                this.Cursor = Cursors.Default;
                return;
            }

            MessageBoxEx.Show(this, "伺服器連接成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Cursor = Cursors.Default;
        }

        private void BtnServerDbTest_Click(object sender, EventArgs e)
        {
            //檢查必要欄位;//
            if (this.CheckControl(tbPathDb, lblTitleDb) == false)
                return;
            
            this.Cursor = Cursors.AppStarting;

            string Msg = string.Empty;
            if(MyNetworkPlacesDbTest(out Msg) != DbCheckState.eDB_FOUND )
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, string.Format("資料庫連接失敗!\r\n錯誤資訊:{0}", Msg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBoxEx.Show(this, "資料庫連接成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Cursor = Cursors.Default;
        }
                
        private DbCheckState MyNetworkPlacesDbTest(out string ErrMsg)
        {
            ErrMsg = string.Empty;

            //檢查必要欄位;//
            if (this.CheckControl(tbPathDb, lblTitleDb) == false)
                return DbCheckState.eDB_PATH_FIELD_EMPTY;

            if (MyNetworkPlacesTest(tbPathServer.Text, true) == false)
                return DbCheckState.eDB_PATH_ERROR;

            DaoErrMsg Err = DaoSQL.Instance.CheckServerDb(tbPathDb.Text);
            if (Err.isError == true)
            {
                ErrMsg = Err.ErrorMsg;
                return DbCheckState.eDB_NOT_FOUND;
            }

            return DbCheckState.eDB_FOUND;
        }

        private bool MyNetworkPlacesTest(string Path, bool isClose)
        {
            NetTranslate.KillLink(tbPathServer.Text);

            if (NetTranslate.connectState(Path, tbAccount.Text, tbPW.Text) == false)
            {
                return false;
            }

            if (isClose)
                NetTranslate.KillLink(tbPathServer.Text);

            return true;
        }
    }
}
