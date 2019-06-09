using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.Model.Extension;
using LPS.View.Forms;
using LPS.Model.Device;

namespace LPS.View.Pages
{
    public partial class PageTest : UserControl
    {
        private DaoMachine m_Machine = new DaoMachine();

        private DaoUser m_User = new DaoUser();

        private eTestType m_Type = eTestType.eTT_MAIN;

        private DaoPartNumber m_PN = new DaoPartNumber();

        private bool m_isDeviceConnect = false;

        private string m_InputPnInfo = "請輸入或搜尋件號";

        private bool m_isTesting = false;
        public enum eTestType
        {
            eTT_MAIN = 0,
            eTT_PRINT,
        }
        public PageTest()
        {
            InitializeComponent();
        }

        internal void Setup(eTestType Type, DaoMachine Machine, DaoUser User)
        {
            m_Machine = Machine;
            m_User = User;

            lblMachineNo.Text = Machine.機台代碼;
            lblUserID.Text = User.代碼;
            lblUserName.Text = User.作業員姓名;

            m_Type = Type;
            switch (Type)
            {
                case eTestType.eTT_MAIN:
                    btnLU.Visible = false;
                    btnRU.Visible = false;
                    btnLD.Enabled = false;
                    btnRD.Visible = false;
                    break;
                case eTestType.eTT_PRINT:
                    btnLD.Text = "補印OK";
                    btnRD.Text = "補印NG";
                    tbSerial.Enabled = true;
                    break;
                default:
                    break;
            }

            //先觸發一次時間;//
            TimerNow_Tick(new object(), new EventArgs());
        }


        /// <summary>
        /// 測試設備連接狀態設定
        /// </summary>
        /// <param name="isConnect"></param>
        internal void DeviceConnectState(bool isConnect)
        {
            m_isDeviceConnect = isConnect;

            Invoke((MethodInvoker)delegate
            {
                //觸發一次PN輸入事件;//
                this.TbPN_TextChanged(this, new EventArgs());
            });
        }
        
        /// <summary>
        /// 測試結果設定
        /// </summary>
        /// <param name="isSuccess"></param>
        internal void TestResult(bool isSuccess)
        {
            if (m_isTesting == false)
                return;

            Invoke((MethodInvoker)delegate
            {
                pbResult.Image = null; 
            
                pbResult.BackgroundImage = isSuccess == true ? Properties.Resources.TestOK : Properties.Resources.TestNG;

                tbPN.ReadOnly = false;
                btnPN.Enabled = true;
                btnLD.Enabled = true;
                btnRD.Text = "重新輸入";
            });

            //紀錄結果資訊;//
            DaoSQL.Instance.SaveTestResult(tbSerial.Text, m_Machine, m_User, m_PN, isSuccess == true ? "OK" : "NG", Properties.Settings.Default.LastTestTime);
            
            //列印結果標籤;//
            TscTtp247.Instance.PrintLabel(tbSerial.Text, m_Machine, m_PN, isSuccess == true ? "OK" : "NG", Properties.Settings.Default.LastTestTime);

            m_isTesting = false;
        }

        /// <summary>
        /// 現在時間Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerNow_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy/MM/dd tt HH:mm:ss");
        }

        /// <summary>
        /// PN欄位植有更動事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPN_TextChanged(object sender, EventArgs e)
        {
            if (tbPN.Text.Length <= 0
                || tbPN.Text == m_InputPnInfo)
            {
                tbCarName.Text = "";
                tbCode.Text = "";
                tbSerial.Text = "";
                if(m_Type == eTestType.eTT_MAIN)
                    btnLD.Enabled = false;
                return;
            }

            //搜尋件號資訊;//
            m_PN = DaoSQL.Instance.GetPartNumber(tbPN.Text);
            if (m_PN != null)
            {
                tbCarName.ForeColor = Color.Black;
                tbCarName.Text = m_PN.車型;
                tbCode.Text = m_PN.簡碼;
            }
            else
            {
                tbCarName.ForeColor = Color.Red;
                tbCarName.Text = "查無此件號";
                tbCode.Text = "";
                tbSerial.Text = "";
            }

            switch (m_Type)
            {
                case eTestType.eTT_MAIN:
                    if (m_PN != null && m_isDeviceConnect == true)
                        btnLD.Enabled = true;
                    else
                        btnLD.Enabled = false;
                    tlpRight.Refresh();
                    break;

                case eTestType.eTT_PRINT:                    

                    break;
            }            
        }

