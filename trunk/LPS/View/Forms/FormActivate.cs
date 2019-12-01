using LPS.Model.DataAccessObject;
using LPS.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPS.View.Forms
{
    public partial class FormActivate : Form
    {        
        private readonly string m_VerifiInfo = "請輸入驗證碼.";

        public FormActivate()
        {
            InitializeComponent();

            tbVerificationCode.Text = m_VerifiInfo;

            tbSerialNo.Text = DaoSnControl.Instance.GetSN();
        }

        private void FormActivate_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}v{1} - 軟體啟用", Properties.Resources.AP_NAME, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
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

        private void LnkLblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:" + lnkLblEmail.Text);
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            //這裡表示不做驗證動作，標示為Cancel後關閉視窗;//
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnActivate_MouseUp(object sender, MouseEventArgs e)
        {
            //驗證序號;//
            if (DaoSnControl.Instance.VerifySN(tbVerificationCode.Text) == false)
            {
                //序號驗證錯誤;//
                MessageBoxEx.Show(this, "序號啟用失敗!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //序號驗證成功;//
                MessageBoxEx.Show(this, "序號啟用成功!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //驗證正確，更新本機序號;//
            DaoSnControl.Instance.UpdateSN(tbVerificationCode.Text);

            //這邊表示驗證成功，標示為OK後關閉視窗;//
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TbVerificationCode_TextChanged(object sender, EventArgs e)
        {
            //若文字串等於提示訊息，就不顯示驗證結果圖示;//
            if (tbVerificationCode.Text == m_VerifiInfo)
            {
                pbSnCheck.Visible = false;
                return;
            }

            pbSnCheck.Visible = tbVerificationCode.Text.Length >= 0 ? true : false;

            if (DaoSnControl.Instance.VerifySN(tbVerificationCode.Text) == false
                || tbVerificationCode.Text == tbSerialNo.Text)
            {
                //序號驗證錯誤，顯示叉叉圖示;//
                pbSnCheck.BackgroundImage = Properties.Resources.Cross;
                btnActivate.Enabled = false;
            }
            else
            {
                //序號驗證正確，顯示勾勾圖示;//
                pbSnCheck.BackgroundImage = Properties.Resources.Check;
                btnActivate.Enabled = true;
            }
        }

        private void TbVerificationCode_Enter(object sender, EventArgs e)
        {
            if (tbVerificationCode.Text == m_VerifiInfo)
            {
                tbVerificationCode.Text = "";
                tbVerificationCode.ForeColor = Color.Black;
            }
        }

        private void TbVerificationCode_Leave(object sender, EventArgs e)
        {
            if (tbVerificationCode.Text.Length <= 0)
            {
                tbVerificationCode.Text = m_VerifiInfo;
                tbVerificationCode.ForeColor = Color.DarkGray;
            }
        }
    }
}
