using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using LPS.Model.DataAccessObject;
using LPS.View.Forms;

namespace LPS.View.Pages
{
    public partial class PageHelp : UserControl
    {
        public PageHelp()
        {
            InitializeComponent();

            DaoSnControl.Instance.UpdateSnEvent += this.SnUpdate;
        }
        
        private void PageHelp_Load(object sender, EventArgs e)
        {

            string SN = DaoSnControl.Instance.GetSN();
            int ExpDay = DaoSnControl.Instance.GetTrialExp();
            SnUpdate(SN, ExpDay);
        }

        private void LlSupportHar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.harmony-ins.com.tw/");
            }
            catch
            {
                //表示沒有預設的開啟網址應程式，不予動作;//
            }
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.unical.com.tw/");
            }
            catch
            {
                //表示沒有預設的開啟網址應程式，不予動作;//
            }
        }

        private void LlSupportMyp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.myp.net.tw/");
            }
            catch
            {
                //表示沒有預設的開啟網址應程式，不予動作;//
            }
        }

        private void LnkLblMypEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:" + lnkLblMypEmail.Text);
            }
            catch (Exception)
            {

            }
        }

        private void SnUpdate(string SN, int ExpDay)
        {
            Invoke((MethodInvoker)delegate
            {
                tbSN.Text = SN;

                if (ExpDay < 0)
                {
                    //表示找無序號;//
                    tlpVersion.Visible = false;
                    tbSN.Visible = false;
                }
                else
                {
                    lblVersion.Text = ExpDay > 999 ? "正式版" : string.Format("試用版剩餘 {0} 天", ExpDay);
                    btnActivate.Visible = ExpDay > 999 ? false : true;
                    tbSN.BackColor = ExpDay > 999 ? Color.White : Color.LightPink;
                }
            });
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            FormActivate Activate = new FormActivate();
            Activate.ShowDialog();
        }
    }
}
