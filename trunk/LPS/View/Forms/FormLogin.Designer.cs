namespace LPS.View.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogoUniCalsonic = new System.Windows.Forms.PictureBox();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.cbMachineNo = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.tlpSupport = new System.Windows.Forms.TableLayoutPanel();
            this.lblSupport = new System.Windows.Forms.Label();
            this.pbLogoMYP = new System.Windows.Forms.PictureBox();
            this.pbLogoHarmony = new System.Windows.Forms.PictureBox();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUniCalsonic)).BeginInit();
            this.tlpLogin.SuspendLayout();
            this.tlpSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMYP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHarmony)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.pbLogoUniCalsonic, 0, 0);
            this.tlpBase.Controls.Add(this.tlpLogin, 0, 2);
            this.tlpBase.Controls.Add(this.lblSplit1, 0, 1);
            this.tlpBase.Controls.Add(this.lblSplit2, 0, 3);
            this.tlpBase.Controls.Add(this.tlpSupport, 0, 4);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 5;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBase.Size = new System.Drawing.Size(398, 353);
            this.tlpBase.TabIndex = 0;
            // 
            // pbLogoUniCalsonic
            // 
            this.pbLogoUniCalsonic.BackgroundImage = global::LPS.Properties.Resources.LogoUniCalsonic;
            this.pbLogoUniCalsonic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoUniCalsonic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoUniCalsonic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoUniCalsonic.Location = new System.Drawing.Point(3, 3);
            this.pbLogoUniCalsonic.Name = "pbLogoUniCalsonic";
            this.pbLogoUniCalsonic.Size = new System.Drawing.Size(392, 126);
            this.pbLogoUniCalsonic.TabIndex = 0;
            this.pbLogoUniCalsonic.TabStop = false;
            this.pbLogoUniCalsonic.Click += new System.EventHandler(this.PbLogoUniCalsonic_Click);
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 4;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.Controls.Add(this.lblMachineNo, 1, 0);
            this.tlpLogin.Controls.Add(this.lblUser, 1, 1);
            this.tlpLogin.Controls.Add(this.lblPW, 1, 2);
            this.tlpLogin.Controls.Add(this.cbMachineNo, 2, 0);
            this.tlpLogin.Controls.Add(this.cbUser, 2, 1);
            this.tlpLogin.Controls.Add(this.tbPW, 2, 2);
            this.tlpLogin.Controls.Add(this.btnLogin, 2, 3);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(3, 138);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 4;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLogin.Size = new System.Drawing.Size(392, 173);
            this.tlpLogin.TabIndex = 0;
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachineNo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblMachineNo.Location = new System.Drawing.Point(44, 0);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(93, 43);
            this.lblMachineNo.TabIndex = 0;
            this.lblMachineNo.Text = "機台號碼";
            this.lblMachineNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(44, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(93, 43);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "操作者代號";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPW.Location = new System.Drawing.Point(44, 86);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(93, 43);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "密碼";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMachineNo
            // 
            this.cbMachineNo.DisplayMember = "Serial";
            this.cbMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMachineNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachineNo.Font = new System.Drawing.Font("Arial", 11F);
            this.cbMachineNo.FormattingEnabled = true;
            this.cbMachineNo.Location = new System.Drawing.Point(143, 10);
            this.cbMachineNo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbMachineNo.Name = "cbMachineNo";
            this.cbMachineNo.Size = new System.Drawing.Size(203, 25);
            this.cbMachineNo.TabIndex = 0;
            // 
            // cbUser
            // 
            this.cbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUser.DisplayMember = "Serial";
            this.cbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.Font = new System.Drawing.Font("Arial", 11F);
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(143, 53);
            this.cbUser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(203, 25);
            this.cbUser.TabIndex = 1;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPW.Location = new System.Drawing.Point(143, 96);
            this.tbPW.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.tbPW.MaxLength = 128;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(203, 24);
            this.tbPW.TabIndex = 2;
            this.tbPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPW_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(271, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 38);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_MouseUp);
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit1.Location = new System.Drawing.Point(3, 132);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(392, 3);
            this.lblSplit1.TabIndex = 2;
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit2.Location = new System.Drawing.Point(3, 314);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(392, 3);
            this.lblSplit2.TabIndex = 3;
            // 
            // tlpSupport
            // 
            this.tlpSupport.ColumnCount = 4;
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupport.Controls.Add(this.lblSupport, 0, 0);
            this.tlpSupport.Controls.Add(this.pbLogoMYP, 3, 0);
            this.tlpSupport.Controls.Add(this.pbLogoHarmony, 1, 0);
            this.tlpSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupport.Location = new System.Drawing.Point(0, 320);
            this.tlpSupport.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpSupport.Name = "tlpSupport";
            this.tlpSupport.RowCount = 1;
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupport.Size = new System.Drawing.Size(398, 30);
            this.tlpSupport.TabIndex = 4;
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupport.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSupport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupport.Location = new System.Drawing.Point(3, 0);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(258, 30);
            this.lblSupport.TabIndex = 2;
            this.lblSupport.Text = "協力廠商 :";
            this.lblSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbLogoMYP
            // 
            this.pbLogoMYP.BackgroundImage = global::LPS.Properties.Resources.LogoMYP;
            this.pbLogoMYP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoMYP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoMYP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoMYP.Location = new System.Drawing.Point(315, 0);
            this.pbLogoMYP.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogoMYP.Name = "pbLogoMYP";
            this.pbLogoMYP.Size = new System.Drawing.Size(83, 30);
            this.pbLogoMYP.TabIndex = 0;
            this.pbLogoMYP.TabStop = false;
            this.pbLogoMYP.Click += new System.EventHandler(this.PbLogoMYP_Click);
            // 
            // pbLogoHarmony
            // 
            this.pbLogoHarmony.BackgroundImage = global::LPS.Properties.Resources.LogoHarmony;
            this.pbLogoHarmony.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoHarmony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoHarmony.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogoHarmony.Location = new System.Drawing.Point(264, 0);
            this.pbLogoHarmony.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogoHarmony.Name = "pbLogoHarmony";
            this.pbLogoHarmony.Size = new System.Drawing.Size(41, 30);
            this.pbLogoHarmony.TabIndex = 1;
            this.pbLogoHarmony.TabStop = false;
            this.pbLogoHarmony.Click += new System.EventHandler(this.PbLogoHarmony_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 353);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "作業平台-系統登入";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUniCalsonic)).EndInit();
            this.tlpLogin.ResumeLayout(false);
            this.tlpLogin.PerformLayout();
            this.tlpSupport.ResumeLayout(false);
            this.tlpSupport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMYP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHarmony)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.PictureBox pbLogoUniCalsonic;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Label lblMachineNo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.ComboBox cbMachineNo;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tlpSupport;
        private System.Windows.Forms.PictureBox pbLogoMYP;
        private System.Windows.Forms.PictureBox pbLogoHarmony;
        private System.Windows.Forms.Label lblSupport;
    }
}