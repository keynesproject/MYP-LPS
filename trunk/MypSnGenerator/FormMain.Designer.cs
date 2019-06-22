namespace MypSnGenerator
{
    partial class FormMain
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCustomSN = new System.Windows.Forms.TableLayoutPanel();
            this.btnCustomSN = new System.Windows.Forms.Button();
            this.tbCustomSerialNo = new System.Windows.Forms.TextBox();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.tlpVerifyInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblVerifyMachineCodeValue = new System.Windows.Forms.Label();
            this.lblVerifyExpiredDateValue = new System.Windows.Forms.Label();
            this.lblVerifyCreationDateValue = new System.Windows.Forms.Label();
            this.lblVerifyIsValidValue = new System.Windows.Forms.Label();
            this.lblVerifyIsValid = new System.Windows.Forms.Label();
            this.lblVerifyCreationDate = new System.Windows.Forms.Label();
            this.lblVerifyExpiredDate = new System.Windows.Forms.Label();
            this.lblVerifyMachineCode = new System.Windows.Forms.Label();
            this.lblVerifyDayLeft = new System.Windows.Forms.Label();
            this.tlpVerifyDaysLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblVerifyDaysLeftInfo = new System.Windows.Forms.Label();
            this.numVerifyDaysLeft = new System.Windows.Forms.NumericUpDown();
            this.lblCustomSN = new System.Windows.Forms.Label();
            this.tlpVerifyGenCode = new System.Windows.Forms.TableLayoutPanel();
            this.tbVerificationCode = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tlpCustomInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomDaysLeftValue = new System.Windows.Forms.Label();
            this.lblCustomMachineCodeValue = new System.Windows.Forms.Label();
            this.lblCustomExpiredDateValue = new System.Windows.Forms.Label();
            this.lblCustomCreationDateValue = new System.Windows.Forms.Label();
            this.lblCustomIsExpiredValue = new System.Windows.Forms.Label();
            this.lblCustomIsValidValue = new System.Windows.Forms.Label();
            this.lblCustomIsValid = new System.Windows.Forms.Label();
            this.lblCustomIsExpired = new System.Windows.Forms.Label();
            this.lblCustomCreationDate = new System.Windows.Forms.Label();
            this.lblCustomExpiredDate = new System.Windows.Forms.Label();
            this.lblCustomDaysLeft = new System.Windows.Forms.Label();
            this.lblCustomMachineCode = new System.Windows.Forms.Label();
            this.pnlUnderlineVerifyCode = new System.Windows.Forms.Panel();
            this.tlpBase.SuspendLayout();
            this.tlpCustomSN.SuspendLayout();
            this.tlpVerifyInfo.SuspendLayout();
            this.tlpVerifyDaysLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVerifyDaysLeft)).BeginInit();
            this.tlpVerifyGenCode.SuspendLayout();
            this.tlpCustomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 698F));
            this.tlpBase.Controls.Add(this.tlpCustomSN, 0, 2);
            this.tlpBase.Controls.Add(this.lblVerificationCode, 0, 5);
            this.tlpBase.Controls.Add(this.tlpVerifyInfo, 0, 7);
            this.tlpBase.Controls.Add(this.lblCustomSN, 0, 1);
            this.tlpBase.Controls.Add(this.tlpVerifyGenCode, 0, 6);
            this.tlpBase.Controls.Add(this.tlpCustomInfo, 0, 3);
            this.tlpBase.Controls.Add(this.pnlUnderlineVerifyCode, 0, 4);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 8;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(698, 336);
            this.tlpBase.TabIndex = 1;
            // 
            // tlpCustomSN
            // 
            this.tlpCustomSN.AutoSize = true;
            this.tlpCustomSN.ColumnCount = 2;
            this.tlpCustomSN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCustomSN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCustomSN.Controls.Add(this.btnCustomSN, 1, 0);
            this.tlpCustomSN.Controls.Add(this.tbCustomSerialNo, 0, 0);
            this.tlpCustomSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCustomSN.Location = new System.Drawing.Point(3, 38);
            this.tlpCustomSN.Name = "tlpCustomSN";
            this.tlpCustomSN.RowCount = 1;
            this.tlpCustomSN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCustomSN.Size = new System.Drawing.Size(692, 33);
            this.tlpCustomSN.TabIndex = 27;
            // 
            // btnCustomSN
            // 
            this.btnCustomSN.AutoSize = true;
            this.btnCustomSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomSN.Location = new System.Drawing.Point(655, 3);
            this.btnCustomSN.Name = "btnCustomSN";
            this.btnCustomSN.Size = new System.Drawing.Size(34, 27);
            this.btnCustomSN.TabIndex = 3;
            this.btnCustomSN.Text = "Gen";
            this.btnCustomSN.UseVisualStyleBackColor = true;
            this.btnCustomSN.Visible = false;
            this.btnCustomSN.Click += new System.EventHandler(this.btnCustomSN_Click);
            // 
            // tbCustomSerialNo
            // 
            this.tbCustomSerialNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbCustomSerialNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomSerialNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbCustomSerialNo.ForeColor = System.Drawing.Color.LightCoral;
            this.tbCustomSerialNo.Location = new System.Drawing.Point(3, 3);
            this.tbCustomSerialNo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbCustomSerialNo.MaxLength = 128;
            this.tbCustomSerialNo.Name = "tbCustomSerialNo";
            this.tbCustomSerialNo.Size = new System.Drawing.Size(646, 27);
            this.tbCustomSerialNo.TabIndex = 0;
            this.tbCustomSerialNo.TextChanged += new System.EventHandler(this.tbCustomSerialNo_TextChanged);
            this.tbCustomSerialNo.Enter += new System.EventHandler(this.tbCustomSerialNo_Enter);
            this.tbCustomSerialNo.Leave += new System.EventHandler(this.tbCustomSerialNo_Leave);
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificationCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerificationCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificationCode.ForeColor = System.Drawing.Color.Black;
            this.lblVerificationCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerificationCode.Location = new System.Drawing.Point(5, 180);
            this.lblVerificationCode.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(690, 30);
            this.lblVerificationCode.TabIndex = 20;
            this.lblVerificationCode.Text = "認證序號 :";
            this.lblVerificationCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpVerifyInfo
            // 
            this.tlpVerifyInfo.ColumnCount = 4;
            this.tlpVerifyInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVerifyInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVerifyInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVerifyInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyMachineCodeValue, 1, 2);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyExpiredDateValue, 3, 1);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyCreationDateValue, 1, 1);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyIsValidValue, 1, 0);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyIsValid, 0, 0);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyCreationDate, 0, 1);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyExpiredDate, 2, 1);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyMachineCode, 0, 2);
            this.tlpVerifyInfo.Controls.Add(this.lblVerifyDayLeft, 2, 0);
            this.tlpVerifyInfo.Controls.Add(this.tlpVerifyDaysLeft, 3, 0);
            this.tlpVerifyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVerifyInfo.Location = new System.Drawing.Point(3, 249);
            this.tlpVerifyInfo.Name = "tlpVerifyInfo";
            this.tlpVerifyInfo.RowCount = 3;
            this.tlpVerifyInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpVerifyInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpVerifyInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpVerifyInfo.Size = new System.Drawing.Size(692, 84);
            this.tlpVerifyInfo.TabIndex = 26;
            // 
            // lblVerifyMachineCodeValue
            // 
            this.lblVerifyMachineCodeValue.AutoSize = true;
            this.lblVerifyMachineCodeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyMachineCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyMachineCodeValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVerifyMachineCodeValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblVerifyMachineCodeValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyMachineCodeValue.Location = new System.Drawing.Point(100, 55);
            this.lblVerifyMachineCodeValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyMachineCodeValue.Name = "lblVerifyMachineCodeValue";
            this.lblVerifyMachineCodeValue.Size = new System.Drawing.Size(226, 29);
            this.lblVerifyMachineCodeValue.TabIndex = 34;
            this.lblVerifyMachineCodeValue.Text = "Machine Code Value";
            this.lblVerifyMachineCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyMachineCodeValue.Visible = false;
            // 
            // lblVerifyExpiredDateValue
            // 
            this.lblVerifyExpiredDateValue.AutoSize = true;
            this.lblVerifyExpiredDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyExpiredDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyExpiredDateValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVerifyExpiredDateValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblVerifyExpiredDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyExpiredDateValue.Location = new System.Drawing.Point(463, 27);
            this.lblVerifyExpiredDateValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyExpiredDateValue.Name = "lblVerifyExpiredDateValue";
            this.lblVerifyExpiredDateValue.Size = new System.Drawing.Size(226, 28);
            this.lblVerifyExpiredDateValue.TabIndex = 33;
            this.lblVerifyExpiredDateValue.Text = "Expired Date Value";
            this.lblVerifyExpiredDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyExpiredDateValue.Visible = false;
            // 
            // lblVerifyCreationDateValue
            // 
            this.lblVerifyCreationDateValue.AutoSize = true;
            this.lblVerifyCreationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyCreationDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyCreationDateValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVerifyCreationDateValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblVerifyCreationDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyCreationDateValue.Location = new System.Drawing.Point(100, 27);
            this.lblVerifyCreationDateValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyCreationDateValue.Name = "lblVerifyCreationDateValue";
            this.lblVerifyCreationDateValue.Size = new System.Drawing.Size(226, 28);
            this.lblVerifyCreationDateValue.TabIndex = 32;
            this.lblVerifyCreationDateValue.Text = "Creation Date Value";
            this.lblVerifyCreationDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyCreationDateValue.Visible = false;
            // 
            // lblVerifyIsValidValue
            // 
            this.lblVerifyIsValidValue.AutoSize = true;
            this.lblVerifyIsValidValue.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyIsValidValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyIsValidValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVerifyIsValidValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblVerifyIsValidValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyIsValidValue.Location = new System.Drawing.Point(100, 0);
            this.lblVerifyIsValidValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyIsValidValue.Name = "lblVerifyIsValidValue";
            this.lblVerifyIsValidValue.Size = new System.Drawing.Size(226, 27);
            this.lblVerifyIsValidValue.TabIndex = 31;
            this.lblVerifyIsValidValue.Text = "Is Valid Value";
            this.lblVerifyIsValidValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyIsValidValue.Visible = false;
            // 
            // lblVerifyIsValid
            // 
            this.lblVerifyIsValid.AutoSize = true;
            this.lblVerifyIsValid.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyIsValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyIsValid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyIsValid.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyIsValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyIsValid.Location = new System.Drawing.Point(5, 0);
            this.lblVerifyIsValid.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyIsValid.Name = "lblVerifyIsValid";
            this.lblVerifyIsValid.Size = new System.Drawing.Size(87, 27);
            this.lblVerifyIsValid.TabIndex = 20;
            this.lblVerifyIsValid.Text = "是否有效 :";
            this.lblVerifyIsValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerifyCreationDate
            // 
            this.lblVerifyCreationDate.AutoSize = true;
            this.lblVerifyCreationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyCreationDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyCreationDate.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyCreationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyCreationDate.Location = new System.Drawing.Point(5, 27);
            this.lblVerifyCreationDate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyCreationDate.Name = "lblVerifyCreationDate";
            this.lblVerifyCreationDate.Size = new System.Drawing.Size(87, 28);
            this.lblVerifyCreationDate.TabIndex = 23;
            this.lblVerifyCreationDate.Text = "建立日期 :";
            this.lblVerifyCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerifyExpiredDate
            // 
            this.lblVerifyExpiredDate.AutoSize = true;
            this.lblVerifyExpiredDate.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyExpiredDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyExpiredDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyExpiredDate.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyExpiredDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyExpiredDate.Location = new System.Drawing.Point(334, 27);
            this.lblVerifyExpiredDate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyExpiredDate.Name = "lblVerifyExpiredDate";
            this.lblVerifyExpiredDate.Size = new System.Drawing.Size(121, 28);
            this.lblVerifyExpiredDate.TabIndex = 24;
            this.lblVerifyExpiredDate.Text = "到期日期 :";
            this.lblVerifyExpiredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerifyMachineCode
            // 
            this.lblVerifyMachineCode.AutoSize = true;
            this.lblVerifyMachineCode.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyMachineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyMachineCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyMachineCode.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyMachineCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyMachineCode.Location = new System.Drawing.Point(5, 55);
            this.lblVerifyMachineCode.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyMachineCode.Name = "lblVerifyMachineCode";
            this.lblVerifyMachineCode.Size = new System.Drawing.Size(87, 29);
            this.lblVerifyMachineCode.TabIndex = 21;
            this.lblVerifyMachineCode.Text = "電腦代碼 :";
            this.lblVerifyMachineCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerifyDayLeft
            // 
            this.lblVerifyDayLeft.AutoSize = true;
            this.lblVerifyDayLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyDayLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyDayLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyDayLeft.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyDayLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyDayLeft.Location = new System.Drawing.Point(334, 0);
            this.lblVerifyDayLeft.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyDayLeft.Name = "lblVerifyDayLeft";
            this.lblVerifyDayLeft.Size = new System.Drawing.Size(121, 27);
            this.lblVerifyDayLeft.TabIndex = 25;
            this.lblVerifyDayLeft.Text = "使用天數設定 :";
            this.lblVerifyDayLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpVerifyDaysLeft
            // 
            this.tlpVerifyDaysLeft.ColumnCount = 2;
            this.tlpVerifyDaysLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVerifyDaysLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVerifyDaysLeft.Controls.Add(this.lblVerifyDaysLeftInfo, 1, 0);
            this.tlpVerifyDaysLeft.Controls.Add(this.numVerifyDaysLeft, 0, 0);
            this.tlpVerifyDaysLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVerifyDaysLeft.Location = new System.Drawing.Point(458, 0);
            this.tlpVerifyDaysLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVerifyDaysLeft.Name = "tlpVerifyDaysLeft";
            this.tlpVerifyDaysLeft.RowCount = 1;
            this.tlpVerifyDaysLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVerifyDaysLeft.Size = new System.Drawing.Size(234, 27);
            this.tlpVerifyDaysLeft.TabIndex = 26;
            // 
            // lblVerifyDaysLeftInfo
            // 
            this.lblVerifyDaysLeftInfo.AutoSize = true;
            this.lblVerifyDaysLeftInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyDaysLeftInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerifyDaysLeftInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblVerifyDaysLeftInfo.ForeColor = System.Drawing.Color.Black;
            this.lblVerifyDaysLeftInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVerifyDaysLeftInfo.Location = new System.Drawing.Point(68, 0);
            this.lblVerifyDaysLeftInfo.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblVerifyDaysLeftInfo.Name = "lblVerifyDaysLeftInfo";
            this.lblVerifyDaysLeftInfo.Size = new System.Drawing.Size(163, 27);
            this.lblVerifyDaysLeftInfo.TabIndex = 27;
            this.lblVerifyDaysLeftInfo.Text = "0 代表無期限";
            this.lblVerifyDaysLeftInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numVerifyDaysLeft
            // 
            this.numVerifyDaysLeft.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVerifyDaysLeft.Location = new System.Drawing.Point(3, 3);
            this.numVerifyDaysLeft.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numVerifyDaysLeft.Name = "numVerifyDaysLeft";
            this.numVerifyDaysLeft.Size = new System.Drawing.Size(57, 23);
            this.numVerifyDaysLeft.TabIndex = 5;
            this.numVerifyDaysLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVerifyDaysLeft.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblCustomSN
            // 
            this.lblCustomSN.AutoSize = true;
            this.lblCustomSN.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomSN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomSN.ForeColor = System.Drawing.Color.Black;
            this.lblCustomSN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomSN.Location = new System.Drawing.Point(5, 5);
            this.lblCustomSN.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomSN.Name = "lblCustomSN";
            this.lblCustomSN.Size = new System.Drawing.Size(690, 30);
            this.lblCustomSN.TabIndex = 19;
            this.lblCustomSN.Text = "客戶序號:";
            this.lblCustomSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpVerifyGenCode
            // 
            this.tlpVerifyGenCode.AutoSize = true;
            this.tlpVerifyGenCode.ColumnCount = 2;
            this.tlpVerifyGenCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVerifyGenCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpVerifyGenCode.Controls.Add(this.tbVerificationCode, 0, 0);
            this.tlpVerifyGenCode.Controls.Add(this.btnGenerate, 1, 0);
            this.tlpVerifyGenCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVerifyGenCode.Location = new System.Drawing.Point(3, 213);
            this.tlpVerifyGenCode.Name = "tlpVerifyGenCode";
            this.tlpVerifyGenCode.RowCount = 1;
            this.tlpVerifyGenCode.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVerifyGenCode.Size = new System.Drawing.Size(692, 30);
            this.tlpVerifyGenCode.TabIndex = 23;
            // 
            // tbVerificationCode
            // 
            this.tbVerificationCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbVerificationCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVerificationCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerificationCode.ForeColor = System.Drawing.Color.Red;
            this.tbVerificationCode.Location = new System.Drawing.Point(3, 3);
            this.tbVerificationCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbVerificationCode.MaxLength = 128;
            this.tbVerificationCode.Name = "tbVerificationCode";
            this.tbVerificationCode.ReadOnly = true;
            this.tbVerificationCode.Size = new System.Drawing.Size(646, 27);
            this.tbVerificationCode.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.Location = new System.Drawing.Point(655, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(34, 24);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Gen";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tlpCustomInfo
            // 
            this.tlpCustomInfo.ColumnCount = 4;
            this.tlpCustomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCustomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCustomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCustomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCustomInfo.Controls.Add(this.lblCustomDaysLeftValue, 3, 2);
            this.tlpCustomInfo.Controls.Add(this.lblCustomMachineCodeValue, 1, 2);
            this.tlpCustomInfo.Controls.Add(this.lblCustomExpiredDateValue, 3, 1);
            this.tlpCustomInfo.Controls.Add(this.lblCustomCreationDateValue, 1, 1);
            this.tlpCustomInfo.Controls.Add(this.lblCustomIsExpiredValue, 3, 0);
            this.tlpCustomInfo.Controls.Add(this.lblCustomIsValidValue, 1, 0);
            this.tlpCustomInfo.Controls.Add(this.lblCustomIsValid, 0, 0);
            this.tlpCustomInfo.Controls.Add(this.lblCustomIsExpired, 2, 0);
            this.tlpCustomInfo.Controls.Add(this.lblCustomCreationDate, 0, 1);
            this.tlpCustomInfo.Controls.Add(this.lblCustomExpiredDate, 2, 1);
            this.tlpCustomInfo.Controls.Add(this.lblCustomDaysLeft, 2, 2);
            this.tlpCustomInfo.Controls.Add(this.lblCustomMachineCode, 0, 2);
            this.tlpCustomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCustomInfo.Location = new System.Drawing.Point(3, 77);
            this.tlpCustomInfo.Name = "tlpCustomInfo";
            this.tlpCustomInfo.RowCount = 3;
            this.tlpCustomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCustomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCustomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpCustomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCustomInfo.Size = new System.Drawing.Size(692, 94);
            this.tlpCustomInfo.TabIndex = 24;
            // 
            // lblCustomDaysLeftValue
            // 
            this.lblCustomDaysLeftValue.AutoSize = true;
            this.lblCustomDaysLeftValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomDaysLeftValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomDaysLeftValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomDaysLeftValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomDaysLeftValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomDaysLeftValue.Location = new System.Drawing.Point(463, 62);
            this.lblCustomDaysLeftValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomDaysLeftValue.Name = "lblCustomDaysLeftValue";
            this.lblCustomDaysLeftValue.Size = new System.Drawing.Size(226, 32);
            this.lblCustomDaysLeftValue.TabIndex = 31;
            this.lblCustomDaysLeftValue.Text = "Days Left Value";
            this.lblCustomDaysLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomDaysLeftValue.Visible = false;
            // 
            // lblCustomMachineCodeValue
            // 
            this.lblCustomMachineCodeValue.AutoSize = true;
            this.lblCustomMachineCodeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomMachineCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomMachineCodeValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomMachineCodeValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomMachineCodeValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomMachineCodeValue.Location = new System.Drawing.Point(100, 62);
            this.lblCustomMachineCodeValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomMachineCodeValue.Name = "lblCustomMachineCodeValue";
            this.lblCustomMachineCodeValue.Size = new System.Drawing.Size(226, 32);
            this.lblCustomMachineCodeValue.TabIndex = 30;
            this.lblCustomMachineCodeValue.Text = "Machine Code Value";
            this.lblCustomMachineCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomMachineCodeValue.Visible = false;
            // 
            // lblCustomExpiredDateValue
            // 
            this.lblCustomExpiredDateValue.AutoSize = true;
            this.lblCustomExpiredDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomExpiredDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomExpiredDateValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomExpiredDateValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomExpiredDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomExpiredDateValue.Location = new System.Drawing.Point(463, 31);
            this.lblCustomExpiredDateValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomExpiredDateValue.Name = "lblCustomExpiredDateValue";
            this.lblCustomExpiredDateValue.Size = new System.Drawing.Size(226, 31);
            this.lblCustomExpiredDateValue.TabIndex = 29;
            this.lblCustomExpiredDateValue.Text = "Expired Date Value";
            this.lblCustomExpiredDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomExpiredDateValue.Visible = false;
            // 
            // lblCustomCreationDateValue
            // 
            this.lblCustomCreationDateValue.AutoSize = true;
            this.lblCustomCreationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomCreationDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomCreationDateValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomCreationDateValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomCreationDateValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomCreationDateValue.Location = new System.Drawing.Point(100, 31);
            this.lblCustomCreationDateValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomCreationDateValue.Name = "lblCustomCreationDateValue";
            this.lblCustomCreationDateValue.Size = new System.Drawing.Size(226, 31);
            this.lblCustomCreationDateValue.TabIndex = 28;
            this.lblCustomCreationDateValue.Text = "Creation Date Value";
            this.lblCustomCreationDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomCreationDateValue.Visible = false;
            // 
            // lblCustomIsExpiredValue
            // 
            this.lblCustomIsExpiredValue.AutoSize = true;
            this.lblCustomIsExpiredValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomIsExpiredValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomIsExpiredValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomIsExpiredValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomIsExpiredValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsExpiredValue.Location = new System.Drawing.Point(463, 0);
            this.lblCustomIsExpiredValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomIsExpiredValue.Name = "lblCustomIsExpiredValue";
            this.lblCustomIsExpiredValue.Size = new System.Drawing.Size(226, 31);
            this.lblCustomIsExpiredValue.TabIndex = 27;
            this.lblCustomIsExpiredValue.Text = "Is Expired Value";
            this.lblCustomIsExpiredValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsExpiredValue.Visible = false;
            // 
            // lblCustomIsValidValue
            // 
            this.lblCustomIsValidValue.AutoSize = true;
            this.lblCustomIsValidValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomIsValidValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomIsValidValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomIsValidValue.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCustomIsValidValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsValidValue.Location = new System.Drawing.Point(100, 0);
            this.lblCustomIsValidValue.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomIsValidValue.Name = "lblCustomIsValidValue";
            this.lblCustomIsValidValue.Size = new System.Drawing.Size(226, 31);
            this.lblCustomIsValidValue.TabIndex = 26;
            this.lblCustomIsValidValue.Text = "Is Valid Value";
            this.lblCustomIsValidValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsValidValue.Visible = false;
            // 
            // lblCustomIsValid
            // 
            this.lblCustomIsValid.AutoSize = true;
            this.lblCustomIsValid.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomIsValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomIsValid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomIsValid.ForeColor = System.Drawing.Color.Black;
            this.lblCustomIsValid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsValid.Location = new System.Drawing.Point(5, 0);
            this.lblCustomIsValid.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomIsValid.Name = "lblCustomIsValid";
            this.lblCustomIsValid.Size = new System.Drawing.Size(87, 31);
            this.lblCustomIsValid.TabIndex = 20;
            this.lblCustomIsValid.Text = "是否有效 :";
            this.lblCustomIsValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomIsExpired
            // 
            this.lblCustomIsExpired.AutoSize = true;
            this.lblCustomIsExpired.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomIsExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomIsExpired.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomIsExpired.ForeColor = System.Drawing.Color.Black;
            this.lblCustomIsExpired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomIsExpired.Location = new System.Drawing.Point(334, 0);
            this.lblCustomIsExpired.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomIsExpired.Name = "lblCustomIsExpired";
            this.lblCustomIsExpired.Size = new System.Drawing.Size(121, 31);
            this.lblCustomIsExpired.TabIndex = 22;
            this.lblCustomIsExpired.Text = "是否到期 :";
            this.lblCustomIsExpired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomCreationDate
            // 
            this.lblCustomCreationDate.AutoSize = true;
            this.lblCustomCreationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomCreationDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomCreationDate.ForeColor = System.Drawing.Color.Black;
            this.lblCustomCreationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomCreationDate.Location = new System.Drawing.Point(5, 31);
            this.lblCustomCreationDate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomCreationDate.Name = "lblCustomCreationDate";
            this.lblCustomCreationDate.Size = new System.Drawing.Size(87, 31);
            this.lblCustomCreationDate.TabIndex = 23;
            this.lblCustomCreationDate.Text = "建立日期 :";
            this.lblCustomCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomExpiredDate
            // 
            this.lblCustomExpiredDate.AutoSize = true;
            this.lblCustomExpiredDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomExpiredDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomExpiredDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomExpiredDate.ForeColor = System.Drawing.Color.Black;
            this.lblCustomExpiredDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomExpiredDate.Location = new System.Drawing.Point(334, 31);
            this.lblCustomExpiredDate.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomExpiredDate.Name = "lblCustomExpiredDate";
            this.lblCustomExpiredDate.Size = new System.Drawing.Size(121, 31);
            this.lblCustomExpiredDate.TabIndex = 24;
            this.lblCustomExpiredDate.Text = "到期日期 :";
            this.lblCustomExpiredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomDaysLeft
            // 
            this.lblCustomDaysLeft.AutoSize = true;
            this.lblCustomDaysLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomDaysLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomDaysLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomDaysLeft.ForeColor = System.Drawing.Color.Black;
            this.lblCustomDaysLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomDaysLeft.Location = new System.Drawing.Point(334, 62);
            this.lblCustomDaysLeft.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomDaysLeft.Name = "lblCustomDaysLeft";
            this.lblCustomDaysLeft.Size = new System.Drawing.Size(121, 32);
            this.lblCustomDaysLeft.TabIndex = 25;
            this.lblCustomDaysLeft.Text = "到期剩餘天數 :";
            this.lblCustomDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomMachineCode
            // 
            this.lblCustomMachineCode.AutoSize = true;
            this.lblCustomMachineCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomMachineCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomMachineCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomMachineCode.ForeColor = System.Drawing.Color.Black;
            this.lblCustomMachineCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomMachineCode.Location = new System.Drawing.Point(5, 62);
            this.lblCustomMachineCode.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblCustomMachineCode.Name = "lblCustomMachineCode";
            this.lblCustomMachineCode.Size = new System.Drawing.Size(87, 32);
            this.lblCustomMachineCode.TabIndex = 21;
            this.lblCustomMachineCode.Text = "電腦代碼 :";
            this.lblCustomMachineCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUnderlineVerifyCode
            // 
            this.pnlUnderlineVerifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderlineVerifyCode.AutoSize = true;
            this.pnlUnderlineVerifyCode.BackColor = System.Drawing.Color.Black;
            this.pnlUnderlineVerifyCode.Location = new System.Drawing.Point(3, 177);
            this.pnlUnderlineVerifyCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.pnlUnderlineVerifyCode.Name = "pnlUnderlineVerifyCode";
            this.pnlUnderlineVerifyCode.Size = new System.Drawing.Size(692, 1);
            this.pnlUnderlineVerifyCode.TabIndex = 25;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 336);
            this.Controls.Add(this.tlpBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "MYP序號產生器";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpCustomSN.ResumeLayout(false);
            this.tlpCustomSN.PerformLayout();
            this.tlpVerifyInfo.ResumeLayout(false);
            this.tlpVerifyInfo.PerformLayout();
            this.tlpVerifyDaysLeft.ResumeLayout(false);
            this.tlpVerifyDaysLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVerifyDaysLeft)).EndInit();
            this.tlpVerifyGenCode.ResumeLayout(false);
            this.tlpVerifyGenCode.PerformLayout();
            this.tlpCustomInfo.ResumeLayout(false);
            this.tlpCustomInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpCustomSN;
        private System.Windows.Forms.Button btnCustomSN;
        private System.Windows.Forms.TextBox tbCustomSerialNo;
        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.TableLayoutPanel tlpVerifyInfo;
        private System.Windows.Forms.Label lblVerifyMachineCodeValue;
        private System.Windows.Forms.Label lblVerifyExpiredDateValue;
        private System.Windows.Forms.Label lblVerifyCreationDateValue;
        private System.Windows.Forms.Label lblVerifyIsValidValue;
        private System.Windows.Forms.Label lblVerifyIsValid;
        private System.Windows.Forms.Label lblVerifyCreationDate;
        private System.Windows.Forms.Label lblVerifyExpiredDate;
        private System.Windows.Forms.Label lblVerifyMachineCode;
        private System.Windows.Forms.Label lblVerifyDayLeft;
        private System.Windows.Forms.TableLayoutPanel tlpVerifyDaysLeft;
        private System.Windows.Forms.Label lblVerifyDaysLeftInfo;
        private System.Windows.Forms.NumericUpDown numVerifyDaysLeft;
        private System.Windows.Forms.Label lblCustomSN;
        private System.Windows.Forms.TableLayoutPanel tlpVerifyGenCode;
        private System.Windows.Forms.TextBox tbVerificationCode;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tlpCustomInfo;
        private System.Windows.Forms.Label lblCustomDaysLeftValue;
        private System.Windows.Forms.Label lblCustomMachineCodeValue;
        private System.Windows.Forms.Label lblCustomExpiredDateValue;
        private System.Windows.Forms.Label lblCustomCreationDateValue;
        private System.Windows.Forms.Label lblCustomIsExpiredValue;
        private System.Windows.Forms.Label lblCustomIsValidValue;
        private System.Windows.Forms.Label lblCustomIsValid;
        private System.Windows.Forms.Label lblCustomIsExpired;
        private System.Windows.Forms.Label lblCustomCreationDate;
        private System.Windows.Forms.Label lblCustomExpiredDate;
        private System.Windows.Forms.Label lblCustomDaysLeft;
        private System.Windows.Forms.Label lblCustomMachineCode;
        private System.Windows.Forms.Panel pnlUnderlineVerifyCode;
    }
}