        private void TbPN_Enter(object sender, EventArgs e)
        {
            if (tbPN.Text == m_InputPnInfo)
            {
                tbPN.Text = "";
                tbPN.ForeColor = Color.Black;
            }
        }

        private void TbPN_Leave(object sender, EventArgs e)
        {
            if (tbPN.Text.Length <= 0)
            {
                tbPN.Text = m_InputPnInfo;
                tbPN.ForeColor = Color.DarkGray;
            }
        }

        private void BtnLD_MouseUp(object sender, MouseEventArgs e)
        {
            switch (m_Type)
            {
                case eTestType.eTT_MAIN:
                    if (m_isDeviceConnect == true)
                        StartTest();
                    break;
                case eTestType.eTT_PRINT:
                    break;
            }
        }

        private void StartTest()
        {            
            //填上流水編號;//
            TimeSpan ts = DateTime.Now - Properties.Settings.Default.LastTestTime;
            if (ts.Days > 0)
                Properties.Settings.Default.TestSerial = 1;
            else
                Properties.Settings.Default.TestSerial++;
            tbSerial.Text = String.Format("{0:0000000}", Properties.Settings.Default.TestSerial.ToInt());

            //紀錄測試時間;//
            Properties.Settings.Default.LastTestTime = DateTime.Now;

            //儲存資訊;//
            Properties.Settings.Default.Save();

            //顯示測試中圖示;//
            pbResult.Image = Properties.Resources.Testing;
            pbResult.BackgroundImage = null;

            tbPN.ReadOnly = true;
            btnPN.Enabled = false;
            btnLD.Enabled = false;
            btnRD.Text = "停止測試";
            btnRD.Visible = true;

            //設定開始測試旗標;//
            m_isTesting = true;
        }

        private void StopTest()
        {
            if (m_isTesting == false)
                return;

            m_isTesting = false;

            tbPN.ReadOnly = false;
            btnPN.Enabled = true;
            btnLD.Enabled = true;
            btnRD.Visible = false;
            pbResult.Image = null;
            pbResult.BackgroundImage = Properties.Resources.TestStop;

            //紀錄停止測試資訊;//
            DaoSQL.Instance.SaveTestResult(tbSerial.Text, m_Machine, m_User, m_PN, "Stop", Properties.Settings.Default.LastTestTime);
        }

        private void BtnPN_MouseUp(object sender, MouseEventArgs e)
        {
            FormSearchPN FormPN = new FormSearchPN();
            DialogResult ret = FormPN.ShowDialog();
            if (ret == DialogResult.OK)
            {
                tbPN.Text = FormPN.GetPN();
                tbPN.ForeColor = Color.Black;
            }
        }

        private void BtnRD_MouseUp(object sender, MouseEventArgs e)
        {
            switch (m_Type)
            {
                case eTestType.eTT_MAIN:
                    if (m_isTesting == true)
                    {
                        //表示正在測試中按下此按鈕，要停止測試;//
                        StopTest();
                    }
                    else
                    {
                        //表示非在測試中按下此按鈕，要清除件號設定;//
                        tbPN.Text = "";
                        btnRD.Visible = false;
                        pbResult.BackgroundImage = null;
                    }
                    break;

                case eTestType.eTT_PRINT:
                    break;
            }
        }
    }
}
