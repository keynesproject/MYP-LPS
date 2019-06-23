using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.View.Component;
using LPS.View.Forms;

namespace LPS.View.Pages
{
    public partial class PageCars : UserControl
    {
        public PageCars()
        {
            InitializeComponent();
        }

        internal void Setup()
        {
            dgvCar.DataSource = DaoSQL.Instance.GetPartNumber();
        }

        /// <summary>
        /// 檢查是否有資料及選擇項目
        /// </summary>
        /// <returns></returns>
        public bool CheckDataAndSelect()
        {
            //判斷有無資料;//
            if (dgvCar.RowCount <= 0)
            {
                MessageBoxEx.Show(this, "沒有任何件號資訊可供修改/刪除!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //先判斷有無選取資料列;//
            if (dgvCar.CurrentRow.Index < 0)
            {
                MessageBoxEx.Show(this, "請選擇要修改的件號!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            FormSettingCars fCar = new FormSettingCars();
            DialogResult Ret = fCar.ShowDialog();

            if (Ret == DialogResult.Yes)
                Setup();

            fCar.Close();
            fCar.Dispose();
        }

        private void BtnEdit_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckDataAndSelect() == false)
                return;

            if (dgvCar.CurrentRow.Selected == true)
            {
                DaoPartNumber PN = (DaoPartNumber)dgvCar.Rows[dgvCar.CurrentCell.RowIndex].DataBoundItem;

                FormSettingCars fCar = new FormSettingCars(PN);

                DialogResult Ret = fCar.ShowDialog();

                if (Ret == DialogResult.Yes)
                    Setup();

                fCar.Close();
                fCar.Dispose();
            }
        }

        private void BtnDel_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckDataAndSelect() == false)
                return;

            if (dgvCar.CurrentRow.Selected == true)
            {
                DaoPartNumber CarPN = (DaoPartNumber)dgvCar.Rows[dgvCar.CurrentCell.RowIndex].DataBoundItem;

                DialogResult Ret = MessageBoxEx.Show(this, string.Format("確定要刪除件號 {0} ?", CarPN.件號), "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Ret == DialogResult.Yes)
                {
                    DaoErrMsg Msg = DaoSQL.Instance.DeletePN(CarPN);
                    if (Msg.isError == false)
                    {
                        MessageBoxEx.Show(this, string.Format("件號 {0} 已刪除。", CarPN.件號), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Setup();
                    }
                    else
                    {
                        MessageBoxEx.Show(this, string.Format("無法刪除件號 {0} 。", CarPN.件號), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
