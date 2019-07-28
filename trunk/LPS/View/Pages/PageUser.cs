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
    public partial class PageUser : UserControl
    {
        public PageUser()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            dgvUser.DataSource = DaoSQL.Instance.GetUser();
        }

        /// <summary>
        /// 檢查是否有資料及選擇項目
        /// </summary>
        /// <returns></returns>
        public bool CheckDataAndSelect()
        {
            //判斷有無資料;//
            if (dgvUser.RowCount <= 0)
            {
                MessageBoxEx.Show(this, "沒有任何操作者資訊可供修改/刪除!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //先判斷有無選取資料列;//
            if (dgvUser.CurrentRow.Index < 0)
            {
                MessageBoxEx.Show(this, "請選擇要修改的操作者!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            FormSettingUser fUser = new FormSettingUser();
            DialogResult Ret = fUser.ShowDialog();

            if (Ret == DialogResult.Yes)
                Setup();

            fUser.Close();
            fUser.Dispose();
        }

        private void BtnEdit_MouseUp(object sender, MouseEventArgs e)
        {
            if (CheckDataAndSelect() == false)
                return;

            if (dgvUser.CurrentRow.Selected == true)
            {
                DaoUser User = (DaoUser)dgvUser.Rows[dgvUser.CurrentCell.RowIndex].DataBoundItem;

                FormSettingUser fUser = new FormSettingUser(User);

                DialogResult Ret = fUser.ShowDialog();

                if (Ret == DialogResult.Yes)
                    Setup();

                fUser.Close();
                fUser.Dispose();
            }
        }

        private void BtnDel_MouseUp(object sender, MouseEventArgs e)
        {
            //檢查是否只剩一組帳號;//
            if(dgvUser.Rows.Count <= 1)
            {
                MessageBoxEx.Show(this, "最少須保留1組操作者資訊!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckDataAndSelect() == false)
                return;

            if (dgvUser.CurrentRow.Selected == true)
            {
                DaoUser User = (DaoUser)dgvUser.Rows[dgvUser.CurrentCell.RowIndex].DataBoundItem;

                DialogResult Ret = MessageBoxEx.Show(this, string.Format("確定要刪除作業員 {0} ?", User.Serial), "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Ret == DialogResult.Yes)
                {
                    DaoErrMsg Msg = DaoSQL.Instance.DeleteUser(User);
                    if (Msg.isError == false)
                    {
                        MessageBoxEx.Show(this, string.Format("作業員 {0} 已刪除.", User.Serial), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Setup();
                    }
                    else
                    {
                        MessageBoxEx.Show(this, string.Format("無法刪除作業員 {0},{1}.", User.Serial, Msg.ErrorMsg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
