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
using LPS.Model.Network;
using System.IO;

namespace LPS.View.Pages
{
    public partial class PageBackup : UserControl
    {
        public PageBackup()
        {
            InitializeComponent();
        }

        internal void Setup()
        {
            DataTable dt = DaoSQL.Instance.GetBackupInfo();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                switch (dt.Rows[i]["Type"].ToString())
                {
                    case "Local":
                        tbPathBackup.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Server":
                        tbPathServer.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerAccount":
                        tbAccount.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "ServerPW":
                        tbPW.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Report":
                        tbPathReport.Text = dt.Rows[i]["ADDR"].ToString();
                        break;

                    case "Database":
                        tbPathDb.Text = dt.Rows[i]["ADDR"].ToString();
                        break;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("ADDR", typeof(string));

            dt.Rows.Add("Local", tbPathBackup.Text);
            dt.Rows.Add("Server", tbPathServer.Text);
            dt.Rows.Add("ServerAccount", tbAccount.Text);
            dt.Rows.Add("ServerPW", tbPW.Text);
            dt.Rows.Add("Report", tbPathReport.Text);
            dt.Rows.Add("Database", tbPathDb.Text);

            DaoSQL.Instance.UpdateBackupInfo(dt);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 本地端路徑設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();

            if (this.tbPathBackup.Text.Length > 0)
                Path.SelectedPath = this.tbPathBackup.Text;
            else
                Path.SelectedPath = Directory.GetCurrentDirectory();

            if (Path.ShowDialog() == DialogResult.OK)
            {
                tbPathBackup.Text = Path.SelectedPath;
            }
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

        private void BtnServerTest_Click(object sender, EventArgs e)
        {
            //檢查必要欄位;//
            if (this.CheckControl(tbPathServer, lblTitleServer) == false
                || this.CheckControl(tbAccount, lblAccount) == false
                || this.CheckControl(tbPW, lblPW) == false)
            {
                return;
            }

            this.Cursor = Cursors.AppStarting;

            NetTranslate.KillLink(tbPathServer.Text);

            if (NetTranslate.connectState(tbPathServer.Text, tbAccount.Text, tbPW.Text) == false)
            {
                this.Cursor = Cursors.Default;
                return;
            }

            MessageBox.Show("伺服器連接成功!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            NetTranslate.KillLink(tbPathServer.Text);

            this.Cursor = Cursors.Default;
        }

    }
}
