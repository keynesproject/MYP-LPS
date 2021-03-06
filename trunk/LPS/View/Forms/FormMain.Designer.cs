﻿using LPS.Model.DataAccessObject;
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
            ptMain.LastTestResultEvent -= this.LastTestResult;

            DevCtrl.Instance.CH340ConnectChange -= this.TestDeviceConnectState;
            DevCtrl.Instance.TestResult -= this.TestResult;
            Uart.Instance.UartConnectChange -= this.TestDeviceConnectState;
            Uart.Instance.TestResult -= this.TestResult;

            DaoSnControl.Instance.UpdateSnEvent -= this.SnUpdate;

            ptMain.CloseAppEvent -= this.CloseApp;
            ptPrint.CloseAppEvent -= this.CloseApp;

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
            this.tlpSettingBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSettingBtn = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnPrinter = new System.Windows.Forms.RadioButton();
            this.rbtnReport = new System.Windows.Forms.RadioButton();
            this.rbtnBackup = new System.Windows.Forms.RadioButton();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.rbtnMachine = new System.Windows.Forms.RadioButton();
            this.pnlSettingSplit = new System.Windows.Forms.Panel();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.pageHelp1 = new LPS.View.Pages.PageHelp();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.ssButtom = new System.Windows.Forms.StatusStrip();
            this.tsStatusBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.tsTestDeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tabMain.SuspendLayout();
            this.tabTest.SuspendLayout();
            this.tabPrinter.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tlpSettingBase.SuspendLayout();
            this.tlpSettingBtn.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(978, 530);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            this.tabMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabMain_Selecting);
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabMain_Selected);
            // 
            // tabTest
            // 
            this.tabTest.BackColor = System.Drawing.SystemColors.Control;
            this.tabTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTest.Controls.Add(this.ptMain);
            this.tabTest.Location = new System.Drawing.Point(4, 44);
            this.tabTest.Margin = new System.Windows.Forms.Padding(0);
            this.tabTest.Name = "tabTest";
            this.tabTest.Size = new System.Drawing.Size(970, 482);
            this.tabTest.TabIndex = 0;
            this.tabTest.Text = "作業平台";
            // 
            // ptMain
            // 
            this.ptMain.AutoSize = true;
            this.ptMain.BackColor = System.Drawing.SystemColors.Control;
            this.ptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptMain.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptMain.Location = new System.Drawing.Point(0, 0);
            this.ptMain.Name = "ptMain";
            this.ptMain.Size = new System.Drawing.Size(968, 480);
            this.ptMain.TabIndex = 0;
            // 
            // tabPrinter
            // 
            this.tabPrinter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPrinter.Controls.Add(this.ptPrint);
            this.tabPrinter.Location = new System.Drawing.Point(4, 44);
            this.tabPrinter.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrinter.Name = "tabPrinter";
            this.tabPrinter.Size = new System.Drawing.Size(970, 482);
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
            this.ptPrint.Size = new System.Drawing.Size(968, 480);
            this.ptPrint.TabIndex = 0;
            // 
            // tabSetting
            // 
            this.tabSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSetting.Controls.Add(this.tlpSettingBase);
            this.tabSetting.Location = new System.Drawing.Point(4, 44);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(970, 482);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "設定";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // tlpSettingBase
            // 
            this.tlpSettingBase.AutoSize = true;
            this.tlpSettingBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSettingBase.ColumnCount = 3;
            this.tlpSettingBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSettingBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSettingBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingBase.Controls.Add(this.tlpSettingBtn, 0, 0);
            this.tlpSettingBase.Controls.Add(this.pnlSettingSplit, 1, 0);
            this.tlpSettingBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettingBase.Location = new System.Drawing.Point(0, 0);
            this.tlpSettingBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSettingBase.Name = "tlpSettingBase";
            this.tlpSettingBase.RowCount = 1;
            this.tlpSettingBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingBase.Size = new System.Drawing.Size(968, 480);
            this.tlpSettingBase.TabIndex = 0;
            // 
            // tlpSettingBtn
            // 
            this.tlpSettingBtn.ColumnCount = 1;
            this.tlpSettingBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettingBtn.Controls.Add(this.rbtnPrinter, 0, 5);
            this.tlpSettingBtn.Controls.Add(this.rbtnReport, 0, 4);
            this.tlpSettingBtn.Controls.Add(this.rbtnBackup, 0, 3);
            this.tlpSettingBtn.Controls.Add(this.rbtnUser, 0, 2);
            this.tlpSettingBtn.Controls.Add(this.rbtnCar, 0, 1);
            this.tlpSettingBtn.Controls.Add(this.rbtnMachine, 0, 0);
            this.tlpSettingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSettingBtn.Location = new System.Drawing.Point(3, 4);
            this.tlpSettingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSettingBtn.Name = "tlpSettingBtn";
            this.tlpSettingBtn.RowCount = 6;
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpSettingBtn.Size = new System.Drawing.Size(152, 472);
            this.tlpSettingBtn.TabIndex = 2;
            // 
            // rbtnPrinter
            // 
            this.rbtnPrinter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPrinter.AutoSize = true;
            this.rbtnPrinter.BackColor = System.Drawing.Color.Orange;
            this.rbtnPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPrinter.Location = new System.Drawing.Point(3, 394);
            this.rbtnPrinter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnPrinter.Name = "rbtnPrinter";
            this.rbtnPrinter.Size = new System.Drawing.Size(146, 74);
            this.rbtnPrinter.TabIndex = 9;
            this.rbtnPrinter.Text = "印表機設定";
            this.rbtnPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnPrinter.UseVisualStyleBackColor = false;
            this.rbtnPrinter.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // rbtnReport
            // 
            this.rbtnReport.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnReport.AutoSize = true;
            this.rbtnReport.BackColor = System.Drawing.Color.Orange;
            this.rbtnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnReport.Location = new System.Drawing.Point(3, 316);
            this.rbtnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnReport.Name = "rbtnReport";
            this.rbtnReport.Size = new System.Drawing.Size(146, 70);
            this.rbtnReport.TabIndex = 8;
            this.rbtnReport.Text = "測試結果報表";
            this.rbtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnReport.UseVisualStyleBackColor = false;
            this.rbtnReport.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // rbtnBackup
            // 
            this.rbtnBackup.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnBackup.AutoSize = true;
            this.rbtnBackup.BackColor = System.Drawing.Color.Orange;
            this.rbtnBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnBackup.Location = new System.Drawing.Point(3, 238);
            this.rbtnBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnBackup.Name = "rbtnBackup";
            this.rbtnBackup.Size = new System.Drawing.Size(146, 70);
            this.rbtnBackup.TabIndex = 7;
            this.rbtnBackup.Text = "資訊備份位置";
            this.rbtnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnBackup.UseVisualStyleBackColor = false;
            this.rbtnBackup.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // rbtnUser
            // 
            this.rbtnUser.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.BackColor = System.Drawing.Color.Orange;
            this.rbtnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnUser.Location = new System.Drawing.Point(3, 160);
            this.rbtnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(146, 70);
            this.rbtnUser.TabIndex = 6;
            this.rbtnUser.Text = "操作者代號";
            this.rbtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnUser.UseVisualStyleBackColor = false;
            this.rbtnUser.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // rbtnCar
            // 
            this.rbtnCar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.BackColor = System.Drawing.Color.Orange;
            this.rbtnCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCar.Location = new System.Drawing.Point(3, 82);
            this.rbtnCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(146, 70);
            this.rbtnCar.TabIndex = 5;
            this.rbtnCar.Text = "車型代號";
            this.rbtnCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCar.UseVisualStyleBackColor = false;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // rbtnMachine
            // 
            this.rbtnMachine.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnMachine.AutoSize = true;
            this.rbtnMachine.BackColor = System.Drawing.Color.Orange;
            this.rbtnMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnMachine.Location = new System.Drawing.Point(3, 4);
            this.rbtnMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMachine.Name = "rbtnMachine";
            this.rbtnMachine.Size = new System.Drawing.Size(146, 70);
            this.rbtnMachine.TabIndex = 4;
            this.rbtnMachine.Text = "機台資訊";
            this.rbtnMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnMachine.UseVisualStyleBackColor = false;
            this.rbtnMachine.CheckedChanged += new System.EventHandler(this.Setting_CheckedChanged);
            // 
            // pnlSettingSplit
            // 
            this.pnlSettingSplit.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSettingSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingSplit.Location = new System.Drawing.Point(158, 0);
            this.pnlSettingSplit.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSettingSplit.Name = "pnlSettingSplit";
            this.pnlSettingSplit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlSettingSplit.Size = new System.Drawing.Size(2, 480);
            this.pnlSettingSplit.TabIndex = 3;
            // 
            // tabHelp
            // 
            this.tabHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHelp.Controls.Add(this.pageHelp1);
            this.tabHelp.Location = new System.Drawing.Point(4, 44);
            this.tabHelp.Margin = new System.Windows.Forms.Padding(0);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Size = new System.Drawing.Size(970, 482);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "幫助";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // pageHelp1
            // 
            this.pageHelp1.AutoSize = true;
            this.pageHelp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageHelp1.Location = new System.Drawing.Point(0, 0);
            this.pageHelp1.Margin = new System.Windows.Forms.Padding(4);
            this.pageHelp1.Name = "pageHelp1";
            this.pageHelp1.Size = new System.Drawing.Size(968, 480);
            this.pageHelp1.TabIndex = 0;
            // 
            // tabLogout
            // 
            this.tabLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLogout.Location = new System.Drawing.Point(4, 44);
            this.tabLogout.Margin = new System.Windows.Forms.Padding(0);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(970, 482);
            this.tabLogout.TabIndex = 4;
            this.tabLogout.Text = "登出";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // ssButtom
            // 
            this.ssButtom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusBtn,
            this.tsTestDeviceStatus});
            this.ssButtom.Location = new System.Drawing.Point(0, 538);
            this.ssButtom.Name = "ssButtom";
            this.ssButtom.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssButtom.Size = new System.Drawing.Size(984, 24);
            this.ssButtom.TabIndex = 1;
            this.ssButtom.Text = "statusStrip1";
            // 
            // tsStatusBtn
            // 
            this.tsStatusBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStatusBtn.DropDownButtonWidth = 12;
            this.tsStatusBtn.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.tsStatusBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsStatusBtn.Image")));
            this.tsStatusBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStatusBtn.Name = "tsStatusBtn";
            this.tsStatusBtn.Size = new System.Drawing.Size(202, 23);
            this.tsStatusBtn.Text = "測試設備連接狀態 : 未連線";
            this.tsStatusBtn.Visible = false;
            this.tsStatusBtn.ButtonClick += new System.EventHandler(this.TsStatusBtn_Click);
            // 
            // tsTestDeviceStatus
            // 
            this.tsTestDeviceStatus.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.tsTestDeviceStatus.Name = "tsTestDeviceStatus";
            this.tsTestDeviceStatus.Size = new System.Drawing.Size(185, 19);
            this.tsTestDeviceStatus.Text = "測試設備連接狀態 : 未連線";
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
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tlpBase.Size = new System.Drawing.Size(984, 538);
            this.tlpBase.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.tlpBase);
            this.Controls.Add(this.ssButtom);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FormMain";
            this.Text = "標籤作業平台";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.tabPrinter.ResumeLayout(false);
            this.tabPrinter.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.tlpSettingBase.ResumeLayout(false);
            this.tlpSettingBtn.ResumeLayout(false);
            this.tlpSettingBtn.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tlpSettingBase;
        private System.Windows.Forms.TableLayoutPanel tlpSettingBtn;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.RadioButton rbtnReport;
        private System.Windows.Forms.RadioButton rbtnBackup;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.RadioButton rbtnMachine;
        private System.Windows.Forms.StatusStrip ssButtom;
        private System.Windows.Forms.Panel pnlSettingSplit;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private Pages.PageTest ptMain;
        private Pages.PageTest ptPrint;
        private System.Windows.Forms.TabPage tabLogout;
        private Pages.PageHelp pageHelp1;
        private System.Windows.Forms.ToolStripSplitButton tsStatusBtn;
        private System.Windows.Forms.RadioButton rbtnPrinter;
        private System.Windows.Forms.ToolStripStatusLabel tsTestDeviceStatus;
    }
}