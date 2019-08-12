using LPS.Model.DataAccessObject;
using LPS.Model.Log;
using LPS.Model.OS;
using MypKey;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPS
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }

        /// <summary>   
        /// 確認是否有安裝指定程式
        /// </summary>   
        /// <returns>true: 有安裝, false:沒有安裝</returns>   
        private bool CheckSoftwareInstall(string Name)
        {
            Microsoft.Win32.RegistryKey uninstallNode = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            foreach (string subKeyName in uninstallNode.GetSubKeyNames())
            {
                Microsoft.Win32.RegistryKey subKey = uninstallNode.OpenSubKey(subKeyName);
                object displayName = subKey.GetValue("DisplayName");
                if (displayName != null)
                {
                    if (displayName.ToString().Contains(Name))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private string StripDir(string fullPath)
        {
            string retValue = default(string);

            if (fullPath != null && fullPath != string.Empty && fullPath != default(string))
            {
                retValue = fullPath.Substring(0, fullPath.LastIndexOf(@"\"));
            }

            return retValue;

        }

        /// <summary>
        /// 安裝指定程式
        /// </summary>
        /// <param name="ExeName">執行檔名稱</param>
        /// <param name="InstallInfo">是否顯示訊息視窗</param>
        void InstallExe(string ExeName, bool InstallInfo = false)
        {
            if (InstallInfo == true)
            {
                //顯示必須安裝的訊息;//
                string Info = string.Format("你必須安裝\"{0}\",才可執行友永標籤作業平台程式.\r\n是否現在要安裝?", ExeName);                
                DialogResult Result = MessageBox.Show(Info, "安裝必要軟體", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    MessageBox.Show("程式關閉", "關閉", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(Environment.ExitCode);
                    return;
                }
            }

            string InstallerPath;
            if (Context != null)
            {
                //安裝程序中的資料路徑;//
                InstallerPath = StripDir(Context.Parameters["AssemblyPath"]) + @"\Data\Installations\" + ExeName;
            }
            else
            {
                //Console程序執行中的安裝路徑;//
                InstallerPath = System.Environment.CurrentDirectory + @"\Data\Installations\" + ExeName;
            }

            if (File.Exists(InstallerPath))
            {
                ProcessStartInfo pInfo = new ProcessStartInfo();
                pInfo.FileName = InstallerPath;
                pInfo.UseShellExecute = true;

                Process p = Process.Start(pInfo);
                p.WaitForExit();
            }
            else
            {
                if (InstallInfo == true)
                {
                    string Info = string.Format("找不到安裝套件\"{0}\"!\r\n程式關閉.{1}", ExeName, InstallerPath);
                    MessageBox.Show(Info, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(Environment.ExitCode);
                }
            }
        }

        /// <summary>
        /// 檢查是否有安裝過指定的程式，沒有的話執行安裝
        /// </summary>
        /// <param name="ApplicationName">安裝過後"新增移除畫面"的顯示名稱</param>
        /// <param name="ExeName">安裝檔名稱</param>
        /// <param name="InstallInfo">是否顯示訊息視窗</param>
        private void InstallCustomExe(string ApplicationName, string ExeName, bool InstallInfo = false)
        {
            if (CheckSoftwareInstall(ApplicationName) == false)
            {
                InstallExe(ExeName, InstallInfo);
            }
        }

        /// <summary>
        /// 建立試用序號，若已建立過並不會重複建立
        /// </summary>
        private void CreateTrialSerialKey()
        {
            //建立30天試用序號;//
            MypSerialKeyValidator KeyGen = new MypSerialKeyValidator("LPS");
            KeyGen.CreateTrialSerialKey(30);
        }

        /// <summary>
        /// 檢查.netFramWork版本是否為4.0以上，不是則執行安裝程序
        /// </summary>
        private void CheckDotNetVersion()
        {
            float Version = DotNetVersion.GetVersion();
            if (Version >= 4.0f)
            {
                return;
            }

            InstallExe("dotNetFx40_Full_x86_x64.exe", true);
        }

        /// <summary>
        /// 程序開啟時檢查必要安裝程序
        /// </summary>
        public void CheckNecessaryInstall()
        {
            //檢查.netFrameWork;//
            CheckDotNetVersion();
        }

        public override void Install(IDictionary stateSaver)
        {
            //檢查.netFrameWork;//
            CheckDotNetVersion();

            //建立試用序號;//
            CreateTrialSerialKey();

            base.Install(stateSaver);
        }

        /// <summary>
        /// 移除非60天以上未更新的LOG檔案
        /// </summary>
        private void RemoveLogFile()
        {
            string[] FileName = null;
            string LogFilePath = string.Empty;
            if (Context != null)
            {
                //安裝程序中的資料路徑;//
                LogFilePath = StripDir(Context.Parameters["AssemblyPath"]) + DaoConfigFile.Instance.DirLog;
            }
            else
            {
                //Console程序執行中的安裝路徑;//
                LogFilePath = System.Environment.CurrentDirectory + DaoConfigFile.Instance.DirLog;
            }

            //取得Log資料夾下所有的檔案名稱;//
            FileName = Directory.GetFiles(LogFilePath);

            //取得現在時間;//
            DateTime Today = DateTime.Now;
            DateTime FileTime;

            foreach (string File in FileName)
            {
                FileTime = System.IO.File.GetLastWriteTime(File);

                if ((Today - FileTime).Days >= 60)
                {
                    try
                    {
                        System.IO.File.Delete(File);
                    }
                    catch (System.Exception)
                    {
                        return;
                    }
                }
            }
        }

        public override void Uninstall(IDictionary savedState)
        {
            try
            {
                RemoveLogFile();
            }
            catch (Exception)
            {

            }

            base.Uninstall(savedState);
        }
    }
}
