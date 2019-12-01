using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using LPS.View.Component;

namespace LPS.View.Pages
{
    public partial class PagePrinterSetting : UserControl
    {
        public PagePrinterSetting()
        {
            InitializeComponent();
        }

        internal void Setup()
        {
            //獲取儲存的印表機名
            string strDefaultPrinter = Properties.Settings.Default.PrinterName;

            //獲取本地連線印表機列表載入到下拉框中
            bool isSetDefaultPrinter = false;
            PrinterSettings.StringCollection list = PrinterSettings.InstalledPrinters;
            foreach (string pkInstalledPrinters in list)
            {
                cbPrinter.Items.Add(pkInstalledPrinters);

                //把本地預設印表機設為預設值
                if (pkInstalledPrinters == strDefaultPrinter)                
                {
                    cbPrinter.SelectedIndex = cbPrinter.Items.IndexOf(pkInstalledPrinters);
                    isSetDefaultPrinter = true;
                }
            }

            if (isSetDefaultPrinter == false)
                cbPrinter.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPrinter.Text))
            {
                MessageBoxEx.Show(this, "請選擇標籤印表機!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Properties.Settings.Default.PrinterName = cbPrinter.Text;
            Properties.Settings.Default.Save();

            MessageBoxEx.Show(this, "標籤印表機儲存成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
