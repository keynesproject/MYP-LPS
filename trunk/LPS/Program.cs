using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.Model.Log;
using LPS.View.Forms;

namespace LPS
{
    static class Program
    {

        //用於防止程式多開;//
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;


        /// <summary>
        /// 紀錄當前登入的使用者
        /// </summary>
        private static DaoUser m_LoginUser = new DaoUser();

        /// <summary>
        /// 紀錄當前登入的機台
        /// </summary>
        private static DaoMachine m_Machine = new DaoMachine();

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Get the running instance.   
            Process instance = RunningInstance();
            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.DoEvents();

                Logger.Info("LPS application booting.");
                
                //開啟資料庫;//
                DaoSQL.Instance.OpenDatabase();

                while (true)
                {
                    //驗證本機序號;//
                    if (FormSnVerify.VerifyMachineSN() == false)
                    {
                        Logger.Info("SN verify failure from program.");
                        break;
                    }

                    DialogResult Ret = DialogResult.Cancel;

                    //Login畫面;//
                    Ret = ShowLoginForm();
                    if (Ret != DialogResult.OK)
                    {
                        Logger.Info("LPS application is closed from login form.");
                        break;
                    }

                    Logger.Info("LPS login success.");

                    //登入成功，顯示主畫面;//
                    FormMain LpsMain = new FormMain(m_Machine, m_LoginUser);
                    LpsMain.BringToFront();
                    Ret = LpsMain.ShowDialog();
                    //Application.Run(LpsMain);
                    
                    //釋放主畫面資源;//
                    LpsMain.Close();
                    LpsMain.Dispose();

                    //判斷是否為關閉視窗//
                    if (Ret != DialogResult.Retry)
                    {
                        Logger.Info("LPS application is closed from main form.");
                        break;
                    }

                    Logger.Info("LPS main from logout.");
                }
            }
            else
            {
                //There is another instance of this process.
                HandleRunningInstance(instance);
            }
            
            Logger.Info("LPS application close.");

            //強制關閉，避免因thread或是timer尚在啟動，造成程式無法關閉;//
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// 顯示Login畫面
        /// </summary>
        /// <returns></returns>
        private static DialogResult ShowLoginForm()
        {
            FormLogin LpsLogin = new FormLogin();
            LpsLogin.UserLogin += UserLogin;
            LpsLogin.BringToFront();

            DialogResult Ret = LpsLogin.ShowDialog();
            LpsLogin.UserLogin -= UserLogin;
            LpsLogin.Close();
            LpsLogin.Dispose();

            return Ret;
        }

        private static void UserLogin(DaoMachine Machine, DaoUser User)
        {
            m_Machine = Machine;
            m_LoginUser = User;
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //Loop through the running processes in with the same name
            foreach (Process process in processes)
            {
                //Ignore the current process   
                if (process.Id != current.Id)
                {
                    //Make sure that the process is running from the exe file.
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance.   
                        return process;
                    }
                }
            }

            //No other instance was found, return null. 
            return null;
        }

        public static void HandleRunningInstance(Process instance)
        {
            //Make sure the window is not minimized or maximized   
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);

            //Set the real intance to foreground window
            SetForegroundWindow(instance.MainWindowHandle);
        }
    }
}
