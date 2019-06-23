namespace LPS.View.Forms
{
    partial class FormPermision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermision));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogoUniCalsonic = new System.Windows.Forms.PictureBox();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUniCalsonic)).BeginInit();
            this.tlpLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.pbLogoUniCalsonic, 0, 0);
            this.tlpBase.Controls.Add(this.tlpLogin, 0, 2);
            this.tlpBase.Controls.Add(this.lblSplit1, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(398, 290);
            this.tlpBase.TabIndex = 1;
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
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 4;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpLogin.Controls.Add(this.lblUser, 1, 0);
            this.tlpLogin.Controls.Add(this.lblPW, 1, 1);
            this.tlpLogin.Controls.Add(this.tbPW, 2, 1);
            this.tlpLogin.Controls.Add(this.tbUser, 2, 0);
            this.tlpLogin.Controls.Add(this.tableLayoutPanel1, 2, 2);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(3, 138);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 3;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLogin.Size = new System.Drawing.Size(392, 149);
            this.tlpLogin.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(49, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 49);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "帳    號";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPW.Location = new System.Drawing.Point(49, 49);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(58, 49);
            this.lblPW.TabIndex = 2;
            this.lblPW.Text = "密    碼";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPW.Location = new System.Drawing.Point(113, 59);
            this.tbPW.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.tbPW.MaxLength = 128;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(228, 24);
            this.tbPW.TabIndex = 1;
            this.tbPW.UseSystemPasswordChar = true;
            this.tbPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPW_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUser.Font = new System.Drawing.Font("Arial", 11F);
            this.tbUser.Location = new System.Drawing.Point(113, 10);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.tbUser.MaxLength = 128;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(228, 24);
            this.tbUser.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 45);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(59, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(150, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseUp);
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
            // FormPermision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(398, 290);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPermision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理者登入";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUniCalsonic)).EndInit();
            this.tlpLogin.ResumeLayout(false);
            this.tlpLogin.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.PictureBox pbLogoUniCalsonic;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
    }
}