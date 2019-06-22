namespace LPS.View.Pages
{
    partial class PageTest
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
            this.components = new System.ComponentModel.Container();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblsplit3 = new System.Windows.Forms.Label();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblsplit1 = new System.Windows.Forms.Label();
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.lblTitleMachineNo = new System.Windows.Forms.Label();
            this.lblTitleUID = new System.Windows.Forms.Label();
            this.lblTitleUserName = new System.Windows.Forms.Label();
            this.lblTitlePN = new System.Windows.Forms.Label();
            this.lblTitleCarName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitleTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblsplit2 = new System.Windows.Forms.Label();
            this.tlpPN = new System.Windows.Forms.TableLayoutPanel();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.btnPN = new System.Windows.Forms.Button();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.lblTitleSerial = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.lblTitleCode = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.lblsplit4 = new System.Windows.Forms.Label();
            this.lblTitleResult = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.tlpBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnLD = new System.Windows.Forms.Button();
            this.btnLU = new System.Windows.Forms.Button();
            this.btnRU = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.tlpBase.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.tlpPN.SuspendLayout();
            this.tlpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.tlpBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 3;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBase.Controls.Add(this.lblsplit3, 0, 0);
            this.tlpBase.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpBase.Controls.Add(this.tlpRight, 2, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(688, 329);
            this.tlpBase.TabIndex = 2;
            // 
            // lblsplit3
            // 
            this.lblsplit3.AutoSize = true;
            this.lblsplit3.BackColor = System.Drawing.Color.DarkGray;
            this.lblsplit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsplit3.Location = new System.Drawing.Point(479, 0);
            this.lblsplit3.Margin = new System.Windows.Forms.Padding(0);
            this.lblsplit3.Name = "lblsplit3";
            this.lblsplit3.Size = new System.Drawing.Size(3, 329);
            this.lblsplit3.TabIndex = 20;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.lblsplit1, 0, 4);
            this.tlpLeft.Controls.Add(this.lblMachineNo, 1, 1);
            this.tlpLeft.Controls.Add(this.lblTitleMachineNo, 0, 1);
            this.tlpLeft.Controls.Add(this.lblTitleUID, 0, 2);
            this.tlpLeft.Controls.Add(this.lblTitleUserName, 0, 3);
            this.tlpLeft.Controls.Add(this.lblTitlePN, 0, 5);
            this.tlpLeft.Controls.Add(this.lblTitleCarName, 0, 6);
            this.tlpLeft.Controls.Add(this.lblUserID, 1, 2);
            this.tlpLeft.Controls.Add(this.lblUserName, 1, 3);
            this.tlpLeft.Controls.Add(this.lblTitleTime, 0, 0);
            this.tlpLeft.Controls.Add(this.lblTime, 1, 0);
            this.tlpLeft.Controls.Add(this.lblsplit2, 1, 4);
            this.tlpLeft.Controls.Add(this.tlpPN, 1, 5);
            this.tlpLeft.Controls.Add(this.tbCarName, 1, 6);
            this.tlpLeft.Controls.Add(this.lblTitleSerial, 0, 8);
            this.tlpLeft.Controls.Add(this.tbSerial, 1, 8);
            this.tlpLeft.Controls.Add(this.lblTitleCode, 0, 7);
            this.tlpLeft.Controls.Add(this.tbCode, 1, 7);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tlpLeft.Location = new System.Drawing.Point(3, 4);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 10;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(473, 321);
            this.tlpLeft.TabIndex = 0;
            // 
            // lblsplit1
            // 
            this.lblsplit1.AutoSize = true;
            this.lblsplit1.BackColor = System.Drawing.Color.DarkGray;
            this.lblsplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsplit1.Location = new System.Drawing.Point(0, 152);
            this.lblsplit1.Margin = new System.Windows.Forms.Padding(0);
            this.lblsplit1.Name = "lblsplit1";
            this.lblsplit1.Size = new System.Drawing.Size(103, 4);
            this.lblsplit1.TabIndex = 20;
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachineNo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblMachineNo.Location = new System.Drawing.Point(106, 38);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(364, 38);
            this.lblMachineNo.TabIndex = 7;
            this.lblMachineNo.Text = "C";
            this.lblMachineNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleMachineNo
            // 
            this.lblTitleMachineNo.AutoSize = true;
            this.lblTitleMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleMachineNo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleMachineNo.Location = new System.Drawing.Point(3, 42);
            this.lblTitleMachineNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleMachineNo.Name = "lblTitleMachineNo";
            this.lblTitleMachineNo.Size = new System.Drawing.Size(97, 30);
            this.lblTitleMachineNo.TabIndex = 0;
            this.lblTitleMachineNo.Text = "機台號碼:";
            this.lblTitleMachineNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleUID
            // 
            this.lblTitleUID.AutoSize = true;
            this.lblTitleUID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleUID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleUID.Location = new System.Drawing.Point(3, 80);
            this.lblTitleUID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleUID.Name = "lblTitleUID";
            this.lblTitleUID.Size = new System.Drawing.Size(97, 30);
            this.lblTitleUID.TabIndex = 1;
            this.lblTitleUID.Text = "操作者代號:";
            this.lblTitleUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleUserName
            // 
            this.lblTitleUserName.AutoSize = true;
            this.lblTitleUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleUserName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleUserName.Location = new System.Drawing.Point(3, 118);
            this.lblTitleUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleUserName.Name = "lblTitleUserName";
            this.lblTitleUserName.Size = new System.Drawing.Size(97, 30);
            this.lblTitleUserName.TabIndex = 2;
            this.lblTitleUserName.Text = "操作者姓名:";
            this.lblTitleUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitlePN
            // 
            this.lblTitlePN.AutoSize = true;
            this.lblTitlePN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlePN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitlePN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitlePN.Location = new System.Drawing.Point(3, 160);
            this.lblTitlePN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitlePN.Name = "lblTitlePN";
            this.lblTitlePN.Size = new System.Drawing.Size(97, 30);
            this.lblTitlePN.TabIndex = 3;
            this.lblTitlePN.Text = "友永件號:";
            this.lblTitlePN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleCarName
            // 
            this.lblTitleCarName.AutoSize = true;
            this.lblTitleCarName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleCarName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleCarName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleCarName.Location = new System.Drawing.Point(3, 198);
            this.lblTitleCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleCarName.Name = "lblTitleCarName";
            this.lblTitleCarName.Size = new System.Drawing.Size(97, 30);
            this.lblTitleCarName.TabIndex = 4;
            this.lblTitleCarName.Text = "車型名稱:";
            this.lblTitleCarName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(106, 80);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(364, 30);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "999";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Location = new System.Drawing.Point(106, 118);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(364, 30);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "測試員";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleTime
            // 
            this.lblTitleTime.AutoSize = true;
            this.lblTitleTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleTime.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleTime.Location = new System.Drawing.Point(3, 4);
            this.lblTitleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleTime.Name = "lblTitleTime";
            this.lblTitleTime.Size = new System.Drawing.Size(97, 30);
            this.lblTitleTime.TabIndex = 16;
            this.lblTitleTime.Text = "生產時間:";
            this.lblTitleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Tomato;
            this.lblTime.Location = new System.Drawing.Point(108, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(360, 38);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "2019/05/27 下午 04:07:01";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsplit2
            // 
            this.lblsplit2.AutoSize = true;
            this.lblsplit2.BackColor = System.Drawing.Color.DarkGray;
            this.lblsplit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsplit2.Location = new System.Drawing.Point(103, 152);
            this.lblsplit2.Margin = new System.Windows.Forms.Padding(0);
            this.lblsplit2.Name = "lblsplit2";
            this.lblsplit2.Size = new System.Drawing.Size(370, 4);
            this.lblsplit2.TabIndex = 19;
            // 
            // tlpPN
            // 
            this.tlpPN.ColumnCount = 2;
            this.tlpPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPN.Controls.Add(this.tbPN, 0, 0);
            this.tlpPN.Controls.Add(this.btnPN, 1, 0);
            this.tlpPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPN.Location = new System.Drawing.Point(103, 156);
            this.tlpPN.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPN.Name = "tlpPN";
            this.tlpPN.RowCount = 1;
            this.tlpPN.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPN.Size = new System.Drawing.Size(370, 38);
            this.tlpPN.TabIndex = 21;
            // 
            // tbPN
            // 
            this.tbPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPN.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPN.Location = new System.Drawing.Point(3, 6);
            this.tbPN.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPN.MaxLength = 64;
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(324, 24);
            this.tbPN.TabIndex = 10;
            this.tbPN.Text = "請輸入或搜尋件號";
            this.tbPN.TextChanged += new System.EventHandler(this.TbPN_TextChanged);
            this.tbPN.Enter += new System.EventHandler(this.TbPN_Enter);
            this.tbPN.Leave += new System.EventHandler(this.TbPN_Leave);
            // 
            // btnPN
            // 
            this.btnPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPN.Location = new System.Drawing.Point(333, 4);
            this.btnPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(34, 30);
            this.btnPN.TabIndex = 11;
            this.btnPN.Text = "...";
            this.btnPN.UseVisualStyleBackColor = true;
            this.btnPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPN_MouseUp);
            // 
            // tbCarName
            // 
            this.tbCarName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCarName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbCarName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCarName.Location = new System.Drawing.Point(106, 200);
            this.tbCarName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbCarName.MaxLength = 64;
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.ReadOnly = true;
            this.tbCarName.Size = new System.Drawing.Size(364, 24);
            this.tbCarName.TabIndex = 26;
            // 
            // lblTitleSerial
            // 
            this.lblTitleSerial.AutoSize = true;
            this.lblTitleSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleSerial.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleSerial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleSerial.Location = new System.Drawing.Point(3, 274);
            this.lblTitleSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleSerial.Name = "lblTitleSerial";
            this.lblTitleSerial.Size = new System.Drawing.Size(97, 30);
            this.lblTitleSerial.TabIndex = 5;
            this.lblTitleSerial.Text = "流水編號:";
            this.lblTitleSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSerial
            // 
            this.tbSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSerial.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbSerial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSerial.Location = new System.Drawing.Point(106, 276);
            this.tbSerial.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbSerial.MaxLength = 64;
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.ReadOnly = true;
            this.tbSerial.Size = new System.Drawing.Size(364, 24);
            this.tbSerial.TabIndex = 27;
            // 
            // lblTitleCode
            // 
            this.lblTitleCode.AutoSize = true;
            this.lblTitleCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleCode.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleCode.Location = new System.Drawing.Point(3, 236);
            this.lblTitleCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleCode.Name = "lblTitleCode";
            this.lblTitleCode.Size = new System.Drawing.Size(97, 30);
            this.lblTitleCode.TabIndex = 28;
            this.lblTitleCode.Text = "簡碼:";
            this.lblTitleCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCode
            // 
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCode.Location = new System.Drawing.Point(106, 238);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbCode.MaxLength = 64;
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(364, 24);
            this.tbCode.TabIndex = 29;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.lblsplit4, 0, 2);
            this.tlpRight.Controls.Add(this.lblTitleResult, 0, 0);
            this.tlpRight.Controls.Add(this.pbResult, 0, 1);
            this.tlpRight.Controls.Add(this.tlpBtn, 0, 3);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(485, 4);
            this.tlpRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 4;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(200, 321);
            this.tlpRight.TabIndex = 21;
            // 
            // lblsplit4
            // 
            this.lblsplit4.AutoSize = true;
            this.lblsplit4.BackColor = System.Drawing.Color.DarkGray;
            this.lblsplit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsplit4.Location = new System.Drawing.Point(0, 142);
            this.lblsplit4.Margin = new System.Windows.Forms.Padding(0);
            this.lblsplit4.Name = "lblsplit4";
            this.lblsplit4.Size = new System.Drawing.Size(200, 4);
            this.lblsplit4.TabIndex = 27;
            // 
            // lblTitleResult
            // 
            this.lblTitleResult.AutoSize = true;
            this.lblTitleResult.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleResult.Location = new System.Drawing.Point(3, 4);
            this.lblTitleResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitleResult.Name = "lblTitleResult";
            this.lblTitleResult.Size = new System.Drawing.Size(80, 18);
            this.lblTitleResult.TabIndex = 6;
            this.lblTitleResult.Text = "測試結果:";
            // 
            // pbResult
            // 
            this.pbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbResult.Location = new System.Drawing.Point(3, 30);
            this.pbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(101, 108);
            this.pbResult.TabIndex = 18;
            this.pbResult.TabStop = false;
            // 
            // tlpBtn
            // 
            this.tlpBtn.ColumnCount = 2;
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.Controls.Add(this.btnLD, 0, 1);
            this.tlpBtn.Controls.Add(this.btnLU, 0, 0);
            this.tlpBtn.Controls.Add(this.btnRU, 1, 0);
            this.tlpBtn.Controls.Add(this.btnRD, 1, 1);
            this.tlpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBtn.Location = new System.Drawing.Point(3, 150);
            this.tlpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpBtn.Name = "tlpBtn";
            this.tlpBtn.RowCount = 2;
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBtn.Size = new System.Drawing.Size(194, 167);
            this.tlpBtn.TabIndex = 26;
            // 
            // btnLD
            // 
            this.btnLD.BackColor = System.Drawing.Color.Gold;
            this.btnLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLD.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLD.Location = new System.Drawing.Point(7, 91);
            this.btnLD.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(83, 68);
            this.btnLD.TabIndex = 3;
            this.btnLD.Text = "補印標籤";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Visible = false;
            this.btnLD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLD_MouseUp);
            // 
            // btnLU
            // 
            this.btnLU.BackColor = System.Drawing.Color.Gold;
            this.btnLU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLU.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLU.Location = new System.Drawing.Point(7, 8);
            this.btnLU.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(83, 67);
            this.btnLU.TabIndex = 0;
            this.btnLU.Text = "列印OK";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Visible = false;
            this.btnLU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLU_MouseUp);
            // 
            // btnRU
            // 
            this.btnRU.BackColor = System.Drawing.Color.Gold;
            this.btnRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRU.Font = new System.Drawing.Font("Arial", 11F);
            this.btnRU.Location = new System.Drawing.Point(104, 8);
            this.btnRU.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnRU.Name = "btnRU";
            this.btnRU.Size = new System.Drawing.Size(83, 67);
            this.btnRU.TabIndex = 4;
            this.btnRU.Text = "列印NG";
            this.btnRU.UseVisualStyleBackColor = true;
            this.btnRU.Visible = false;
            this.btnRU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRU_MouseUp);
            // 
            // btnRD
            // 
            this.btnRD.BackColor = System.Drawing.Color.Gold;
            this.btnRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRD.Font = new System.Drawing.Font("Arial", 11F);
            this.btnRD.Location = new System.Drawing.Point(104, 91);
            this.btnRD.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(83, 68);
            this.btnRD.TabIndex = 5;
            this.btnRD.Text = "清除件號";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRD_MouseUp);
            // 
            // timerNow
            // 
            this.timerNow.Enabled = true;
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.TimerNow_Tick);
            // 
            // PageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PageTest";
            this.Size = new System.Drawing.Size(688, 329);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            this.tlpPN.ResumeLayout(false);
            this.tlpPN.PerformLayout();
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.tlpBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblsplit3;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.Label lblsplit1;
        private System.Windows.Forms.Label lblMachineNo;
        private System.Windows.Forms.Label lblTitleMachineNo;
        private System.Windows.Forms.Label lblTitleUID;
        private System.Windows.Forms.Label lblTitleUserName;
        private System.Windows.Forms.Label lblTitlePN;
        private System.Windows.Forms.Label lblTitleCarName;
        private System.Windows.Forms.Label lblTitleSerial;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTitleTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblsplit2;
        private System.Windows.Forms.TableLayoutPanel tlpPN;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.Button btnPN;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Label lblsplit4;
        private System.Windows.Forms.Label lblTitleResult;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.TableLayoutPanel tlpBtn;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Button btnRU;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label lblTitleCode;
        private System.Windows.Forms.TextBox tbCode;
    }
}
