using LPS.Model.Device;

namespace LPS.View.Forms
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
            DevCtrl.Instance.CH340ConnectChange -= this.TestDeviceConnectState;
            DevCtrl.Instance.TestResult -= this.TestResult;

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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.ptMain = new LPS.View.Pages.PageTest();
            this.tabPrinter = new System.Windows.Forms.TabPage();
            this.ptPrint = new LPS.View.Pages.PageTest();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pnlSettingSplit = new System.Windows.Forms.Panel();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.ssButtom = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain.SuspendLayout();
            this.tabTest.SuspendLayout();
            this.tabPrinter.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.ssButtom.SuspendLayout();
            this.tlpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabTest);
            this.tabMain.Controls.Add(this.tabPrinter);
            this.tabMain.Controls.Add(this.tabSetting);
            this.tabMain.Controls.Add(this.tabHelp);
            this.tabMain.Controls.Add(this.tabLogout);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tabMain.ItemSize = new System.Drawing.Size(80, 40);
            this.tabMain.Location = new System.Drawing.Point(3, 4);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(728, 380);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            // 
            // tabTest
            // 
            this.tabTest.BackColor = System.Drawing.SystemColors.Control;
            this.tabTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTest.Controls.Add(this.ptMain);
            this.tabTest.Location = new System.Drawing.Point(4, 44);
            this.tabTest.Margin = new System.Windows.Forms.Padding(0);
            this.tabTest.Name = "tabTest";
            this.tabTest.Size = new System.Drawing.Size(720, 332);
            this.tabTest.TabIndex = 0;
            this.tabTest.Text = "作業平台";
            // 
            // ptMain
            // 
            this.ptMain.AutoSize = true;
            this.ptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptMain.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptMain.Location = new System.Drawing.Point(0, 0);
            this.ptMain.Name = "ptMain";
            this.ptMain.Size = new System.Drawing.Size(718, 330);
            this.ptMain.TabIndex = 0;
            // 
            // tabPrinter
            // 
            this.tabPrinter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPrinter.Controls.Add(this.ptPrint);
            this.tabPrinter.Location = new System.Drawing.Point(4, 44);
            this.tabPrinter.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrinter.Name = "tabPrinter";
            this.tabPrinter.Size = new System.Drawing.Size(720, 332);
            this.tabPrinter.TabIndex = 1;
            this.tabPrinter.Text = "補印標籤";
            this.tabPrinter.UseVisualStyleBackColor = true;
            // 
            // ptPrint
            // 
            this.ptPrint.AutoSize = true;
            this.ptPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptPrint.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptPrint.Location = new System.Drawing.Point(0, 0);
            this.ptPrint.Name = "ptPrint";
            this.ptPrint.Size = new System.Drawing.Size(718, 330);
            this.ptPrint.TabIndex = 0;
            // 
            // tabSetting
            // 
            this.tabSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSetting.Controls.Add(this.tableLayoutPanel1);
            this.tabSetting.Location = new System.Drawing.Point(4, 44);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(720, 332);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "設定";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSettingSplit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioButton5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButton4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButton3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 322);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Orange;
            this.radioButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Location = new System.Drawing.Point(3, 260);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(146, 58);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.Text = "測試結果報表";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Orange;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Location = new System.Drawing.Point(3, 196);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(146, 56);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "資訊備份位置";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Orange;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(3, 132);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(146, 56);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "操作者代號";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Orange;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(3, 68);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 56);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "車型代號";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Orange;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(3, 4);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 56);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "機台資訊";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // pnlSettingSplit
            // 
            this.pnlSettingSplit.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSettingSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingSplit.Location = new System.Drawing.Point(158, 0);
            this.pnlSettingSplit.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSettingSplit.Name = "pnlSettingSplit";
            this.pnlSettingSplit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlSettingSplit.Size = new System.Drawing.Size(2, 330);
            this.pnlSettingSplit.TabIndex = 3;
            // 
            // tabHelp
            // 
            this.tabHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHelp.Controls.Add(this.label30);
            this.tabHelp.Location = new System.Drawing.Point(4, 44);
            this.tabHelp.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(720, 332);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "幫助";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("新細明體", 16F);
            this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Location = new System.Drawing.Point(100, 127);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(527, 88);
            this.label30.TabIndex = 5;
            this.label30.Text = "預計設計功能如下:\r\n1.顯示MYP聯絡資訊\r\n2.顯示LPS軟體版本資訊，若為試用版會顯示剩餘天數.\r\n3.顯示/輸入LPS軟體序號資訊";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabLogout
            // 
            this.tabLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLogout.Location = new System.Drawing.Point(4, 44);
            this.tabLogout.Margin = new System.Windows.Forms.Padding(0);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(720, 332);
            this.tabLogout.TabIndex = 4;
            this.tabLogout.Text = "登出";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // ssButtom
            // 
            this.ssButtom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.ssButtom.Location = new System.Drawing.Point(0, 388);
            this.ssButtom.Name = "ssButtom";
            this.ssButtom.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssButtom.Size = new System.Drawing.Size(734, 24);
            this.ssButtom.TabIndex = 1;
            this.ssButtom.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(185, 19);
            this.tsStatus.Text = "測試設備連接狀態 : 未連線";
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Controls.Add(this.tabMain, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tlpBase.Size = new System.Drawing.Size(734, 388);
            this.tlpBase.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.tlpBase);
            this.Controls.Add(this.ssButtom);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FormMain";
            this.Text = "作業平台";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.tabPrinter.ResumeLayout(false);
            this.tabPrinter.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.ssButtom.ResumeLayout(false);
            this.ssButtom.PerformLayout();
            this.tlpBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.TabPage tabPrinter;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.StatusStrip ssButtom;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel pnlSettingSplit;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private Pages.PageTest ptMain;
        private Pages.PageTest ptPrint;
        private System.Windows.Forms.TabPage tabLogout;
    }
}