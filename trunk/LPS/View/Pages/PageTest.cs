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
using LPS.View.Component;
using LPS.Model.Network;

namespace LPS.View.Pages
{
    public partial class PageTest : UserControl
    {
        private DaoMachine m_Machine = new DaoMachine();

        private DaoUser m_User = new DaoUser();

        private DaoPartNumber m_PN = new DaoPartNumber();

        private DaoLastTestResult m_LastTest = null;

        private string m_InputPnInfo = "請輸入或搜尋件號";

        /// <summary>
        /// 紀錄測試設備是否連接
        /// </summary>
        private bool m_isUsbDeviceConnect = false;

        /// <summary>
        /// 紀錄是否輸入正確件號
        /// </summary>
        private bool m_isInputPn = false;

        /// <summary>
        /// 測試結果事件通知
        /// </summary>
        internal delegate void LastTestResultDelegate(DaoLastTestResult Ret);

        /// <summary>
        /// 測試結果事件
        /// </summary>
        internal event LastTestResultDelegate LastTestResultEvent;

        public enum eTestType
        {
            eTT_MAIN = 0,
            eTT_PRINT,
        }

        private enum eTestIconState
        {
            eTEST_NULL,
            eTEST_WAITING,
            eTEST_OK,
            eTEST_NG,
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

            switch (Type)
            {
                case eTestType.eTT_MAIN:
                    break;
                case eTestType.eTT_PRINT:
                    tbSerial.Enabled = true;
                    btnLU.Visible = true;
                    btnRU.Visible = true;
                    btnLD.Visible = true;
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
            m_isUsbDeviceConnect = isConnect;

            if (m_isUsbDeviceConnect == true && m_isInputPn == true)
            {
                //顯示測試中圖示;//
                SetTestIcon(eTestIconState.eTEST_WAITING);
            }
            else
            {
                SetTestIcon(eTestIconState.eTEST_NULL);
            }
        }

