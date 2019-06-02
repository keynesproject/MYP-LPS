using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    public class DaoFingerPrint
    {
        public enum eConnectState
        {
            eCON_DISCONNECT = 0,
            eCON_CONNECTED,
            eCON_UNABLE,
            eCON_CLEAR_ATT
        }

        private string[] m_ConnectState = { "未連線", "已連線", "無法連線", "清除考勤資料" };

        /// <summary>
        /// 指紋機ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 指紋機名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 連線狀態
        /// </summary>
        public eConnectState Connect { get; set; }

        /// <summary>
        /// 連線狀態
        /// </summary>
        public string strConnect
        {
            get
            {                
                return m_ConnectState[(int)Connect];
            }
            set { }
        }

        /// <summary>
        /// 指紋機編號
        /// </summary>
        public int MachineNo { get; set; }

        /// <summary>
        /// 連線IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 考勤紀錄數量
        /// </summary>
        public int AttendanceCount { get; set; }

        /// <summary>
        /// 連線埠號
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 啟用狀態
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 啟用狀態
        /// </summary>
        public string strEnable
        {
            get
            {
                if (Enable == true)
                    return "啟用";
                else
                    return "禁用";
            }
            set { }
        }        
    }
}
