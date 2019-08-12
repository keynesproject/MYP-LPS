using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace LPS.Model.Device
{
    public class Uart
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體
        private static class UartHolder
        {
            internal static readonly Uart Instance = new Uart();

            static UartHolder() { }
        }

        public static Uart Instance
        {
            get { return UartHolder.Instance; }
        }

        #endregion //Singleton物件宣告，Thread safe，並在使用時才會建立實體;//

        /// <summary>
        /// Uart連線狀態改變事件
        /// </summary>
        public delegate void UartConnectChangeDelegate(bool isConnect);
        public event UartConnectChangeDelegate UartConnectChange;

        /// <summary>
        /// 測試結果事件
        /// </summary>
        public delegate void TestResultDelegate(bool isOK);
        public event TestResultDelegate TestResult;

        private SerialPort m_Com = new SerialPort();
        
        public struct SerialPortInfo
        {
            public string Com { get; set; }
            public int BaudRate { get; set; }
            public int DataBits { get; set; }
            public Parity Parity { get; set; }
            public StopBits StopBits { get; set; }

            public SerialPortInfo(string com, int baudRate, int dataBits, Parity parity, StopBits stopBits)
            {
                this.Com = com;
                this.BaudRate = baudRate;
                this.DataBits = dataBits;
                this.Parity = parity;
                this.StopBits = stopBits;
            }
        }

        private SerialPortInfo m_ComeInfo = new SerialPortInfo();

        private Uart()
        {
            m_ComeInfo.Com = Properties.Settings.Default.Com;
            m_ComeInfo.BaudRate = Properties.Settings.Default.BaudRate;
            m_ComeInfo.DataBits = Properties.Settings.Default.DataBits;
            m_ComeInfo.Parity = Properties.Settings.Default.Parity;
            m_ComeInfo.StopBits = Properties.Settings.Default.StopBits;

            m_Com.DataReceived += new SerialDataReceivedEventHandler(ComportRecvEventHandle);
            m_Com.ErrorReceived += new SerialErrorReceivedEventHandler(ComportRecvErrEventHandle);
        }

        public void Setup(SerialPortInfo Info)
        {
            m_ComeInfo = Info;
            Properties.Settings.Default.Com = m_ComeInfo.Com;
            Properties.Settings.Default.BaudRate = m_ComeInfo.BaudRate;
            Properties.Settings.Default.DataBits = m_ComeInfo.DataBits;
            Properties.Settings.Default.Parity = m_ComeInfo.Parity;
            Properties.Settings.Default.StopBits = m_ComeInfo.StopBits;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 取得可用的Com Port名稱列表
        /// </summary>
        /// <returns></returns>
        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool Open()
        {
            if(m_Com.IsOpen)
            {
                m_Com.Close();
            }

            m_Com.PortName = m_ComeInfo.Com;
            m_Com.BaudRate = m_ComeInfo.BaudRate;
            m_Com.DataBits = m_ComeInfo.DataBits;
            m_Com.Parity = m_ComeInfo.Parity;
            m_Com.StopBits = m_ComeInfo.StopBits;

            try
            {
                // Com Port連線
                m_Com.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

            UartConnectChange?.Invoke(true);

            return true;
        }

        public void Close()
        {
            try
            {
                m_Com.Close();
            }
            catch (System.Exception)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            UartConnectChange?.Invoke(false);
        }

        public bool IsConnect()
        {
            return m_Com.IsOpen;
        }

        public string ConnectPort()
        {
            return m_Com.IsOpen == true ? m_Com.PortName : "";
        }

        /// <summary>
        /// Comport收到資料事件觸發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComportRecvEventHandle(object sender, SerialDataReceivedEventArgs e)
        {
            //從comport的Buffer讀取資料;//
            byte[] ReadBuffer = null;
            try
            {
                int Len = m_Com.BytesToRead;
                ReadBuffer = new byte[Len];
                m_Com.Read(ReadBuffer, 0, ReadBuffer.Length);
            }
            catch (System.Exception ex)
            {
                ReadBuffer = null;
                Log.Logger.Error(ex.Message);
                return;
            }

            if (ReadBuffer[0] == '1')
            {
                TestResult?.Invoke(true);
            }
            else if (ReadBuffer[0] == '2')
            {
                TestResult?.Invoke(false);
            }
        }

        /// <summary>
        /// Comport收到錯誤訊息事件會觸發的Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComportRecvErrEventHandle(object sender, SerialErrorReceivedEventArgs e)
        {

        }
    }
}
