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
    public partial class FormSettingCars : Form
    {
        private bool m_isEditMode = false;

        public FormSettingCars()
        {
            InitializeComponent();
        }

        public FormSettingCars(DaoPartNumber PN)
        {
            InitializeComponent();

            tbPN.ReadOnly = true;
            tbPN.Text = PN.件號;

            tbCar.Text = PN.車型;

            tbCode.Text = PN.簡碼;            

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
            return CheckControl(tbPN, lblPN);
        }

        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckField() == false)
                return;

            if (m_isEditMode == false)
            {
                //先檢查此機台代碼是否存在;//
                bool isExist = DaoSQL.Instance.IsExistPN(tbPN.Text);

                //存在則詢問是否要更新;//
                if (isExist == true)
                {
                    DialogResult Ret = MessageBoxEx.Show(this, string.Format("件號 {0} 已存在，是否要更新?", tbPN.Text), "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Ret == DialogResult.No)
                        return;

                    //更新機台資訊;//
                    DaoSQL.Instance.UpdatePN(tbPN.Text, tbCar.Text, tbCode.Text);

                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    //新增一筆機台資訊;//
                    DaoSQL.Instance.AddPN(tbPN.Text, tbCar.Text, tbCode.Text);

                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                //更新機台資訊;//
                DaoSQL.Instance.UpdatePN(tbPN.Text, tbCar.Text, tbCode.Text);

                this.DialogResult = DialogResult.Yes;
            }
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
