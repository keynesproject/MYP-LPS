using LPS.Model.DataAccessObject;
using LPS.Model.Device;
using LPS.Model.Log;
using LPS.View.Component;
using LPS.View.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace LPS.View.Forms
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 登入人員資訊
        /// </summary>
        private DaoUser m_User = new DaoUser();

        private DaoMachine m_Machine = new DaoMachine();

        /// <summary>
        /// 設備連線狀態
        /// </summary>
        private bool m_DevConnect = false;
        
        /// <summary>
        /// 紀錄最後一次選擇的頁面
        /// </summary>
        private int m_LastSelectIndex;

        /// <summary>
        /// 紀錄是否為管理者登錄
        /// </summary>
        private bool m_bPermissionLogin = false;

        private UserControl m_LastSettingPage = null;

        public FormMain(DaoMachine Machine, DaoUser User)
        {
            InitializeComponent();

            m_LastSelectIndex = tabMain.SelectedIndex;

            m_User = User;
            m_Machine = Machine;
            ptMain.Setup(Pages.PageTest.eTestType.eTT_MAIN, Machine, User);
            ptMain.LastTestResultEvent += this.LastTestResult;
            ptPrint.Setup(Pages.PageTest.eTestType.eTT_PRINT, Machine, User);
            DevCtrl.Instance.CH340ConnectChange += this.TestDeviceConnectState;
            DevCtrl.Instance.TestResult += this.TestResult;
            Uart.Instance.UartConnectChange += this.TestDeviceConnectState;
            Uart.Instance.TestResult += this.TestResult;

            DaoSnControl.Instance.UpdateSnEvent += this.SnUpdate;

            rbtnMachine.Checked = true;
        }

        private void SnUpdate(string SN, int ExpDay)
        {
            CheckSN();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DevCtrl.Instance.DeviceChange();

            CheckSN();
        }

        private void CheckSN()
        {
            int ExpDay = DaoSnControl.Instance.GetTrialExp();

            Invoke((MethodInvoker)delegate
            {
                if (ExpDay >= 0 && ExpDay <= 999)
                    this.Text = string.Format("{0} - 試用剩餘 {1} 天", Properties.Resources.AP_NAME, ExpDay);
                else
                    this.Text = Properties.Resources.AP_NAME;
            });
        }

        /// <summary>
        /// 用來偵測USB插拔事件
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            DevCtrl.Instance.ConnectedDetect(ref m);
        }

        /// <summary>
        /// 測試設備連線狀態更動通知
        /// </summary>
        /// <param name="isConnect"></param>
        private void TestDeviceConnectState(bool isConnect)
        {
            //UART的連線為優先，當UART沒連線時再判斷USB的連線狀態;//
            if (Uart.Instance.IsConnect() == false)
            {
                tsStatus.Text = string.Format("測試設備連接狀態 : {0}", isConnect == true ? "已連線" : "未連線");
                m_DevConnect = isConnect;

                ptMain.DeviceConnectState(isConnect);
                ptPrint.DeviceConnectState(isConnect);
            }
            else
            {
                tsStatus.Text = "測試設備連接狀態 : 已連線";

                m_DevConnect = true;
                ptMain.DeviceConnectState(true);
                ptPrint.DeviceConnectState(true);
            }
        }

        private void TestResult(bool isSuccess)
        {
            ptMain.TestResult(isSuccess);
        }

        private void LastTestResult(DaoLastTestResult Ret)
        {
            ptPrint.SetTestResult(Ret);
        }

        private void TabMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabMain.SelectedTab == tabMain.TabPages["tabLogout"])
            {
                DialogResult Ret = MessageBoxEx.Show(this, "是否真的要登出標籤作業平台?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Ret == DialogResult.Yes)
                {
                    Logger.Info(string.Format("User : {0} logout.", m_User.代碼));

                    //將視窗標示為 Retry 表示要回Login畫面;//
                    this.DialogResult = DialogResult.Retry;

                    this.Close();

                    return;
                }
                else
                {
                    //返回最後選取的頁面;//
                    tabMain.SelectedIndex = m_LastSelectIndex;
                }
            }
            else if(tabMain.SelectedTab == tabMain.TabPages["tabPrinter"] || tabMain.SelectedTab == tabMain.TabPages["tabSetting"])
            {
                if (m_User.Permission == false && m_bPermissionLogin == false)
                {
                    FormPermision Permision = new FormPermision();
                    DialogResult ret = Permision.ShowDialog();
                    if (ret == DialogResult.Cancel)
                    {
                        //返回最後選取的頁面;//
                        tabMain.SelectedIndex = m_LastSelectIndex;
                        m_bPermissionLogin = false;
                    }
                    else
                    {
                        m_bPermissionLogin = true;
                        string LoginUser = Permision.GetLoginUserCode();
                        DaoUser AdminUser = new DaoUser();
                        if (LoginUser == "myp")
                        {
                            AdminUser.代碼 = "MYP";
                            AdminUser.作業員姓名 = "木研科技";
                            AdminUser.密碼 = "53750804";
                            AdminUser.權限 = "Y";
                        }
                        else
                        {
                            AdminUser = DaoSQL.Instance.GetUser(LoginUser);
                        }
                        ptPrint.Setup(Pages.PageTest.eTestType.eTT_PRINT, m_Machine, AdminUser);
                    }
                    Permision.Close();
                    Permision.Dispose();
                }
            }

            //紀錄最後選取的葉面;//
            m_LastSelectIndex = tabMain.SelectedIndex;
        }

        private void TabMain_Selected(object sender, TabControlEventArgs e)
        {
            if (!(tabMain.SelectedTab == tabMain.TabPages["tabPrinter"] || tabMain.SelectedTab == tabMain.TabPages["tabSetting"]))
                m_bPermissionLogin = false;
        }

        private void Setting_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            if (rbtn.Checked == true)
            {
                if (m_LastSettingPage != null)
                {
                    this.tlpSettingBase.Controls.RemoveAt(2);
                    m_LastSettingPage.Dispose();
                    m_LastSettingPage = null;
                }

                switch (rbtn.Name)
                {
                    case string rbtnName when rbtnMachine.Name == rbtnName:
                        PageMachine pMachine = new PageMachine();
                        pMachine.Setup();
                        m_LastSettingPage = pMachine;
                        break;

                    case string rbtnName when rbtnCar.Name == rbtnName:
                        PageCars pCars = new PageCars();
                        pCars.Setup();
                        m_LastSettingPage = pCars;
                        break;

                    case string rbtnName when rbtnUser.Name == rbtnName:
                        PageUser pUser = new PageUser();
                        pUser.Setup();
                        m_LastSettingPage = pUser;
                        break;

                    case string rbtnName when rbtnBackup.Name == rbtnName:
                        PageBackup pBackup = new PageBackup();
                        pBackup.Setup();
                        m_LastSettingPage = pBackup;
                        break;

                    case string rbtnName when rbtnReport.Name == rbtnName:
                        PageReport pReport = new PageReport(m_Machine);
                        pReport.Setup();
                        m_LastSettingPage = pReport;
                        break;
                }

                tlpSettingBase.Controls.Add(m_LastSettingPage, 2, 0);
                m_LastSettingPage.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// 清空列印佇列資料
        /// </summary>
        private void CancelPrintJob()
        {
            ManagementObjectSearcher serrchPrintJobs;
            ManagementObjectCollection printJobCollection;

            try
            {
                string searchQuery = "SELECT * FROM Win32_PrintJob";
                serrchPrintJobs = new ManagementObjectSearcher(searchQuery);
                printJobCollection = serrchPrintJobs.Get();

                string jobName = null;
                char[] splitArr;
                int printJobID;
                foreach (ManagementObject printJob in printJobCollection)
                {
                    jobName = printJob.Properties["Name"].Value.ToString();

                    splitArr = new char[1];
                    splitArr[0] = Convert.ToChar(",");

                    printJobID = Convert.ToInt32(jobName.Split(splitArr)[1]);

                    printJob.Delete();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CancelPrintJob();
        }

        private void TsStatus_Click(object sender, EventArgs e)
        {
            if ((   m_DevConnect == true 
                  && Uart.Instance.IsConnect() == true ) 
                  || m_DevConnect == false)
            {
                FormSerialPort formSerial = new FormSerialPort();
                DialogResult ret = formSerial.ShowDialog();

                formSerial.Close();
                formSerial.Dispose();
            }
        }
    }
}
