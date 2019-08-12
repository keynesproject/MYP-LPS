﻿namespace LPS.View.Pages
{
    partial class PageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.columnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStrPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tlpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.dgvUser, 0, 2);
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
            this.tlpBase.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSN,
            this.columnName,
            this.ColumnStrPermission,
            this.columnPW,
            this.ColumnSerial,
            this.ColumnPermission});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(3, 67);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(759, 321);
            this.dgvUser.TabIndex = 8;
            this.dgvUser.TabStop = false;
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 7;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.Controls.Add(this.btnAdd, 1, 0);
            this.tlpOption.Controls.Add(this.btnEdit, 3, 0);
            this.tlpOption.Controls.Add(this.btnDel, 5, 0);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 3);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 1;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.Size = new System.Drawing.Size(759, 50);
            this.tlpOption.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAdd.Location = new System.Drawing.Point(13, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新  增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAdd_MouseUp);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEdit.Location = new System.Drawing.Point(87, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修  改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnEdit_MouseUp);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Font = new System.Drawing.Font("Arial", 11F);
            this.btnDel.Location = new System.Drawing.Point(161, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(58, 44);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "刪  除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDel_MouseUp);
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
            // columnSN
            // 
            this.columnSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSN.DataPropertyName = "代碼";
            this.columnSN.FillWeight = 50F;
            this.columnSN.HeaderText = "代碼";
            this.columnSN.MaxInputLength = 128;
            this.columnSN.MinimumWidth = 100;
            this.columnSN.Name = "columnSN";
            this.columnSN.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "作業員姓名";
            this.columnName.FillWeight = 50F;
            this.columnName.HeaderText = "姓名";
            this.columnName.MaxInputLength = 128;
            this.columnName.MinimumWidth = 100;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // ColumnStrPermission
            // 
            this.ColumnStrPermission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStrPermission.DataPropertyName = "Permission";
            this.ColumnStrPermission.FillWeight = 50F;
            this.ColumnStrPermission.HeaderText = "管理者權限";
            this.ColumnStrPermission.MaxInputLength = 128;
            this.ColumnStrPermission.MinimumWidth = 100;
            this.ColumnStrPermission.Name = "ColumnStrPermission";
            this.ColumnStrPermission.ReadOnly = true;
            this.ColumnStrPermission.Visible = false;
            // 
            // columnPW
            // 
            this.columnPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPW.DataPropertyName = "密碼";
            this.columnPW.FillWeight = 50F;
            this.columnPW.HeaderText = "密碼";
            this.columnPW.MaxInputLength = 64;
            this.columnPW.MinimumWidth = 100;
            this.columnPW.Name = "columnPW";
            this.columnPW.ReadOnly = true;
            // 
            // ColumnSerial
            // 
            this.ColumnSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSerial.DataPropertyName = "Serial";
            this.ColumnSerial.FillWeight = 50F;
            this.ColumnSerial.HeaderText = "代碼姓名";
            this.ColumnSerial.MaxInputLength = 128;
            this.ColumnSerial.MinimumWidth = 100;
            this.ColumnSerial.Name = "ColumnSerial";
            this.ColumnSerial.ReadOnly = true;
            this.ColumnSerial.Visible = false;
            // 
            // ColumnPermission
            // 
            this.ColumnPermission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPermission.DataPropertyName = "權限";
            this.ColumnPermission.FillWeight = 50F;
            this.ColumnPermission.HeaderText = "管理者權限";
            this.ColumnPermission.MaxInputLength = 128;
            this.ColumnPermission.MinimumWidth = 100;
            this.ColumnPermission.Name = "ColumnPermission";
            this.ColumnPermission.ReadOnly = true;
            // 
            // PageUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpBase);
            this.Name = "PageUser";
            this.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStrPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPermission;
    }
}
