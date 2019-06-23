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
    public partial class FormSettingUser : Form
    {
        private bool m_isEditMode = false;

        public FormSettingUser()
        {
            InitializeComponent();

            cbAdmin.SelectedIndex = 0;
        }

        public FormSettingUser(DaoUser User)
        {
            InitializeComponent();

            tbSerial.ReadOnly = true;

            tbSerial.Text = User.代碼;

            tbName.Text = User.作業員姓名;

            tbPW.Text = User.密碼;

            tbConfirmPW.Text = User.密碼;

            cbAdmin.SelectedIndex = User.權限.Equals("N") ? 0 : 1;

            btnAdd.Text = "更  新";

            m_isEditMode = true;
        }

        /// <summary>
        /// 檢查Control元件是否有輸入數值
        /// </summary>
        /// <param name="Tb"></param>
        /// <param name="Lbl"></param>
        /// <returns></returns>
        private bool CheckControl(Control Com, Label Lbl)
        {
            if (string.IsNullOrEmpty(Com.Text))
            {
                MessageBoxEx.Show(this, string.Format("請輸入 [{0}] 欄位資訊.", Lbl.Text), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Com.Focus();
                return false;
            }

            return true;
        }

        private bool CheckField()
        {
            //檢查必要欄位;//
            if (this.CheckControl(tbSerial, lblSerial) == false
                || this.CheckControl(tbName, lblName) == false
                || this.CheckControl(tbPW, lblPW) == false
                || this.CheckControl(tbConfirmPW, lblConfirmPW) == false)
            {
                return false;
            }

            if (tbPW.Text.Equals(tbConfirmPW.Text) == false)
            {
                MessageBoxEx.Show(this, "驗證密碼錯誤!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckField() == false)
                return;

            if (m_isEditMode == false)
            {
                //先檢查此機台代碼是否存在;//
                bool isExist = DaoSQL.Instance.IsExistUser(tbSerial.Text);

                //存在則詢問是否要更新;//
                if (isExist == true)
                {
                    DialogResult Ret = MessageBoxEx.Show(this, string.Format("作業員代碼 {0} 已存在，是否要更新?", tbSerial.Text), "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Ret == DialogResult.No)
                        return;

                    //更新機台資訊;//
                    DaoSQL.Instance.UpdateUser(tbSerial.Text, tbName.Text, tbPW.Text, cbAdmin.Text.Equals("是") ? "Y" : "N");

                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    //新增一筆機台資訊;//
                    DaoSQL.Instance.AddUser(tbSerial.Text, tbName.Text, tbPW.Text, cbAdmin.Text.Equals("是") ? "Y" : "N");

                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                //更新機台資訊;//
                DaoSQL.Instance.UpdateUser(tbSerial.Text, tbName.Text, tbPW.Text, cbAdmin.Text.Equals("是") ? "Y" : "N");

                this.DialogResult = DialogResult.Yes;
            }
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
