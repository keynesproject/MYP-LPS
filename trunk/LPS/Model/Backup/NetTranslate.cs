using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.Model.FileExport;

namespace LPS.Model.Network
{
    internal class NetTranslate
    {
        internal static void test()
        {
            KillLink(@"\\192.168.0.130\TestScan");

            if (connectState(@"\\192.168.0.130\TestScan", @"QUANTA\10801049", "Qwpo1111") == false)
                return;

            //匯出本日報表;//
            //先取得所有資料集;//
            DataSet Ds = new DataSet();
            Ds.Tables.Add(DaoSQL.Instance.GetTestHistory("2008/8/6 00:00:00", "2008/8/6 23:59:59"));

            //輸出檔案成Excel檔;//
            try
            {
                FileExport.FileExport.ExportDataSetToExcel(Ds, "./Test.xls");
            }
            catch (Exception ex)
            {
                return;
            }

            Transport("./Test.xls", @"\\192.168.0.130\TestScan\123456", "./Test.xls");

            KillLink(@"\\192.168.0.130\TestScan");
        }

        /// <summary>
        /// 連線遠端共享資料夾
        /// </summary>
        /// <param name="path">遠端共享資料夾的路徑</param>
        /// <param name="userName">使用者名稱</param>
        /// <param name="passWord">密碼</param>
        /// <returns></returns>
        internal static bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            bool isTimeOut = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = "net use " + path;
                if(passWord.Length > 0 && userName.Length > 0)
                {
                    dosLine = dosLine + " " + passWord + " /user:" + userName;
                }
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                    if ((DateTime.Now - proc.StartTime).Seconds >= 10)
                    {
                        isTimeOut = true;
                        break;
                    }
                }
                string errormsg = isTimeOut == true ? "連線逾時!請檢查網路狀態或伺服器路徑!" : proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    MessageBox.Show(errormsg, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }

        /// <summary>
        /// 向遠端資料夾儲存本地內容，或者從遠端資料夾下載檔案到本地
        /// </summary>
        /// <param name="src">要儲存的檔案的路徑，如果儲存檔案到共享資料夾，這個路徑就是本地檔案路徑如：@"D:\1.avi"</param>
        /// <param name="dst">儲存檔案的路徑，不含名稱及副檔名</param>
        /// <param name="fileName">儲存檔案的名稱以及副檔名</param>
        internal static void Transport(string src, string dst, string fileName)
        {
            FileStream inFileStream = new FileStream(src, FileMode.Open);
            if (!Directory.Exists(dst))
            {
                Directory.CreateDirectory(dst);
            }
            dst = dst + "\\" + fileName;
            FileStream outFileStream = new FileStream(dst, FileMode.OpenOrCreate);

            byte[] buf = new byte[inFileStream.Length];

            int byteCount;

            while ((byteCount = inFileStream.Read(buf, 0, buf.Length)) > 0)
            {
                outFileStream.Write(buf, 0, byteCount);
            }

            inFileStream.Flush();

            inFileStream.Close();

            outFileStream.Flush();

            outFileStream.Close();
        }

        /// <summary>
        /// 關閉所有共享連線
        /// </summary>
        internal static void KillAllLink()
        {
            string cKillCmd = @"Net Use /delete * /yes";
            CallCmd(cKillCmd);
        }

        /// <summary>
        /// 關閉指定連線
        /// </summary>
        /// <param name="path">共享路徑</param>
        internal static void KillLink(string path)
        {
            string cKillCmd = @"Net Use " + path + " /delete /yes";
            CallCmd(cKillCmd);
        }

        /// <summary> 
        /// 呼叫Cmd命令 
        /// </summary> 
        /// <param name="strCmd">命令列引數</param> 
        private static void CallCmd(string strCmd)
        {
            //呼叫cmd命令 
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.Arguments = "/c " + strCmd;
                myProcess.StartInfo.UseShellExecute = false;    //關閉Shell的使用 
                myProcess.StartInfo.RedirectStandardInput = true;  //重定向標準輸入 
                myProcess.StartInfo.RedirectStandardOutput = true; //重定向標準輸出 
                myProcess.StartInfo.RedirectStandardError = true;  //重定向錯誤輸出 
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch { }
            finally
            {
                myProcess.WaitForExit();
                if (myProcess != null)
                {
                    myProcess.Close();
                }
            }
        }
    }
}
