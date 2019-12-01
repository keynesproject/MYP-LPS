namespace LPS.View.Pages
{
    partial class PagePrinterSetting
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
            this.lblTitleBackup = new System.Windows.Forms.Label();
            this.pnlLine2_2 = new System.Windows.Forms.Label();
            this.pnlLine2_1 = new System.Windows.Forms.Label();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.tlpBase.SuspendLayout();
            this.tlpSetting.SuspendLayout();
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
            this.tlpBase.TabIndex = 2;
            // 
            // tlpSetting
            // 
            this.tlpSetting.AutoSize = true;
            this.tlpSetting.ColumnCount = 2;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.Controls.Add(this.lblTitleBackup, 0, 0);
            this.tlpSetting.Controls.Add(this.pnlLine2_2, 1, 1);
            this.tlpSetting.Controls.Add(this.pnlLine2_1, 0, 1);
            this.tlpSetting.Controls.Add(this.cbPrinter, 1, 0);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tlpSetting.Location = new System.Drawing.Point(3, 68);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 3;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.Size = new System.Drawing.Size(759, 319);
            this.tlpSetting.TabIndex = 8;
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
            this.lblTitleBackup.Size = new System.Drawing.Size(131, 26);
            this.lblTitleBackup.TabIndex = 16;
            this.lblTitleBackup.Text = "標籤印表機設定:";
            this.lblTitleBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine2_2
            // 
            this.pnlLine2_2.AutoSize = true;
            this.pnlLine2_2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2_2.Location = new System.Drawing.Point(137, 34);
            this.pnlLine2_2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine2_2.Name = "pnlLine2_2";
            this.pnlLine2_2.Size = new System.Drawing.Size(622, 4);
            this.pnlLine2_2.TabIndex = 33;
            this.pnlLine2_2.Text = "           ";
            // 
            // pnlLine2_1
            // 
            this.pnlLine2_1.AutoSize = true;
            this.pnlLine2_1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2_1.Location = new System.Drawing.Point(0, 34);
            this.pnlLine2_1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLine2_1.Name = "pnlLine2_1";
            this.pnlLine2_1.Size = new System.Drawing.Size(137, 4);
            this.pnlLine2_1.TabIndex = 34;
            this.pnlLine2_1.Text = "           ";
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 4;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.Controls.Add(this.btnSave, 1, 0);
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
            // cbPrinter
            // 
            this.cbPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrinter.Font = new System.Drawing.Font("Arial", 11F);
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(140, 6);
            this.cbPrinter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(616, 25);
            this.cbPrinter.TabIndex = 35;
            // 
            // PagePrinterSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpBase);
            this.Name = "PagePrinterSetting";
            this.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblTitleBackup;
        private System.Windows.Forms.Label pnlLine2_2;
        private System.Windows.Forms.Label pnlLine2_1;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.ComboBox cbPrinter;
    }
}
