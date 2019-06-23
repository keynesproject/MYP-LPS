using LPS.Model.DataAccessObject;
using LPS.Model.Extension;
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
    public partial class FormSettingMachine : Form
    {
        private bool m_isEditMode = false;
        
        public FormSettingMachine()
        {
            InitializeComponent();

            Setup();
        }

        public FormSettingMachine(DaoMachine Machine)
        {
            InitializeComponent();

            int MachineIndex = 0;
            if (char.IsDigit(Machine.機台代碼, 0) == true)
            {
                MachineIndex = Machine.機台代碼.ToInt() + 26;
            }
            else
            {
                MachineIndex = Convert.ToChar(Machine.機台代碼.ToUpper()).ToInt() - 65;
            }            

            Setup(MachineIndex, Machine.預設機台.Equals("Y") ? 1 : 0);

            cbMachine.Enabled = false;

            tbDescription.Text = Machine.描述;

            btnAdd.Text = "更  新";

            m_isEditMode = true;
        }

        private void Setup(int SelectMachine = 0, int SelectDefault = 0)
        {
            cbMachine.SelectedIndex = SelectMachine;
            cbDefult.SelectedIndex = SelectDefault;
        }

        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            if(m_isEditMode == false)
            {
                //先檢查此機台代碼是否存在;//
                bool isExist = DaoSQL.Instance.IsExistMachine(cbMachine.Text);

                //存在則詢問是否要更新;//
                if(isExist == true)
                {
                    DialogResult Ret = MessageBoxEx.Show(this, string.Format("機台代碼 {0} 已存在，是否要更新?", cbMachine.Text), "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Ret == DialogResult.No)
                        return;

                    //更新機台資訊;//
                    DaoSQL.Instance.UpdateMachine(cbMachine.Text, cbDefult.Text.Equals("是") ? true : false, tbDescription.Text);

                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    //新增一筆機台資訊;//
                    DaoSQL.Instance.AddMachine(cbMachine.Text, cbDefult.Text.Equals("是") ? true : false, tbDescription.Text);

                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                //更新機台資訊;//
                DaoSQL.Instance.UpdateMachine(cbMachine.Text, cbDefult.Text.Equals("是") ? true : false, tbDescription.Text);

                this.DialogResult = DialogResult.Yes;
            }
        }

        private void BtnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
