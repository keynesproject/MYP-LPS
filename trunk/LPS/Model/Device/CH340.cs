using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Management;
using System.IO.Ports;
using System.Threading;

namespace LPS.Model.Device
{
    public class CH340
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體
        private static class CH340Holder
        {
            internal static readonly CH340 Instance = new CH340();

            static CH340Holder() { }
        }

        public static CH340 Instance
        {
            get { return CH340Holder.Instance; }
        }

        #endregion //Singleton物件宣告，Thread safe，並在使用時才會建立實體;//
        
        private SerialPort m_Com = new SerialPort();

        /// <summary>
        /// 測試結果事件
        /// </summary>
        public delegate void TestResultDelegate(bool isOK);

        public event TestResultDelegate TestResult;

        public static Mutex m_Mut = new Mutex();

        private CH340()
        {
            m_Com.DataReceived += new SerialDataReceivedEventHandler(ComportRecvEventHandle);
            m_Com.ErrorReceived += new SerialErrorReceivedEventHandler(ComportRecvErrEventHandle);
        }
        /// <summary>
        /// 檢查CH340裝置狀態
        /// </summary>
        /// <returns></returns>
        public bool CheckCH340()
        {
            string CH340DevName = Probe1stCH340Dev();
            foreach (string Port in SerialPort.GetPortNames())
            {
                if (CH340DevName.EndsWith(Port + ")"))
                {
                    //表示有找到CH340裝置且尚未連線，開啟裝置;//
                    m_Mut.WaitOne();
                    bool isSuccess = false;
                    if (this.IsOpen == false)
                    {
                        isSuccess = this.Hook(Port);
                    }
                    else
                        isSuccess = true;
                    m_Mut.ReleaseMutex();
                    return isSuccess;
                }
            }

            //流程到這表示沒找到CH340裝置，判斷若之前有開啟CH340裝置，則關閉它;//
            if (this.IsOpen == true)
            {
                UnHook();
            }

            return true;
        }

        /// <summary>
        /// 開啟CH340 Com port
        /// </summary>
        /// <param name="ComPort"></param>
        /// <returns></returns>
        private bool Hook(string ComPort)
        {          
            try
            {
                m_Com.PortName = ComPort;
                m_Com.BaudRate = 9600;
                m_Com.DataBits = 8;
                m_Com.Parity = Parity.None;
                m_Com.StopBits = StopBits.One;

                // Com Port連線
                m_Com.Open();
            }
            catch(Exception ex)
            {
                Log.Logger.Error(ex.Message);
                
                return false;
            }

            return true;
        }

        /// <summary>
        /// 關閉 Com Port
        /// </summary>
        private void UnHook()
        {
            try
            {
                m_Com.Close();
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex.Message);
            }

            m_Com = null;
        }

        /// <summary>
        /// 取得CH340裝置完整名稱
        /// </summary>
        /// <returns></returns>
        private string Probe1stCH340Dev()
        {
            //var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
            //ManagementObjectCollection deviceCollection = searcher.Get();
            //foreach (var entity in deviceCollection)
            //{
            //    Console.WriteLine("Manufacturer:" + (string)entity.GetPropertyValue("Manufacturer"));
            //    Console.WriteLine("Service:" + (string)entity.GetPropertyValue("Service"));
            //}

            //using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Manufacturer = 'wch.cn'"))
            //{
            //    try
            //    {
            //        if (searcher.Get().Cast<ManagementBaseObject>().Count() > 0)
            //        {
            //            return searcher.Get().Cast<ManagementBaseObject>().First().GetPropertyValue("Caption").ToString();
            //        }
            //    }
            //    catch
            //    {
            //        return string.Empty;
            //    }
            //}

            //return string.Empty;

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Manufacturer = 'Prolific'"))
            {
                try
                {
                    if (searcher.Get().Cast<ManagementBaseObject>().Count() > 0)
                    {
                        return searcher.Get().Cast<ManagementBaseObject>().First().GetPropertyValue("Caption").ToString();
                    }
                }
                catch
                {
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// 取得是否已開啟CH340
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return m_Com.IsOpen;
            }
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
