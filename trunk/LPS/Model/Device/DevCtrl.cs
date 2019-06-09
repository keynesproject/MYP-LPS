using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPS.Model.Device
{
    public class DevCtrl
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly DevCtrl m_instance = new DevCtrl();

        internal static DevCtrl Instance { get { return m_instance; } }

        #endregion

        /// <summary>
        /// USB狀態偵測通知
        /// </summary>
        private UsbDetect m_UsbDetector = new UsbDetect();

        /// <summary>
        /// CH340連線狀態改變事件
        /// </summary>
        public delegate void Ch340ConnectChangeDelegate(bool isConnect);

        public event Ch340ConnectChangeDelegate CH340ConnectChange;

        /// <summary>
        /// CH340連線狀態改變事件
        /// </summary>
        public delegate void TestResultDelegate(bool isSuccess);

        public event TestResultDelegate TestResult;

        DevCtrl()
        {
            //Windows裝置變動通知;//
            m_UsbDetector.DeviceNodeChange += this.DeviceChange;
            CH340.Instance.TestResult += this.CH340TestResult;
        }

        /// <summary>
        /// win事件通知
        /// 由Main Form繼承並複寫WndProc(ref Message m);
        /// 呼叫base.WndProc(ref m);後再呼叫此Function
        /// </summary>
        /// <param name="m">windows message</param>
        public void ConnectedDetect(ref Message m)
        {
            m_UsbDetector.WndProc(ref m);
        }

        /// <summary>
        /// Windows裝置變動通知
        /// </summary>
        internal void DeviceChange()
        {
            //偵測CH340;//
            Task.Factory.StartNew(() =>
            {
                CH340.Instance.CheckCH340();
                CH340ConnectChange?.Invoke(CH340.Instance.IsOpen);
            });
        }

        /// <summary>
        /// 測試結果通知
        /// </summary>
        /// <param name="isSuccess"></param>
        private void CH340TestResult(bool isSuccess)
        {
            TestResult?.Invoke(isSuccess);
        }
    }
}
