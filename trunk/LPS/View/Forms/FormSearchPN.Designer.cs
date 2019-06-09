namespace LPS.View.Forms
{
    partial class FormSearchPN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchPN));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblDotPN = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.columnPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpBase.SuspendLayout();
            this.tlpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpTop, 0, 0);
            this.tlpBase.Controls.Add(this.dgvPN, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(734, 412);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 5;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.Controls.Add(this.tbPN, 0, 0);
            this.tlpTop.Controls.Add(this.lblPN, 0, 0);
            this.tlpTop.Controls.Add(this.lblDotPN, 0, 0);
            this.tlpTop.Controls.Add(this.btnOK, 3, 0);
            this.tlpTop.Controls.Add(this.btnExit, 4, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(734, 38);
            this.tlpTop.TabIndex = 0;
            // 
            // tbPN
            // 
            this.tbPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tbPN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPN.Location = new System.Drawing.Point(109, 6);
            this.tbPN.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.tbPN.MaxLength = 64;
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(528, 24);
            this.tbPN.TabIndex = 14;
            this.tbPN.TextChanged += new System.EventHandler(this.TbPN_TextChanged);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPN.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPN.Location = new System.Drawing.Point(23, 4);
            this.lblPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(80, 30);
            this.lblPN.TabIndex = 2;
            this.lblPN.Text = "友永件號:";
            this.lblPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotPN
            // 
            this.lblDotPN.AutoSize = true;
            this.lblDotPN.BackColor = System.Drawing.Color.Transparent;
            this.lblDotPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotPN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotPN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDotPN.Location = new System.Drawing.Point(3, 0);
            this.lblDotPN.Name = "lblDotPN";
            this.lblDotPN.Size = new System.Drawing.Size(14, 38);
            this.lblDotPN.TabIndex = 1;
            this.lblDotPN.Text = "˙";
            this.lblDotPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(643, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(41, 30);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(690, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 30);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgvPN
            // 
            this.dgvPN.AllowUserToAddRows = false;
            this.dgvPN.AllowUserToDeleteRows = false;
            this.dgvPN.AllowUserToResizeRows = false;
            this.dgvPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPN,
            this.columnCar,
            this.columnCode});
            this.dgvPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPN.Location = new System.Drawing.Point(3, 41);
            this.dgvPN.MultiSelect = false;
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPN.RowHeadersVisible = false;
            this.dgvPN.RowTemplate.Height = 24;
            this.dgvPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPN.Size = new System.Drawing.Size(728, 368);
            this.dgvPN.TabIndex = 1;
            this.dgvPN.TabStop = false;
            // 
            // columnPN
            // 
            this.columnPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPN.DataPropertyName = "件號";
            this.columnPN.HeaderText = "友永件號";
            this.columnPN.MaxInputLength = 128;
            this.columnPN.MinimumWidth = 100;
            this.columnPN.Name = "columnPN";
            this.columnPN.ReadOnly = true;
            // 
            // columnCar
            // 
            this.columnCar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCar.DataPropertyName = "車型";
            this.columnCar.HeaderText = "車型";
            this.columnCar.MaxInputLength = 128;
            this.columnCar.MinimumWidth = 100;
            this.columnCar.Name = "columnCar";
            this.columnCar.ReadOnly = true;
            // 
            // columnCode
            // 
            this.columnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCode.DataPropertyName = "簡碼";
            this.columnCode.FillWeight = 50F;
            this.columnCode.HeaderText = "簡碼";
            this.columnCode.MaxInputLength = 64;
            this.columnCode.MinimumWidth = 100;
            this.columnCode.Name = "columnCode";
            this.columnCode.ReadOnly = true;
            // 
            // FormSearchPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearchPN";
            this.Text = "友永件號搜尋";
            this.Shown += new System.EventHandler(this.FormSearchPN_Shown);
            this.tlpBase.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Label lblDotPN;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
    }
}