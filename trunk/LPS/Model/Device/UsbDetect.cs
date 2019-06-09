using System.Windows.Forms;
using LPS.Model.Log;

namespace LPS.Model.Device
{
    /// <summary>
    /// 用來偵測USB設備的插拔通知
    /// </summary>
    class UsbDetect
    {
        #region 委派事件

        /// <summary>
        /// 有裝置狀態改變的通知
        /// </summary>
        public delegate void DeviceNodeChangeDelegate();

        public event DeviceNodeChangeDelegate DeviceNodeChange;

        #endregion

        #region win32 Device 參數

        private const int WM_DEVICECHANGE          = 0x219;
        private const int DBT_DEVICEARRIVAL        = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVICETYPESPECIFIC   = 0x8005;
        private const int DBT_DEVNODES_CHANGED     = 0x0007;
        private const int DBT_DEVTYP_VOLUME        = 0x00000002;

        #endregion

        /// <summary>
        /// Main Form要繼承並複寫 WndProc(ref Message m);
        /// 呼叫base.WndProc(ref m);後
        /// 再呼叫此Function
        /// </summary>
        /// <param name="m"></param>
        public void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        //LPTX會被視為網路裝置，所以不會有Device的Arrival及RemoveComplete事件;//
                        //只會有Dev Nodes Changed事件;//
                        //case DBT_DEVICEARRIVAL:
                        //    {
                        //        Logger.Debug("New Device Arrive");
                        //    }
                        //    break;

                        //case DBT_DEVICEREMOVECOMPLETE:
                        //    {
                        //        Logger.Debug("Device Removed");
                        //    }
                        //    break;

                        case DBT_DEVNODES_CHANGED:
                            {
                                Logger.Debug("Device Changed");
                                DeviceNodeChange?.Invoke();
                            }
                            break;                            
                    }
                    break;
            }
        }
    }
}
