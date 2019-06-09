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
    public partial class FormSearchPN : Form
    {
        private string m_SelectPN = "";

        public FormSearchPN()
        {
            InitializeComponent();
        }

        private void FormSearchPN_Shown(object sender, EventArgs e)
        {
            dgvPN.DataSource = DaoSQL.Instance.GetPartNumber();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(dgvPN.SelectedRows.Count <= 0 )
            {
                MessageBoxEx.Show(this, "請選擇件號!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_SelectPN = dgvPN.SelectedRows[0].Cells["columnPN"].Value.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void TbPN_TextChanged(object sender, EventArgs e)
        {
            dgvPN.DataSource = DaoSQL.Instance.SerachPartNumber(tbPN.Text);
        }

        public string GetPN()
        {
            return m_SelectPN;
        }


    }
}
