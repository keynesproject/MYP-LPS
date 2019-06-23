namespace LPS.View.Pages
{
    partial class PageReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPageCheange = new System.Windows.Forms.TableLayoutPanel();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.btnArrowFirst = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLast = new System.Windows.Forms.Button();
            this.tlpSearchDateBase = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpDateSearch = new System.Windows.Forms.TableLayoutPanel();
            this.pbDateToClear = new System.Windows.Forms.PictureBox();
            this.pbDateFromClear = new System.Windows.Forms.PictureBox();
            this.llbSearchEnd = new System.Windows.Forms.LinkLabel();
            this.lblDotSearchStart = new System.Windows.Forms.Label();
            this.lblDotSearchEnd = new System.Windows.Forms.Label();
            this.llbSearchStart = new System.Windows.Forms.LinkLabel();
            this.tbSearchDateFrom = new System.Windows.Forms.TextBox();
            this.tbSearchDateTo = new System.Windows.Forms.TextBox();
            this.dgvPagingHistory = new System.Windows.Forms.DataGridView();
            this.ColumnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar = new MonthCalendar.Calendar();
            this.tlpBase.SuspendLayout();
            this.tlpPageCheange.SuspendLayout();
            this.tlpSearchDateBase.SuspendLayout();
            this.tlpDateSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateToClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateFromClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpPageCheange, 0, 2);
            this.tlpBase.Controls.Add(this.tlpSearchDateBase, 0, 0);
            this.tlpBase.Controls.Add(this.dgvPagingHistory, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.TabIndex = 5;
            // 
            // tlpPageCheange
            // 
            this.tlpPageCheange.ColumnCount = 8;
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPageCheange.Controls.Add(this.tbCurrentPage, 3, 0);
            this.tlpPageCheange.Controls.Add(this.lblTotalPage, 4, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowFirst, 1, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowLeft, 2, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowRight, 5, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowLast, 6, 0);
            this.tlpPageCheange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPageCheange.Location = new System.Drawing.Point(3, 364);
            this.tlpPageCheange.Name = "tlpPageCheange";
            this.tlpPageCheange.RowCount = 1;
            this.tlpPageCheange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPageCheange.Size = new System.Drawing.Size(759, 24);
            this.tlpPageCheange.TabIndex = 4;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentPage.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCurrentPage.Location = new System.Drawing.Point(319, 0);
            this.tbCurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurrentPage.MaxLength = 3;
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.ShortcutsEnabled = false;
            this.tbCurrentPage.Size = new System.Drawing.Size(50, 26);
            this.tbCurrentPage.TabIndex = 2;
            this.tbCurrentPage.Text = "1";
            this.tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPage.WordWrap = false;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPage.Location = new System.Drawing.Point(372, 0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(64, 24);
            this.lblTotalPage.TabIndex = 5;
            this.lblTotalPage.Text = "of  1";
            this.lblTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArrowFirst
            // 
            this.btnArrowFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowFirst.Location = new System.Drawing.Point(249, 0);
            this.btnArrowFirst.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnArrowFirst.Name = "btnArrowFirst";
            this.btnArrowFirst.Size = new System.Drawing.Size(30, 24);
            this.btnArrowFirst.TabIndex = 0;
            this.btnArrowFirst.Text = "|<";
            this.btnArrowFirst.UseVisualStyleBackColor = true;
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowLeft.Location = new System.Drawing.Point(284, 0);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(30, 24);
            this.btnArrowLeft.TabIndex = 1;
            this.btnArrowLeft.Text = "<";
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowRight.Location = new System.Drawing.Point(444, 0);
            this.btnArrowRight.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(30, 24);
            this.btnArrowRight.TabIndex = 3;
            this.btnArrowRight.Text = ">";
            this.btnArrowRight.UseVisualStyleBackColor = true;
            // 
            // btnArrowLast
            // 
            this.btnArrowLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowLast.Location = new System.Drawing.Point(479, 0);
            this.btnArrowLast.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnArrowLast.Name = "btnArrowLast";
            this.btnArrowLast.Size = new System.Drawing.Size(30, 24);
            this.btnArrowLast.TabIndex = 4;
            this.btnArrowLast.Text = ">|";
            this.btnArrowLast.UseVisualStyleBackColor = true;
            // 
            // tlpSearchDateBase
            // 
            this.tlpSearchDateBase.ColumnCount = 4;
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDateBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchDateBase.Controls.Add(this.button1, 0, 0);
            this.tlpSearchDateBase.Controls.Add(this.btnAdd, 0, 0);
            this.tlpSearchDateBase.Controls.Add(this.tlpDateSearch, 0, 0);
            this.tlpSearchDateBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchDateBase.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchDateBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchDateBase.Name = "tlpSearchDateBase";
            this.tlpSearchDateBase.RowCount = 1;
            this.tlpSearchDateBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchDateBase.Size = new System.Drawing.Size(765, 80);
            this.tlpSearchDateBase.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.Location = new System.Drawing.Point(569, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "匯出報表";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.Location = new System.Drawing.Point(479, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 72);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "  搜    尋  ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tlpDateSearch
            // 
            this.tlpDateSearch.AutoSize = true;
            this.tlpDateSearch.ColumnCount = 4;
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDateSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpDateSearch.Controls.Add(this.pbDateToClear, 3, 1);
            this.tlpDateSearch.Controls.Add(this.pbDateFromClear, 3, 0);
            this.tlpDateSearch.Controls.Add(this.llbSearchEnd, 1, 1);
            this.tlpDateSearch.Controls.Add(this.lblDotSearchStart, 0, 0);
            this.tlpDateSearch.Controls.Add(this.lblDotSearchEnd, 0, 1);
            this.tlpDateSearch.Controls.Add(this.llbSearchStart, 1, 0);
            this.tlpDateSearch.Controls.Add(this.tbSearchDateFrom, 2, 0);
            this.tlpDateSearch.Controls.Add(this.tbSearchDateTo, 2, 1);
            this.tlpDateSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDateSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpDateSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDateSearch.Name = "tlpDateSearch";
            this.tlpDateSearch.RowCount = 2;
            this.tlpDateSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDateSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDateSearch.Size = new System.Drawing.Size(475, 80);
            this.tlpDateSearch.TabIndex = 0;
            // 
            // pbDateToClear
            // 
            this.pbDateToClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbDateToClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDateToClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDateToClear.Image = global::LPS.Properties.Resources.ModifyIconCross;
            this.pbDateToClear.Location = new System.Drawing.Point(453, 45);
            this.pbDateToClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbDateToClear.Name = "pbDateToClear";
            this.pbDateToClear.Size = new System.Drawing.Size(19, 30);
            this.pbDateToClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateToClear.TabIndex = 181;
            this.pbDateToClear.TabStop = false;
            this.pbDateToClear.Tag = "+";
            this.pbDateToClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDateToClear_MouseDown);
            this.pbDateToClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDateToClear_MouseUp);
            // 
            // pbDateFromClear
            // 
            this.pbDateFromClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbDateFromClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDateFromClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDateFromClear.Image = global::LPS.Properties.Resources.ModifyIconCross;
            this.pbDateFromClear.Location = new System.Drawing.Point(453, 5);
            this.pbDateFromClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbDateFromClear.Name = "pbDateFromClear";
            this.pbDateFromClear.Size = new System.Drawing.Size(19, 30);
            this.pbDateFromClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateFromClear.TabIndex = 180;
            this.pbDateFromClear.TabStop = false;
            this.pbDateFromClear.Tag = "+";
            this.pbDateFromClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDateFromClear_MouseDown);
            this.pbDateFromClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDateFromClear_MouseUp);
            // 
            // llbSearchEnd
            // 
            this.llbSearchEnd.AutoSize = true;
            this.llbSearchEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbSearchEnd.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.llbSearchEnd.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbSearchEnd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbSearchEnd.LinkColor = System.Drawing.Color.Black;
            this.llbSearchEnd.Location = new System.Drawing.Point(23, 43);
            this.llbSearchEnd.Margin = new System.Windows.Forms.Padding(3);
            this.llbSearchEnd.Name = "llbSearchEnd";
            this.llbSearchEnd.Size = new System.Drawing.Size(185, 34);
            this.llbSearchEnd.TabIndex = 0;
            this.llbSearchEnd.Text = "結束日期 (西元年-月-日)";
            this.llbSearchEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotSearchStart
            // 
            this.lblDotSearchStart.AutoSize = true;
            this.lblDotSearchStart.BackColor = System.Drawing.Color.Transparent;
            this.lblDotSearchStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotSearchStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotSearchStart.ForeColor = System.Drawing.Color.Black;
            this.lblDotSearchStart.Location = new System.Drawing.Point(3, 0);
            this.lblDotSearchStart.Name = "lblDotSearchStart";
            this.lblDotSearchStart.Size = new System.Drawing.Size(14, 40);
            this.lblDotSearchStart.TabIndex = 0;
            this.lblDotSearchStart.Text = "˙";
            this.lblDotSearchStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotSearchEnd
            // 
            this.lblDotSearchEnd.AutoSize = true;
            this.lblDotSearchEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblDotSearchEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotSearchEnd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotSearchEnd.ForeColor = System.Drawing.Color.Black;
            this.lblDotSearchEnd.Location = new System.Drawing.Point(3, 40);
            this.lblDotSearchEnd.Name = "lblDotSearchEnd";
            this.lblDotSearchEnd.Size = new System.Drawing.Size(14, 40);
            this.lblDotSearchEnd.TabIndex = 0;
            this.lblDotSearchEnd.Text = "˙";
            this.lblDotSearchEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llbSearchStart
            // 
            this.llbSearchStart.AutoSize = true;
            this.llbSearchStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbSearchStart.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.llbSearchStart.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.llbSearchStart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbSearchStart.LinkColor = System.Drawing.Color.Black;
            this.llbSearchStart.Location = new System.Drawing.Point(23, 3);
            this.llbSearchStart.Margin = new System.Windows.Forms.Padding(3);
            this.llbSearchStart.Name = "llbSearchStart";
            this.llbSearchStart.Size = new System.Drawing.Size(185, 34);
            this.llbSearchStart.TabIndex = 0;
            this.llbSearchStart.Text = "起始日期 (西元年-月-日)";
            this.llbSearchStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearchDateFrom
            // 
            this.tbSearchDateFrom.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearchDateFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSearchDateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchDateFrom.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSearchDateFrom.Location = new System.Drawing.Point(214, 8);
            this.tbSearchDateFrom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchDateFrom.MaxLength = 64;
            this.tbSearchDateFrom.Name = "tbSearchDateFrom";
            this.tbSearchDateFrom.ReadOnly = true;
            this.tbSearchDateFrom.Size = new System.Drawing.Size(233, 25);
            this.tbSearchDateFrom.TabIndex = 1;
            this.tbSearchDateFrom.TabStop = false;
            this.tbSearchDateFrom.Click += new System.EventHandler(this.TbSearchDateFrom_Click);
            // 
            // tbSearchDateTo
            // 
            this.tbSearchDateTo.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearchDateTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSearchDateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchDateTo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSearchDateTo.Location = new System.Drawing.Point(214, 48);
            this.tbSearchDateTo.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchDateTo.MaxLength = 64;
            this.tbSearchDateTo.Name = "tbSearchDateTo";
            this.tbSearchDateTo.ReadOnly = true;
            this.tbSearchDateTo.Size = new System.Drawing.Size(233, 25);
            this.tbSearchDateTo.TabIndex = 2;
            this.tbSearchDateTo.TabStop = false;
            this.tbSearchDateTo.Click += new System.EventHandler(this.TbSearchDateTo_Click);
            // 
            // dgvPagingHistory
            // 
            this.dgvPagingHistory.AllowUserToAddRows = false;
            this.dgvPagingHistory.AllowUserToDeleteRows = false;
            this.dgvPagingHistory.AllowUserToResizeRows = false;
            this.dgvPagingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagingHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSerial,
            this.ColumnDate,
            this.ColumnTime,
            this.ColumnCar,
            this.ColumnOP,
            this.ColumnResult});
            this.dgvPagingHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagingHistory.Location = new System.Drawing.Point(3, 83);
            this.dgvPagingHistory.MultiSelect = false;
            this.dgvPagingHistory.Name = "dgvPagingHistory";
            this.dgvPagingHistory.ReadOnly = true;
            this.dgvPagingHistory.RowHeadersVisible = false;
            this.dgvPagingHistory.RowTemplate.Height = 24;
            this.dgvPagingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagingHistory.Size = new System.Drawing.Size(759, 275);
            this.dgvPagingHistory.TabIndex = 7;
            this.dgvPagingHistory.TabStop = false;
            // 
            // ColumnSerial
            // 
            this.ColumnSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSerial.HeaderText = "流水號";
            this.ColumnSerial.MaxInputLength = 32;
            this.ColumnSerial.MinimumWidth = 100;
            this.ColumnSerial.Name = "ColumnSerial";
            this.ColumnSerial.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDate.HeaderText = "日期";
            this.ColumnDate.MaxInputLength = 32;
            this.ColumnDate.MinimumWidth = 100;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTime.HeaderText = "時間";
            this.ColumnTime.MaxInputLength = 32;
            this.ColumnTime.MinimumWidth = 100;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnCar
            // 
            this.ColumnCar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCar.HeaderText = "車型";
            this.ColumnCar.MaxInputLength = 32;
            this.ColumnCar.MinimumWidth = 100;
            this.ColumnCar.Name = "ColumnCar";
            this.ColumnCar.ReadOnly = true;
            // 
            // ColumnOP
            // 
            this.ColumnOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOP.HeaderText = "操作者代號";
            this.ColumnOP.MaxInputLength = 32;
            this.ColumnOP.MinimumWidth = 100;
            this.ColumnOP.Name = "ColumnOP";
            this.ColumnOP.ReadOnly = true;
            // 
            // ColumnResult
            // 
            this.ColumnResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnResult.HeaderText = "判定";
            this.ColumnResult.MaxInputLength = 32;
            this.ColumnResult.MinimumWidth = 100;
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(197)))));
            this.Calendar.Border.BorderColor = System.Drawing.Color.Black;
            this.Calendar.Border.Parent = this.Calendar;
            this.Calendar.Border.Transparency = 255;
            this.Calendar.Border.Visible = false;
            this.Calendar.CanSelectTrailingDates = true;
            this.Calendar.Culture = new System.Globalization.CultureInfo("");
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.Calendar.Footer.Align = MonthCalendar.HeaderAlign.Left;
            this.Calendar.Footer.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.Footer.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.Footer.Background.Parent = this.Calendar.Footer;
            this.Calendar.Footer.Background.StartColor = System.Drawing.Color.White;
            this.Calendar.Footer.Background.Style = MonthCalendar.EStyle.esParent;
            this.Calendar.Footer.Background.TransparencyEndColor = 255;
            this.Calendar.Footer.Background.TransparencyStartColor = 255;
            this.Calendar.Footer.Border.BorderColor = System.Drawing.Color.White;
            this.Calendar.Footer.Border.Parent = this.Calendar.Footer;
            this.Calendar.Footer.Border.Transparency = 255;
            this.Calendar.Footer.Border.Visible = false;
            this.Calendar.Footer.DateFormat = MonthCalendar.DateFormat.Long;
            this.Calendar.Footer.Font = new System.Drawing.Font("Arial", 9F);
            this.Calendar.Footer.ForeColor = System.Drawing.Color.Blue;
            this.Calendar.Footer.Padding = new System.Windows.Forms.Padding(5, 5, 20, 8);
            this.Calendar.Footer.Text = "";
            this.Calendar.Footer.TextTransparency = 255;
            this.Calendar.Footer.Visible = true;
            this.Calendar.Header.Align = MonthCalendar.HeaderAlign.Center;
            this.Calendar.Header.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.Header.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.Header.Background.Parent = this.Calendar.Header;
            this.Calendar.Header.Background.StartColor = System.Drawing.Color.Empty;
            this.Calendar.Header.Background.Style = MonthCalendar.EStyle.esTransparent;
            this.Calendar.Header.Background.TransparencyEndColor = 255;
            this.Calendar.Header.Background.TransparencyStartColor = 255;
            this.Calendar.Header.Border.BorderColor = System.Drawing.Color.Black;
            this.Calendar.Header.Border.Parent = this.Calendar.Header;
            this.Calendar.Header.Border.Transparency = 255;
            this.Calendar.Header.Border.Visible = true;
            this.Calendar.Header.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Calendar.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(133)))), ((int)(((byte)(167)))));
            this.Calendar.Header.HoverColor = System.Drawing.Color.DarkGray;
            this.Calendar.Header.Padding.Horizontal = 10;
            this.Calendar.Header.Padding.Vertical = 6;
            this.Calendar.Header.ShowNav = true;
            this.Calendar.Header.TextTransparency = 255;
            this.Calendar.Header.Visible = true;
            this.Calendar.ImageList = null;
            this.Calendar.Keyboard.AllowKeyboardSteering = true;
            this.Calendar.Keyboard.Down = System.Windows.Forms.Keys.Down;
            this.Calendar.Keyboard.GoToday = System.Windows.Forms.Keys.F12;
            this.Calendar.Keyboard.Left = System.Windows.Forms.Keys.Left;
            this.Calendar.Keyboard.MultipleSelection = MonthCalendar.ExtendedSelection.Ctrl;
            this.Calendar.Keyboard.NavNext = System.Windows.Forms.Keys.Insert;
            this.Calendar.Keyboard.NavPrev = System.Windows.Forms.Keys.Delete;
            this.Calendar.Keyboard.NextMonth = System.Windows.Forms.Keys.Home;
            this.Calendar.Keyboard.NextYear = System.Windows.Forms.Keys.PageUp;
            this.Calendar.Keyboard.PrevMonth = System.Windows.Forms.Keys.End;
            this.Calendar.Keyboard.PrevYear = System.Windows.Forms.Keys.Next;
            this.Calendar.Keyboard.Right = System.Windows.Forms.Keys.Right;
            this.Calendar.Keyboard.Select = System.Windows.Forms.Keys.Space;
            this.Calendar.Keyboard.Up = System.Windows.Forms.Keys.Up;
            this.Calendar.Keyboard.Zoomin = System.Windows.Forms.Keys.Subtract;
            this.Calendar.Keyboard.ZoomOut = System.Windows.Forms.Keys.Add;
            this.Calendar.Location = new System.Drawing.Point(188, 36);
            this.Calendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2018, 3, 1, 0, 0, 0, 0);
            this.Calendar.MonthDays.Align = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calendar.MonthDays.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.MonthDays.Background.Parent = this.Calendar.MonthDays;
            this.Calendar.MonthDays.Background.StartColor = System.Drawing.Color.White;
            this.Calendar.MonthDays.Background.Style = MonthCalendar.EStyle.esParent;
            this.Calendar.MonthDays.Background.TransparencyEndColor = 255;
            this.Calendar.MonthDays.Background.TransparencyStartColor = 255;
            this.Calendar.MonthDays.Border.BorderColor = System.Drawing.Color.Maroon;
            this.Calendar.MonthDays.Border.Parent = this.Calendar.MonthDays;
            this.Calendar.MonthDays.Border.Transparency = 255;
            this.Calendar.MonthDays.Border.Visible = true;
            this.Calendar.MonthDays.DaysPadding.Horizontal = 2;
            this.Calendar.MonthDays.DaysPadding.Vertical = 2;
            this.Calendar.MonthDays.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Calendar.MonthDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(133)))), ((int)(((byte)(167)))));
            this.Calendar.MonthDays.HoverStyle.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.HoverStyle.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.MonthDays.HoverStyle.Background.Parent = this.Calendar.MonthDays.HoverStyle;
            this.Calendar.MonthDays.HoverStyle.Background.StartColor = System.Drawing.Color.Blue;
            this.Calendar.MonthDays.HoverStyle.Background.Style = MonthCalendar.EStyle.esColor;
            this.Calendar.MonthDays.HoverStyle.Background.TransparencyEndColor = 0;
            this.Calendar.MonthDays.HoverStyle.Background.TransparencyStartColor = 0;
            this.Calendar.MonthDays.HoverStyle.Border.BorderColor = System.Drawing.Color.DarkBlue;
            this.Calendar.MonthDays.HoverStyle.Border.Parent = this.Calendar.MonthDays.HoverStyle;
            this.Calendar.MonthDays.HoverStyle.Border.Transparency = 128;
            this.Calendar.MonthDays.HoverStyle.Border.Visible = true;
            this.Calendar.MonthDays.MarkHover = true;
            this.Calendar.MonthDays.MarkSaturday = true;
            this.Calendar.MonthDays.MarkSelectedDay = true;
            this.Calendar.MonthDays.MarkSunday = true;
            this.Calendar.MonthDays.MarkToday = true;
            this.Calendar.MonthDays.Padding = new System.Windows.Forms.Padding(2);
            this.Calendar.MonthDays.SaturdayColor = System.Drawing.Color.LightCoral;
            this.Calendar.MonthDays.SelectedDay.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.SelectedDay.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.MonthDays.SelectedDay.Background.Parent = this.Calendar.MonthDays.SelectedDay;
            this.Calendar.MonthDays.SelectedDay.Background.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Calendar.MonthDays.SelectedDay.Background.Style = MonthCalendar.EStyle.esColor;
            this.Calendar.MonthDays.SelectedDay.Background.TransparencyEndColor = 255;
            this.Calendar.MonthDays.SelectedDay.Background.TransparencyStartColor = 255;
            this.Calendar.MonthDays.SelectedDay.Border.BorderColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.SelectedDay.Border.Parent = this.Calendar.MonthDays.SelectedDay;
            this.Calendar.MonthDays.SelectedDay.Border.Transparency = 255;
            this.Calendar.MonthDays.SelectedDay.Border.Visible = true;
            this.Calendar.MonthDays.SelectedDay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Calendar.MonthDays.SelectedDay.ForeColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.ShowTrailingDays = true;
            this.Calendar.MonthDays.SundayColor = System.Drawing.Color.Red;
            this.Calendar.MonthDays.TextTransparency = 255;
            this.Calendar.MonthDays.TodayColor = System.Drawing.Color.Blue;
            this.Calendar.MonthDays.TrailingDays.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.MonthDays.TrailingDays.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.MonthDays.TrailingDays.Background.Parent = this.Calendar.MonthDays.TrailingDays;
            this.Calendar.MonthDays.TrailingDays.Background.StartColor = System.Drawing.Color.White;
            this.Calendar.MonthDays.TrailingDays.Background.Style = MonthCalendar.EStyle.esParent;
            this.Calendar.MonthDays.TrailingDays.Background.TransparencyEndColor = 255;
            this.Calendar.MonthDays.TrailingDays.Background.TransparencyStartColor = 255;
            this.Calendar.MonthDays.TrailingDays.Border.BorderColor = System.Drawing.Color.White;
            this.Calendar.MonthDays.TrailingDays.Border.Parent = this.Calendar.MonthDays.TrailingDays;
            this.Calendar.MonthDays.TrailingDays.Border.Transparency = 255;
            this.Calendar.MonthDays.TrailingDays.Border.Visible = false;
            this.Calendar.MonthDays.TrailingDays.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Calendar.MonthDays.TrailingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Calendar.MonthImages.AprilImage = null;
            this.Calendar.MonthImages.AugustImage = null;
            this.Calendar.MonthImages.DecemberImage = null;
            this.Calendar.MonthImages.FebruaryImage = null;
            this.Calendar.MonthImages.ImagePosition = MonthCalendar.MonthImagePosition.Top;
            this.Calendar.MonthImages.ImagesHeight = 68;
            this.Calendar.MonthImages.JanuaryImage = null;
            this.Calendar.MonthImages.JulyImage = null;
            this.Calendar.MonthImages.JuneImage = null;
            this.Calendar.MonthImages.MarchImage = null;
            this.Calendar.MonthImages.MayImage = null;
            this.Calendar.MonthImages.NovemberImage = null;
            this.Calendar.MonthImages.OctoberImage = null;
            this.Calendar.MonthImages.SeptemberImage = null;
            this.Calendar.MonthImages.UseImages = false;
            this.Calendar.Name = "calendar1";
            this.Calendar.OnlyMonthMode = false;
            this.Calendar.SelectedDate = new System.DateTime(2018, 3, 19, 0, 0, 0, 0);
            this.Calendar.SelectionMode = MonthCalendar.SelectionMode.smOne;
            this.Calendar.Size = new System.Drawing.Size(389, 318);
            this.Calendar.StartWithZoom = MonthCalendar.ViewMode.vmMonth;
            this.Calendar.TabIndex = 8;
            this.Calendar.Visible = false;
            this.Calendar.WeekDays.Align = MonthCalendar.HeaderAlign.Center;
            this.Calendar.WeekDays.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.WeekDays.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.WeekDays.Background.Parent = this.Calendar.WeekDays;
            this.Calendar.WeekDays.Background.StartColor = System.Drawing.Color.White;
            this.Calendar.WeekDays.Background.Style = MonthCalendar.EStyle.esParent;
            this.Calendar.WeekDays.Background.TransparencyEndColor = 255;
            this.Calendar.WeekDays.Background.TransparencyStartColor = 255;
            this.Calendar.WeekDays.Border.BorderColor = System.Drawing.Color.Black;
            this.Calendar.WeekDays.Border.Parent = this.Calendar.WeekDays;
            this.Calendar.WeekDays.Border.Transparency = 255;
            this.Calendar.WeekDays.Border.Visible = true;
            this.Calendar.WeekDays.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.WeekDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(133)))), ((int)(((byte)(167)))));
            this.Calendar.WeekDays.TextTransparency = 255;
            this.Calendar.WeekDays.Visible = true;
            this.Calendar.Weeknumbers.Align = MonthCalendar.WeekNumberAlign.Center;
            this.Calendar.Weeknumbers.Background.EndColor = System.Drawing.Color.Black;
            this.Calendar.Weeknumbers.Background.Gradient = MonthCalendar.GradientStyle.Vertical;
            this.Calendar.Weeknumbers.Background.Parent = this.Calendar.Weeknumbers;
            this.Calendar.Weeknumbers.Background.StartColor = System.Drawing.Color.White;
            this.Calendar.Weeknumbers.Background.Style = MonthCalendar.EStyle.esParent;
            this.Calendar.Weeknumbers.Background.TransparencyEndColor = 255;
            this.Calendar.Weeknumbers.Background.TransparencyStartColor = 255;
            this.Calendar.Weeknumbers.Border.BorderColor = System.Drawing.Color.Black;
            this.Calendar.Weeknumbers.Border.Parent = this.Calendar.Weeknumbers;
            this.Calendar.Weeknumbers.Border.Transparency = 255;
            this.Calendar.Weeknumbers.Border.Visible = true;
            this.Calendar.Weeknumbers.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Calendar.Weeknumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Calendar.Weeknumbers.Padding = 5;
            this.Calendar.Weeknumbers.TextTransparency = 255;
            this.Calendar.Weeknumbers.Visible = false;
            this.Calendar.SelectDay += new MonthCalendar.SelectDayEventHandler(this.Calendar_SelectDay);
            // 
            // PageReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.tlpBase);
            this.Name = "PageReport";
            this.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.ResumeLayout(false);
            this.tlpPageCheange.ResumeLayout(false);
            this.tlpPageCheange.PerformLayout();
            this.tlpSearchDateBase.ResumeLayout(false);
            this.tlpSearchDateBase.PerformLayout();
            this.tlpDateSearch.ResumeLayout(false);
            this.tlpDateSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateToClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateFromClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagingHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpPageCheange;
        private System.Windows.Forms.TextBox tbCurrentPage;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Button btnArrowFirst;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowLast;
        private System.Windows.Forms.TableLayoutPanel tlpSearchDateBase;
        private System.Windows.Forms.TableLayoutPanel tlpDateSearch;
        private System.Windows.Forms.PictureBox pbDateToClear;
        private System.Windows.Forms.PictureBox pbDateFromClear;
        private System.Windows.Forms.LinkLabel llbSearchEnd;
        private System.Windows.Forms.Label lblDotSearchStart;
        private System.Windows.Forms.Label lblDotSearchEnd;
        private System.Windows.Forms.LinkLabel llbSearchStart;
        private System.Windows.Forms.TextBox tbSearchDateFrom;
        private System.Windows.Forms.TextBox tbSearchDateTo;
        private System.Windows.Forms.DataGridView dgvPagingHistory;
        private MonthCalendar.Calendar Calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
    }
}
