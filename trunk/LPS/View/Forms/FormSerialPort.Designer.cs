namespace LPS.View.Forms
{
    partial class FormSerialPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPort));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.lblDotAdmin = new System.Windows.Forms.Label();
            this.lblDotSerial = new System.Windows.Forms.Label();
            this.lblDotName = new System.Windows.Forms.Label();
            this.lbDotPW = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblDotConfirmPW = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
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
            this.tlpBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 5;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.Size = new System.Drawing.Size(332, 261);
            this.tlpBase.TabIndex = 3;
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
            this.tlpButton.Controls.Add(this.btnConnect, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 193);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(326, 64);
            this.tlpButton.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.Location = new System.Drawing.Point(232, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 54);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "離  開";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseUp);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 12F);
            this.btnConnect.Location = new System.Drawing.Point(135, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 54);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "連  線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnConnect_MouseUp);
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 4;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpOption.Controls.Add(this.lblDotAdmin, 0, 4);
            this.tlpOption.Controls.Add(this.lblDotSerial, 0, 0);
            this.tlpOption.Controls.Add(this.lblDotName, 0, 1);
            this.tlpOption.Controls.Add(this.lbDotPW, 0, 2);
            this.tlpOption.Controls.Add(this.lblSerial, 1, 0);
            this.tlpOption.Controls.Add(this.lblBaudRate, 1, 1);
            this.tlpOption.Controls.Add(this.lblDataBit, 1, 2);
            this.tlpOption.Controls.Add(this.lblDotConfirmPW, 0, 3);
            this.tlpOption.Controls.Add(this.lblParity, 1, 3);
            this.tlpOption.Controls.Add(this.lblStopBit, 1, 4);
            this.tlpOption.Controls.Add(this.cbStopBit, 2, 4);
            this.tlpOption.Controls.Add(this.cbSerial, 2, 0);
            this.tlpOption.Controls.Add(this.cbBaudRate, 2, 1);
            this.tlpOption.Controls.Add(this.cbDataBits, 2, 2);
            this.tlpOption.Controls.Add(this.cbParity, 2, 3);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 4);
            this.tlpOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 5;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.Size = new System.Drawing.Size(326, 165);
            this.tlpOption.TabIndex = 1;
            // 
            // cbSerial
            // 
            this.cbSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(136, 4);
            this.cbSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(164, 25);
            this.cbSerial.TabIndex = 0;
            this.cbSerial.Click += new System.EventHandler(this.CbSerial_Click);
            // 
            // lblDotAdmin
            // 
            this.lblDotAdmin.AutoSize = true;
            this.lblDotAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblDotAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotAdmin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotAdmin.Location = new System.Drawing.Point(3, 136);
            this.lblDotAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotAdmin.Name = "lblDotAdmin";
            this.lblDotAdmin.Size = new System.Drawing.Size(17, 25);
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
            this.lblDotSerial.Location = new System.Drawing.Point(3, 4);
            this.lblDotSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotSerial.Name = "lblDotSerial";
            this.lblDotSerial.Size = new System.Drawing.Size(17, 25);
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
            this.lblDotName.Location = new System.Drawing.Point(3, 37);
            this.lblDotName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotName.Name = "lblDotName";
            this.lblDotName.Size = new System.Drawing.Size(17, 25);
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
            this.lbDotPW.Location = new System.Drawing.Point(3, 70);
            this.lbDotPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbDotPW.Name = "lbDotPW";
            this.lbDotPW.Size = new System.Drawing.Size(17, 25);
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
            this.lblSerial.Location = new System.Drawing.Point(26, 4);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(104, 25);
            this.lblSerial.TabIndex = 156;
            this.lblSerial.Text = "串        口";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.lblBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaudRate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(26, 37);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(104, 25);
            this.lblBaudRate.TabIndex = 157;
            this.lblBaudRate.Text = "串列傳輸速率";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataBit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBit.Location = new System.Drawing.Point(26, 70);
            this.lblDataBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(104, 25);
            this.lblDataBit.TabIndex = 164;
            this.lblDataBit.Text = "數據位元";
            this.lblDataBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotConfirmPW
            // 
            this.lblDotConfirmPW.AutoSize = true;
            this.lblDotConfirmPW.BackColor = System.Drawing.Color.Transparent;
            this.lblDotConfirmPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotConfirmPW.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotConfirmPW.Location = new System.Drawing.Point(3, 103);
            this.lblDotConfirmPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotConfirmPW.Name = "lblDotConfirmPW";
            this.lblDotConfirmPW.Size = new System.Drawing.Size(17, 25);
            this.lblDotConfirmPW.TabIndex = 165;
            this.lblDotConfirmPW.Text = "˙";
            this.lblDotConfirmPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.BackColor = System.Drawing.Color.Transparent;
            this.lblParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(26, 103);
            this.lblParity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(104, 25);
            this.lblParity.TabIndex = 167;
            this.lblParity.Text = "較驗位元";
            this.lblParity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.BackColor = System.Drawing.Color.Transparent;
            this.lblStopBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStopBit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBit.Location = new System.Drawing.Point(26, 136);
            this.lblStopBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(104, 25);
            this.lblStopBit.TabIndex = 168;
            this.lblStopBit.Text = "停止位元";
            this.lblStopBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStopBit
            // 
            this.cbStopBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBit.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.cbStopBit.Location = new System.Drawing.Point(136, 136);
            this.cbStopBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(164, 25);
            this.cbStopBit.TabIndex = 4;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit.Location = new System.Drawing.Point(3, 179);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(326, 4);
            this.lblSplit.TabIndex = 4;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(136, 37);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(164, 25);
            this.cbBaudRate.TabIndex = 1;
            // 
            // cbDataBits
            // 
            this.cbDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbDataBits.Location = new System.Drawing.Point(136, 70);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(164, 25);
            this.cbDataBits.TabIndex = 2;
            // 
            // cbParity
            // 
            this.cbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("Arial", 11.25F);
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.cbParity.Location = new System.Drawing.Point(136, 103);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(164, 25);
            this.cbParity.TabIndex = 3;
            // 
            // FormSerialPort
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "測試設備連線設定";
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
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Label lblDotAdmin;
        private System.Windows.Forms.Label lblDotSerial;
        private System.Windows.Forms.Label lblDotName;
        private System.Windows.Forms.Label lbDotPW;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.Label lblDotConfirmPW;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
    }
}