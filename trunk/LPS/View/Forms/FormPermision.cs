using LPS.Model.DataAccessObject;
using LPS.View.Component;
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
    public partial class FormPermision : Form
    {
        public FormPermision()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得登入者代碼
        /// </summary>
        /// <returns></returns>
        public string GetLoginUserCode()
        {
            return tbUser.Text;
        }

        private void BtnLogin_MouseUp(object sender, MouseEventArgs e)
        {            
            //驗證登入流程;//
            if (Login() == true)
            {
                //要關閉視窗;//
                DialogResult = DialogResult.OK;
            }
        }

        private bool Login()
        {
            //檢查有無輸入操作者代碼;//
            if (string.IsNullOrEmpty(tbUser.Text))
            {
                MessageBoxEx.Show(this, "請輸入帳號!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUser.Focus();
                return false;
            }

            //檢查有無輸入密碼;//
            if (string.IsNullOrEmpty(tbPW.Text))
            {
                MessageBoxEx.Show(this, "請輸入密碼!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPW.Focus();
                return false;
            }

            //這組帳號不須判斷，直接驗證成功;//
            if(tbUser.Text == "myp" && tbPW.Text == "53750804")
            {
                return true;
            }
            
            //帳號驗證;//
            bool isVerify = DaoSQL.Instance.Login(tbUser.Text, tbPW.Text);
            if (isVerify == false)
            {
                MessageBoxEx.Show(this, "帳號及密碼錯誤，或此帳號不具此權限!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TbPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                //驗證登入流程;//
                if (Login() == true)
                {
                    //表示登入成功，要關閉視窗;//
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
