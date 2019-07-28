using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.View.Forms;
using LPS.View.Component;

namespace LPS.View.Pages
{
    public partial class PageMachine : UserControl
    {
        public PageMachine()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            dgvMachine.DataSource = DaoSQL.Instance.GetMachineNo();
        }

        private void DgvMachine_BindingContextChanged(object sender, EventArgs e)
        {
            if(dgvMachine.Columns.Contains("Serial"))
            {
                dgvMachine.Columns["Serial"].Visible = false;
            }

            if (dgvMachine.Columns.Contains("預設機台"))
            {
                dgvMachine.Columns["預設機台"].Visible = false;
            }
        }

        /// <summary>
        /// 檢查是否有資料及選擇項目
        /// </summary>
        /// <returns></returns>
        public bool CheckDataAndSelect()
        {
            //判斷有無資料;//
            if (dgvMachine.RowCount <= 0)
            {
                MessageBoxEx.Show(this, "沒有任何機台資訊可供修改/刪除!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //先判斷有無選取資料列;//
            if (dgvMachine.CurrentRow.Index < 0)
            {
                MessageBoxEx.Show(this, "請選擇要修改的機台!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            FormSettingMachine fMachine = new FormSettingMachine();
            DialogResult Ret = fMachine.ShowDialog();

            if (Ret == DialogResult.Yes)
                Setup();

            fMachine.Close();
            fMachine.Dispose();
        }

        private void BtnEdit_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckDataAndSelect() == false)
                return;

            if(dgvMachine.CurrentRow.Selected == true)
            {
                DaoMachine Machine = (DaoMachine)dgvMachine.Rows[dgvMachine.CurrentCell.RowIndex].DataBoundItem;

                FormSettingMachine fMachine = new FormSettingMachine(Machine);

                DialogResult Ret = fMachine.ShowDialog();

                if (Ret == DialogResult.Yes)
                    Setup();

                fMachine.Close();
                fMachine.Dispose();
            }            
        }

        private void BtnDel_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckDataAndSelect() == false)
                return;

            if (dgvMachine.CurrentRow.Selected == true)
            {
                DaoMachine Machine = (DaoMachine)dgvMachine.Rows[dgvMachine.CurrentCell.RowIndex].DataBoundItem;

                DialogResult Ret = MessageBoxEx.Show(this, string.Format("確定要刪除機台 {0} ?", Machine.機台代碼), "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Ret == DialogResult.Yes)
                {
                    DaoErrMsg Msg = DaoSQL.Instance.DeleteMachine(Machine);
                    if (Msg.isError == false)
                    {
                        MessageBoxEx.Show(this, string.Format("機台 {0} 已刪除.", Machine.機台代碼), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Setup();
                    }
                    else
                    {
                        MessageBoxEx.Show(this, string.Format("無法刪除機台 {0},{1}", Machine.機台代碼, Msg.ErrorMsg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
