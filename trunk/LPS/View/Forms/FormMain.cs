using LPS.Model.DataAccessObject;
using LPS.Model.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        /// <summary>
        /// 設備連線狀態
        /// </summary>
        private bool m_DevConnect = false;
        
        public FormMain(DaoMachine Machine, DaoUser User)
        {
            InitializeComponent();

            if(User.Permission == false)
            {
                tabMain.TabPages["tabPrinter"].Parent = null;
                tabMain.TabPages["tabSetting"].Parent = null;
            }

            m_User = User;
            ptMain.Setup(Pages.PageTest.eTestType.eTT_MAIN, Machine, User);
            ptMain.LastTestResultEvent += this.LastTestResult;
            ptPrint.Setup(Pages.PageTest.eTestType.eTT_PRINT, Machine, User);
            DevCtrl.Instance.CH340ConnectChange += this.TestDeviceConnectState;
            DevCtrl.Instance.TestResult += this.TestResult;

            DaoSnControl.Instance.UpdateSnEvent += this.SnUpdate;
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
            tsStatus.Text = string.Format( "測試設備連接狀態 : {0}", isConnect == true ? "已連線" : "未連線");
            m_DevConnect = isConnect;

            ptMain.DeviceConnectState(isConnect);
            ptPrint.DeviceConnectState(isConnect);
        }

        private void TestResult(bool isSuccess)
        {
            ptMain.TestResult(isSuccess);
        }

        private void LastTestResult(DaoLastTestResult Ret)
        {
            ptPrint.SetTestResult(Ret);
        }
    }
}
