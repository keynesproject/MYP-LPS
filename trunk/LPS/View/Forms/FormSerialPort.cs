using LPS.Model.Device;
using LPS.Model.Extension;
using LPS.View.Component;
using LPS.View.Extension;
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
    public partial class FormSerialPort : Form
    {
        public FormSerialPort()
        {
            InitializeComponent();

            UpdateSerialPortList();

            LoadDefaultData();

            btnConnect.Text = Uart.Instance.IsConnect() == false ? "連線" : "斷線";
            tlpOption.Enabled = Uart.Instance.IsConnect() == false ? true : false;
        }

        private void LoadDefaultData()
        {
            //讀取BaudRate;//
            int BaudRate = Properties.Settings.Default.BaudRate;
            cbBaudRate.SetSelectItem(BaudRate);

            //讀取DataBit;//
            int DataBit = Properties.Settings.Default.DataBits;
            cbDataBits.SetSelectItem(DataBit);

            //讀取Parity;//
            System.IO.Ports.Parity parity = Properties.Settings.Default.Parity;
            cbParity.SelectedIndex = (int)parity;

            //讀取StopBit;//
            System.IO.Ports.StopBits stopBit = Properties.Settings.Default.StopBits;
            cbStopBit.SelectedIndex = (int)stopBit;

            string[] comPortList = Uart.Instance.GetPortNames();
            for (int i = 0; i < comPortList.Count(); i++)
            {
                if(comPortList[i].Equals(Properties.Settings.Default.Com))
                {
                    cbSerial.SelectedIndex = i;
                    break;
                }
            }
        }        

        private void UpdateSerialPortList()
        {
            string[] comPortList = Uart.Instance.GetPortNames();
            int CurrentSelect = cbSerial.SelectedIndex;

            this.cbSerial.Items.Clear();
            foreach (string ComName in comPortList)
            {
                this.cbSerial.Items.Add(ComName);
            }

            if (cbSerial.Items.Count != 0)
            {
                try
                {
                    if (CurrentSelect == -1)
                        this.cbSerial.SelectedIndex = 0;
                    else
                        this.cbSerial.SelectedIndex = CurrentSelect;
                }
                catch (System.Exception /*ex*/)
                {
                    this.cbSerial.SelectedIndex = -1;
                }
            }
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CbSerial_Click(object sender, EventArgs e)
        {
            UpdateSerialPortList();
        }

        private void BtnConnect_MouseUp(object sender, MouseEventArgs e)
        {   
            if(Uart.Instance.IsConnect() == true)
            {
                Uart.Instance.Close();
            }
            else
            {
                Uart.SerialPortInfo Info = new Uart.SerialPortInfo(
                    cbSerial.Text,
                    cbBaudRate.Text.ToInt(),
                    cbDataBits.Text.ToInt(),
                    (System.IO.Ports.Parity)cbParity.SelectedIndex,
                    (System.IO.Ports.StopBits)cbStopBit.SelectedIndex);

                Uart.Instance.Setup(Info);

                if( Uart.Instance.Open() == false )
                {
                    MessageBoxEx.Show(this, "無法連接測試設備,請確認設定數值.", "無法連線", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Properties.Settings.Default.Com = cbSerial.Text;
                    Properties.Settings.Default.Save();
                }
            }

            btnConnect.Text = Uart.Instance.IsConnect() == false ? "連線" : "斷線";
            tlpOption.Enabled = Uart.Instance.IsConnect() == false ? true : false;
        }
    }
}
