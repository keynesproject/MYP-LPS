namespace LPS.View.Pages
{
    partial class PageBackup
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleServer = new System.Windows.Forms.Label();
            this.lblTitleBackup = new System.Windows.Forms.Label();
            this.tlpBackup = new System.Windows.Forms.TableLayoutPanel();
            this.tbPathBackup = new System.Windows.Forms.TextBox();
            this.btnSearchBackup = new System.Windows.Forms.Button();
            this.pnlLine2_2 = new System.Windows.Forms.Label();
            this.pnlLine2_1 = new System.Windows.Forms.Label();
            this.tlpServerSetting = new System.Windows.Forms.TableLayoutPanel();
            this.tbPathServer = new System.Windows.Forms.TextBox();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnServerTest = new System.Windows.Forms.Button();
            this.pnlLine4_2 = new System.Windows.Forms.Label();
            this.pnlLine4_1 = new System.Windows.Forms.Label();
            this.lblTitleDb = new System.Windows.Forms.Label();
            this.lblTitleReport = new System.Windows.Forms.Label();
            this.tbPathDb = new System.Windows.Forms.TextBox();
            this.tbPathReport = new System.Windows.Forms.TextBox();
            this.btnServerDbTest = new System.Windows.Forms.Button();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.tlpBase.SuspendLayout();
            this.tlpSetting.SuspendLayout();
            this.tlpBackup.SuspendLayout();
            this.tlpServerSetting.SuspendLayout();
            this.tlpLogin.SuspendLayout();
            this.tlpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpSetting, 0, 2);
            this.tlpBase.Controls.Add(this.tlpOption, 0, 0);
            this.tlpBase.Controls.Add(this.pnlLine1, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.TabIndex = 1;
            // 
            // tlpSetting
            // 
            this.tlpSetting.AutoSize = true;
            this.tlpSetting.ColumnCount = 2;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.Controls.Add(this.lblTitleServer, 0, 2);
            this.tlpSetting.Controls.Add(this.lblTitleBackup, 0, 0);
            this.tlpSetting.Controls.Add(this.tlpBackup, 1, 0);
            this.tlpSetting.Controls.Add(this.pnlLine2_2, 1, 1);
            this.tlpSetting.Controls.Add(this.pnlLine2_1, 0, 1);
            this.tlpSetting.Controls.Add(this.tlpServerSetting, 1, 2);
            this.tlpSetting.Controls.Add(this.pnlLine4_2, 1, 6);
            this.tlpSetting.Controls.Add(this.pnlLine4_1, 0, 6);
            this.tlpSetting.Controls.Add(this.lblTitleDb, 0, 3);
            this.tlpSetting.Controls.Add(this.lblTitleReport, 0, 5);
            this.tlpSetting.Controls.Add(this.tbPathDb, 1, 3);
            this.tlpSetting.Controls.Add(this.tbPathReport, 1, 5);
            this.tlpSetting.Controls.Add(this.btnServerDbTest, 1, 4);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tlpSetting.Location = new System.Drawing.Point(3, 68);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 8;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.Size = new System.Drawing.Size(759, 319);
            this.tlpSetting.TabIndex = 8;
            // 
            // lblTitleServer
            // 
            this.lblTitleServer.AutoSize = true;
            this.lblTitleServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleServer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleServer.Location = new System.Drawing.Point(3, 44);
            this.lblTitleServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleServer.Name = "lblTitleServer";
            this.lblTitleServer.Size = new System.Drawing.Size(148, 136);
            this.lblTitleServer.TabIndex = 1;
            this.lblTitleServer.Text = "伺服器備份路徑:";
            // 
            // lblTitleBackup
            // 
            this.lblTitleBackup.AutoSize = true;
            this.lblTitleBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleBackup.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleBackup.Location = new System.Drawing.Point(3, 4);
            this.lblTitleBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleBackup.Name = "lblTitleBackup";
            this.lblTitleBackup.Size = new System.Drawing.Size(148, 28);
            this.lblTitleBackup.TabIndex = 16;
            this.lblTitleBackup.Text = "本機備份路徑:";
            this.lblTitleBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpBackup
            // 
            this.tlpBackup.AutoSize = true;
            this.tlpBackup.ColumnCount = 2;
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBackup.Controls.Add(this.tbPathBackup, 0, 0);
            this.tlpBackup.Controls.Add(this.btnSearchBackup, 1, 0);
            this.tlpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackup.Location = new System.Drawing.Point(154, 0);
            this.tlpBackup.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBackup.Name = "tlpBackup";
            this.tlpBackup.RowCount = 1;
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBackup.Size = new System.Drawing.Size(605, 36);
            this.tlpBackup.TabIndex = 30;
            // 
            // tbPathBackup
            // 
            this.tbPathBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathBackup.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPathBackup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPathBackup.Location = new System.Drawing.Point(3, 6);
            this.tbPathBackup.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPathBackup.MaxLength = 1024;
            this.tbPathBackup.Name = "tbPathBackup";
            this.tbPathBackup.Size = new System.Drawing.Size(560, 24);
            this.tbPathBackup.TabIndex = 0;
            // 
            // btnSearchBackup
            // 
            this.btnSearchBackup.AutoSize = true;
            this.btnSearchBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchBackup.Location = new System.Drawing.Point(569, 4);
            this.btnSearchBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBackup.Name = "btnSearchBackup";
            this.btnSearchBackup.Size = new System.Drawing.Size(33, 28);
            this.btnSearchBackup.TabIndex = 1;
            this.btnSearchBackup.Text = "...";
            this.btnSearchBackup.UseVisualStyleBackColor = true;
            this.btnSearchBackup.Click += new System.EventHandler(this.BtnSearchBackup_Click);
            // 
            // pnlLine2_2
            // 
            this.pnlLine2_2.AutoSize = true;
            this.pnlLine2_2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2_2.Location = new System.Drawing.Point(154, 36);
            this.pnlLine2_2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine2_2.Name = "pnlLine2_2";
            this.pnlLine2_2.Size = new System.Drawing.Size(605, 4);
            this.pnlLine2_2.TabIndex = 33;
            this.pnlLine2_2.Text = "           ";
            // 
            // pnlLine2_1
            // 
            this.pnlLine2_1.AutoSize = true;
            this.pnlLine2_1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2_1.Location = new System.Drawing.Point(0, 36);
            this.pnlLine2_1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine2_1.Name = "pnlLine2_1";
            this.pnlLine2_1.Size = new System.Drawing.Size(154, 4);
            this.pnlLine2_1.TabIndex = 34;
            this.pnlLine2_1.Text = "           ";
            // 
            // tlpServerSetting
            // 
            this.tlpServerSetting.AutoSize = true;
            this.tlpServerSetting.ColumnCount = 1;
            this.tlpServerSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerSetting.Controls.Add(this.tbPathServer, 0, 0);
            this.tlpServerSetting.Controls.Add(this.tlpLogin, 0, 1);
            this.tlpServerSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerSetting.Location = new System.Drawing.Point(154, 40);
            this.tlpServerSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tlpServerSetting.Name = "tlpServerSetting";
            this.tlpServerSetting.RowCount = 2;
            this.tlpServerSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServerSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServerSetting.Size = new System.Drawing.Size(605, 144);
            this.tlpServerSetting.TabIndex = 37;
            // 
            // tbPathServer
            // 
            this.tbPathServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathServer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPathServer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPathServer.Location = new System.Drawing.Point(3, 6);
            this.tbPathServer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPathServer.MaxLength = 1024;
            this.tbPathServer.Name = "tbPathServer";
            this.tbPathServer.Size = new System.Drawing.Size(599, 24);
            this.tbPathServer.TabIndex = 0;
            this.tbPathServer.Text = "\\\\192.168.0.190\\TestScan";
            // 
            // tlpLogin
            // 
            this.tlpLogin.AutoSize = true;
            this.tlpLogin.ColumnCount = 2;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogin.Controls.Add(this.tbPW, 1, 1);
            this.tlpLogin.Controls.Add(this.lblPW, 0, 1);
            this.tlpLogin.Controls.Add(this.tbAccount, 1, 0);
            this.tlpLogin.Controls.Add(this.lblAccount, 0, 0);
            this.tlpLogin.Controls.Add(this.btnServerTest, 1, 2);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(3, 37);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 3;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogin.Size = new System.Drawing.Size(599, 104);
            this.tlpLogin.TabIndex = 33;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPW.Location = new System.Drawing.Point(71, 40);
            this.tbPW.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPW.MaxLength = 512;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(525, 24);
            this.tbPW.TabIndex = 1;
            this.tbPW.UseSystemPasswordChar = true;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPW.Location = new System.Drawing.Point(3, 34);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(62, 34);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "密    碼:";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAccount
            // 
            this.tbAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAccount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbAccount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAccount.Location = new System.Drawing.Point(71, 6);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbAccount.MaxLength = 512;
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(525, 24);
            this.tbAccount.TabIndex = 0;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccount.Location = new System.Drawing.Point(3, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(62, 34);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "帳    號:";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnServerTest
            // 
            this.btnServerTest.AutoSize = true;
            this.btnServerTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServerTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnServerTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnServerTest.Location = new System.Drawing.Point(473, 72);
            this.btnServerTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnServerTest.Name = "btnServerTest";
            this.btnServerTest.Size = new System.Drawing.Size(123, 28);
            this.btnServerTest.TabIndex = 3;
            this.btnServerTest.Text = "伺服器連接測試";
            this.btnServerTest.UseVisualStyleBackColor = true;
            this.btnServerTest.Click += new System.EventHandler(this.BtnServerTest_Click);
            // 
            // pnlLine4_2
            // 
            this.pnlLine4_2.AutoSize = true;
            this.pnlLine4_2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine4_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine4_2.Location = new System.Drawing.Point(154, 288);
            this.pnlLine4_2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine4_2.Name = "pnlLine4_2";
            this.pnlLine4_2.Size = new System.Drawing.Size(605, 4);
            this.pnlLine4_2.TabIndex = 38;
            this.pnlLine4_2.Text = "           ";
            // 
            // pnlLine4_1
            // 
            this.pnlLine4_1.AutoSize = true;
            this.pnlLine4_1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine4_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine4_1.Location = new System.Drawing.Point(0, 288);
            this.pnlLine4_1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine4_1.Name = "pnlLine4_1";
            this.pnlLine4_1.Size = new System.Drawing.Size(154, 4);
            this.pnlLine4_1.TabIndex = 39;
            this.pnlLine4_1.Text = "           ";
            // 
            // lblTitleDb
            // 
            this.lblTitleDb.AutoSize = true;
            this.lblTitleDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleDb.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleDb.Location = new System.Drawing.Point(3, 188);
            this.lblTitleDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleDb.Name = "lblTitleDb";
            this.lblTitleDb.Size = new System.Drawing.Size(148, 26);
            this.lblTitleDb.TabIndex = 40;
            this.lblTitleDb.Text = "伺服器資料庫路徑:";
            this.lblTitleDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleReport
            // 
            this.lblTitleReport.AutoSize = true;
            this.lblTitleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleReport.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleReport.Location = new System.Drawing.Point(3, 258);
            this.lblTitleReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleReport.Name = "lblTitleReport";
            this.lblTitleReport.Size = new System.Drawing.Size(148, 26);
            this.lblTitleReport.TabIndex = 0;
            this.lblTitleReport.Text = "每日報表匯出路徑:";
            this.lblTitleReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPathDb
            // 
            this.tbPathDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathDb.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPathDb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPathDb.Location = new System.Drawing.Point(157, 190);
            this.tbPathDb.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPathDb.MaxLength = 1024;
            this.tbPathDb.Name = "tbPathDb";
            this.tbPathDb.Size = new System.Drawing.Size(599, 24);
            this.tbPathDb.TabIndex = 0;
            this.tbPathDb.Text = "\\\\192.168.0.190\\TestScan\\DB\\Db.mdb";
            // 
            // tbPathReport
            // 
            this.tbPathReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPathReport.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPathReport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPathReport.Location = new System.Drawing.Point(157, 260);
            this.tbPathReport.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPathReport.MaxLength = 1024;
            this.tbPathReport.Name = "tbPathReport";
            this.tbPathReport.Size = new System.Drawing.Size(599, 24);
            this.tbPathReport.TabIndex = 0;
            this.tbPathReport.Text = "\\\\192.168.0.190\\TestScan\\BackupDataNew";
            // 
            // btnServerDbTest
            // 
            this.btnServerDbTest.AutoSize = true;
            this.btnServerDbTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServerDbTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnServerDbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnServerDbTest.Location = new System.Drawing.Point(633, 222);
            this.btnServerDbTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnServerDbTest.Name = "btnServerDbTest";
            this.btnServerDbTest.Size = new System.Drawing.Size(123, 28);
            this.btnServerDbTest.TabIndex = 41;
            this.btnServerDbTest.Text = "資料庫連接測試";
            this.btnServerDbTest.UseVisualStyleBackColor = true;
            this.btnServerDbTest.Click += new System.EventHandler(this.BtnServerDbTest_Click);
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 7;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.Controls.Add(this.btnSave, 1, 0);
            this.tlpOption.Controls.Add(this.btnUpdate, 3, 0);
            this.tlpOption.Controls.Add(this.btnBackup, 5, 0);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 3);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 1;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.Size = new System.Drawing.Size(759, 50);
            this.tlpOption.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSave.Location = new System.Drawing.Point(13, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(111, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 44);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新資料";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.AutoSize = true;
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackup.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBackup.Location = new System.Drawing.Point(209, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(82, 44);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "上傳資料";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // pnlLine1
            // 
            this.pnlLine1.AutoSize = true;
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine1.Location = new System.Drawing.Point(3, 60);
            this.pnlLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(759, 1);
            this.pnlLine1.TabIndex = 7;
            // 
            // PageBackup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpBase);
            this.Name = "PageBackup";
            this.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpBackup.ResumeLayout(false);
            this.tlpBackup.PerformLayout();
            this.tlpServerSetting.ResumeLayout(false);
            this.tlpServerSetting.PerformLayout();
            this.tlpLogin.ResumeLayout(false);
            this.tlpLogin.PerformLayout();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.TableLayoutPanel tlpBackup;
        private System.Windows.Forms.TextBox tbPathBackup;
        private System.Windows.Forms.Button btnSearchBackup;
        private System.Windows.Forms.Label lblTitleReport;
        private System.Windows.Forms.Label lblTitleServer;
        private System.Windows.Forms.Label lblTitleBackup;
        private System.Windows.Forms.TextBox tbPathReport;
        private System.Windows.Forms.TextBox tbPathServer;
        private System.Windows.Forms.Label pnlLine2_2;
        private System.Windows.Forms.Label pnlLine2_1;
        private System.Windows.Forms.TableLayoutPanel tlpServerSetting;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label pnlLine4_2;
        private System.Windows.Forms.Label pnlLine4_1;
        private System.Windows.Forms.Label lblTitleDb;
        private System.Windows.Forms.TextBox tbPathDb;
        private System.Windows.Forms.Button btnServerTest;
        private System.Windows.Forms.Button btnServerDbTest;
    }
}