        /// <summary>
        /// 測試結果設定
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="ByOp"></param>
        internal void TestResult(bool isSuccess, bool ByOp = false)
        {
            if (m_isUsbDeviceConnect == false)
            {
                Invoke((MethodInvoker)delegate
                {
                    MessageBoxEx.Show(this, "請先連接測試設備!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                });
                return;
            }

            if (m_isInputPn == false)
            {
                //Invoke((MethodInvoker)delegate
                //{
                //    MessageBoxEx.Show(this, "請輸入有效友永件號!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //});
                return;
            }

            Invoke((MethodInvoker)delegate
            {
                SetTestIcon(isSuccess == true ? eTestIconState.eTEST_OK : eTestIconState.eTEST_NG);

                //填上流水編號;//
                DateTime LastTestTime = Properties.Settings.Default.LastTestTime;
                TimeSpan ts = DateTime.Now - LastTestTime;
                if (ts.Days > 0)
                    Properties.Settings.Default.TestSerial = 1;
                else
                    Properties.Settings.Default.TestSerial++;

                if (ByOp == false)
                    tbSerial.Text = String.Format("{0:0000000}", Properties.Settings.Default.TestSerial.ToInt());
                else
                    tbSerial.Text = String.Format("H{0:000000}", Properties.Settings.Default.TestSerial.ToInt());

                //紀錄測試時間;//
                Properties.Settings.Default.LastTestTime = DateTime.Now;

                //儲存資訊;//
                Properties.Settings.Default.Save();
            });

            //紀錄結果資訊;//
            DaoSQL.Instance.SaveTestResult(tbSerial.Text, m_Machine, m_User, m_PN, isSuccess == true ? "OK" : "NG", Properties.Settings.Default.LastTestTime);

            if (ByOp == false)
            {
                if (m_LastTest == null)
                    m_LastTest = new DaoLastTestResult();
                m_LastTest.isSuccess = isSuccess;
                m_LastTest.PN = m_PN;
                m_LastTest.Serial = tbSerial.Text;
                m_LastTest.TestTime = Properties.Settings.Default.LastTestTime;
            }

            //列印結果標籤;//            
            //TscTtp247.Instance.PrintLabel(tbSerial.Text, m_Machine, m_PN, isSuccess == true ? "OK" : "NG", Properties.Settings.Default.LastTestTime);
            if (isSuccess == true)
                TscTtp247.Instance.PrintOK(tbSerial.Text, m_Machine, m_PN, Properties.Settings.Default.LastTestTime);            
            else
                TscTtp247.Instance.PrintNG(Properties.Settings.Default.LastTestTime);

            if (m_LastTest != null)
                LastTestResultEvent?.Invoke(m_LastTest);
        }

        internal void SetTestResult(DaoLastTestResult Ret)
        {
            if (m_LastTest == null)
                m_LastTest = new DaoLastTestResult();
            m_LastTest = Ret;

            Invoke((MethodInvoker)delegate
            {
                tbPN.Text = m_LastTest.PN.件號;
                tbSerial.Text = m_LastTest.Serial;
            });
        }

        /// <summary>
        /// 設定測試圖示
        /// </summary>
        /// <param name="State"></param>
        private void SetTestIcon(eTestIconState State)
        {
            Invoke((MethodInvoker)delegate
            {
                switch (State)
                {
                    case eTestIconState.eTEST_NULL:
                        pbResult.Image = null;
                        pbResult.BackgroundImage = null;
                        break;
                    case eTestIconState.eTEST_WAITING:
                        //顯示測試中圖示;//
                        pbResult.Image = Properties.Resources.Testing;
                        pbResult.BackgroundImage = null;
                        break;
                    case eTestIconState.eTEST_OK:
                        pbResult.Image = null;
                        pbResult.BackgroundImage = Properties.Resources.TestOK;
                        break;
                    case eTestIconState.eTEST_NG:
                        pbResult.Image = null;
                        pbResult.BackgroundImage = Properties.Resources.TestNG;
                        break;
                }
            });
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
            SetTestIcon(eTestIconState.eTEST_NULL);

            if (   tbPN.Text.Length <= 0
                || tbPN.Text == m_InputPnInfo)
            {
                tbCarName.Text = "";
                tbCode.Text = "";
                tbSerial.Text = "";
                return;
            }

            //搜尋件號資訊;//
            m_PN = DaoSQL.Instance.GetPartNumber(tbPN.Text);
            if (m_PN != null)
            {
                tbPN.ForeColor = Color.Black;
                tbCarName.ForeColor = Color.Black;
                tbCarName.Text = m_PN.車型;
                tbCode.Text = m_PN.簡碼;
                m_isInputPn = true;

                //顯示測試中圖示;//
                SetTestIcon(eTestIconState.eTEST_WAITING);
            }
            else
            {
                tbCarName.ForeColor = Color.Red;
                tbCarName.Text = "查無此件號";
                tbCode.Text = "";
                tbSerial.Text = "";
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
            //清空件號資訊;//
            tbPN.Text = "";

            TbPN_Leave(sender, new EventArgs());
        }

        private void BtnLU_MouseUp(object sender, MouseEventArgs e)
        {
            //列印OK標籤;//
            TestResult(true, true);
        }

        private void BtnRU_MouseUp(object sender, MouseEventArgs e)
        {
            //列印NG標籤;//
            TestResult(false, true);
        }
        
        private void BtnLD_MouseUp(object sender, MouseEventArgs e)
        {
            //補印標籤;//
            if (m_LastTest == null)
            {
                MessageBoxEx.Show(this, "無最後一次測試紀錄資訊!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbPN.Text = m_LastTest.PN.件號;
            tbSerial.Text = m_LastTest.Serial;

            if (m_LastTest.isSuccess == true)
                TscTtp247.Instance.PrintOK(m_LastTest.Serial, m_Machine, m_LastTest.PN, m_LastTest.TestTime);
            else
                TscTtp247.Instance.PrintNG(m_LastTest.TestTime);
        }
    }
}
