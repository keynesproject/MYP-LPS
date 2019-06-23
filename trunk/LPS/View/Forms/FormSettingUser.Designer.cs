namespace LPS.View.Forms
{
    partial class FormSettingUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingUser));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.lblDotAdmin = new System.Windows.Forms.Label();
            this.lblDotSerial = new System.Windows.Forms.Label();
            this.lblDotName = new System.Windows.Forms.Label();
            this.lbDotPW = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.lblDotConfirmPW = new System.Windows.Forms.Label();
            this.lblConfirmPW = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.ComboBox();
            this.tlpBase.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpButton, 0, 4);
            this.tlpBase.Controls.Add(this.tlpOption, 0, 0);
            this.tlpBase.Controls.Add(this.lblSplit, 0, 2);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 5;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.Size = new System.Drawing.Size(332, 239);
            this.tlpBase.TabIndex = 2;
            // 
            // tlpButton
            // 
            this.tlpButton.AutoSize = true;
            this.tlpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButton.Controls.Add(this.btnAdd, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 176);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(326, 60);
            this.tlpButton.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.Location = new System.Drawing.Point(231, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 52);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.Location = new System.Drawing.Point(134, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新  增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAdd_MouseUp);
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 4;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.Controls.Add(this.lblDotAdmin, 0, 4);
            this.tlpOption.Controls.Add(this.lblDotSerial, 0, 0);
            this.tlpOption.Controls.Add(this.lblDotName, 0, 1);
            this.tlpOption.Controls.Add(this.lbDotPW, 0, 2);
            this.tlpOption.Controls.Add(this.lblSerial, 1, 0);
            this.tlpOption.Controls.Add(this.lblName, 1, 1);
            this.tlpOption.Controls.Add(this.lblPW, 1, 2);
            this.tlpOption.Controls.Add(this.tbSerial, 2, 0);
            this.tlpOption.Controls.Add(this.tbName, 2, 1);
            this.tlpOption.Controls.Add(this.tbPW, 2, 2);
            this.tlpOption.Controls.Add(this.lblDotConfirmPW, 0, 3);
            this.tlpOption.Controls.Add(this.lblConfirmPW, 1, 3);
            this.tlpOption.Controls.Add(this.lblAdmin, 1, 4);
            this.tlpOption.Controls.Add(this.tbConfirmPW, 2, 3);
            this.tlpOption.Controls.Add(this.cbAdmin, 2, 4);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 3);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 5;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.Size = new System.Drawing.Size(326, 154);
            this.tlpOption.TabIndex = 1;
            // 
            // lblDotAdmin
            // 
            this.lblDotAdmin.AutoSize = true;
            this.lblDotAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblDotAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotAdmin.Location = new System.Drawing.Point(3, 127);
            this.lblDotAdmin.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotAdmin.Name = "lblDotAdmin";
            this.lblDotAdmin.Size = new System.Drawing.Size(14, 24);
            this.lblDotAdmin.TabIndex = 166;
            this.lblDotAdmin.Text = "˙";
            this.lblDotAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotSerial
            // 
            this.lblDotSerial.AutoSize = true;
            this.lblDotSerial.BackColor = System.Drawing.Color.Transparent;
            this.lblDotSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotSerial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotSerial.Location = new System.Drawing.Point(3, 3);
            this.lblDotSerial.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotSerial.Name = "lblDotSerial";
            this.lblDotSerial.Size = new System.Drawing.Size(14, 25);
            this.lblDotSerial.TabIndex = 1;
            this.lblDotSerial.Text = "˙";
            this.lblDotSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotName
            // 
            this.lblDotName.AutoSize = true;
            this.lblDotName.BackColor = System.Drawing.Color.Transparent;
            this.lblDotName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotName.Location = new System.Drawing.Point(3, 34);
            this.lblDotName.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotName.Name = "lblDotName";
            this.lblDotName.Size = new System.Drawing.Size(14, 25);
            this.lblDotName.TabIndex = 2;
            this.lblDotName.Text = "˙";
            this.lblDotName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDotPW
            // 
            this.lbDotPW.AutoSize = true;
            this.lbDotPW.BackColor = System.Drawing.Color.Transparent;
            this.lbDotPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDotPW.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDotPW.Location = new System.Drawing.Point(3, 65);
            this.lbDotPW.Margin = new System.Windows.Forms.Padding(3);
            this.lbDotPW.Name = "lbDotPW";
            this.lbDotPW.Size = new System.Drawing.Size(14, 25);
            this.lbDotPW.TabIndex = 4;
            this.lbDotPW.Text = "˙";
            this.lbDotPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.BackColor = System.Drawing.Color.Transparent;
            this.lblSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSerial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(23, 3);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(3);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(88, 25);
            this.lblSerial.TabIndex = 156;
            this.lblSerial.Text = "代        碼";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 25);
            this.lblName.TabIndex = 157;
            this.lblName.Text = "姓        名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(23, 65);
            this.lblPW.Margin = new System.Windows.Forms.Padding(3);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(88, 25);
            this.lblPW.TabIndex = 164;
            this.lblPW.Text = "密        碼";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSerial
            // 
            this.tbSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSerial.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSerial.Location = new System.Drawing.Point(117, 3);
            this.tbSerial.MaxLength = 5;
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(186, 25);
            this.tbSerial.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbName.Location = new System.Drawing.Point(117, 34);
            this.tbName.MaxLength = 5;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 25);
            this.tbName.TabIndex = 1;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPW.Location = new System.Drawing.Point(117, 65);
            this.tbPW.MaxLength = 6;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(186, 25);
            this.tbPW.TabIndex = 2;
            this.tbPW.UseSystemPasswordChar = true;
            // 
            // lblDotConfirmPW
            // 
            this.lblDotConfirmPW.AutoSize = true;
            this.lblDotConfirmPW.BackColor = System.Drawing.Color.Transparent;
            this.lblDotConfirmPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotConfirmPW.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotConfirmPW.Location = new System.Drawing.Point(3, 96);
            this.lblDotConfirmPW.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotConfirmPW.Name = "lblDotConfirmPW";
            this.lblDotConfirmPW.Size = new System.Drawing.Size(14, 25);
            this.lblDotConfirmPW.TabIndex = 165;
            this.lblDotConfirmPW.Text = "˙";
            this.lblDotConfirmPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPW
            // 
            this.lblConfirmPW.AutoSize = true;
            this.lblConfirmPW.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPW.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPW.Location = new System.Drawing.Point(23, 96);
            this.lblConfirmPW.Margin = new System.Windows.Forms.Padding(3);
            this.lblConfirmPW.Name = "lblConfirmPW";
            this.lblConfirmPW.Size = new System.Drawing.Size(88, 25);
            this.lblConfirmPW.TabIndex = 167;
            this.lblConfirmPW.Text = "驗證密碼";
            this.lblConfirmPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(23, 127);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(3);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(88, 24);
            this.lblAdmin.TabIndex = 168;
            this.lblAdmin.Text = "管理者權限";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfirmPW.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbConfirmPW.Location = new System.Drawing.Point(117, 96);
            this.tbConfirmPW.MaxLength = 6;
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.PasswordChar = '*';
            this.tbConfirmPW.Size = new System.Drawing.Size(186, 25);
            this.tbConfirmPW.TabIndex = 3;
            this.tbConfirmPW.UseSystemPasswordChar = true;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit.Location = new System.Drawing.Point(3, 165);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(326, 3);
            this.lblSplit.TabIndex = 4;
            // 
            // cbAdmin
            // 
            this.cbAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdmin.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbAdmin.FormattingEnabled = true;
            this.cbAdmin.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cbAdmin.Location = new System.Drawing.Point(117, 127);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(186, 25);
            this.cbAdmin.TabIndex = 4;
            // 
            // FormSettingUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 239);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettingUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "作業員";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpButton.PerformLayout();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Label lblDotSerial;
        private System.Windows.Forms.Label lblDotName;
        private System.Windows.Forms.Label lbDotPW;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Label lblDotAdmin;
        private System.Windows.Forms.Label lblDotConfirmPW;
        private System.Windows.Forms.Label lblConfirmPW;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.ComboBox cbAdmin;
    }
}