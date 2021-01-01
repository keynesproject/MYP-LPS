namespace MypSnFixTool
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
            this.tbCurrentSN = new System.Windows.Forms.TextBox();
            this.lblCurrentSN = new System.Windows.Forms.Label();
            this.pnlSplit2 = new System.Windows.Forms.Panel();
            this.pnlSplit1 = new System.Windows.Forms.Panel();
            this.tlpFix = new System.Windows.Forms.TableLayoutPanel();
            this.btnFixed = new System.Windows.Forms.Button();
            this.lblCustomCPU = new System.Windows.Forms.Label();
            this.lblFixSN = new System.Windows.Forms.Label();
            this.tbGiveCPU = new System.Windows.Forms.TextBox();
            this.tbGiveSN = new System.Windows.Forms.TextBox();
            this.tlpBase.SuspendLayout();
            this.tlpFix.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tbCurrentSN, 0, 4);
            this.tlpBase.Controls.Add(this.lblCurrentSN, 0, 3);
            this.tlpBase.Controls.Add(this.pnlSplit2, 0, 5);
            this.tlpBase.Controls.Add(this.pnlSplit1, 0, 2);
            this.tlpBase.Controls.Add(this.tlpFix, 0, 8);
            this.tlpBase.Controls.Add(this.lblCustomCPU, 0, 0);
            this.tlpBase.Controls.Add(this.lblFixSN, 0, 6);
            this.tlpBase.Controls.Add(this.tbGiveCPU, 0, 1);
            this.tlpBase.Controls.Add(this.tbGiveSN, 0, 7);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 9;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tlpBase.Size = new System.Drawing.Size(498, 240);
            this.tlpBase.TabIndex = 0;
            // 
            // tbCurrentSN
            // 
            this.tbCurrentSN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbCurrentSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentSN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbCurrentSN.ForeColor = System.Drawing.Color.LightCoral;
            this.tbCurrentSN.Location = new System.Drawing.Point(3, 100);
            this.tbCurrentSN.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.tbCurrentSN.MaxLength = 128;
            this.tbCurrentSN.Name = "tbCurrentSN";
            this.tbCurrentSN.ReadOnly = true;
            this.tbCurrentSN.Size = new System.Drawing.Size(492, 27);
            this.tbCurrentSN.TabIndex = 31;
            // 
            // lblCurrentSN
            // 
            this.lblCurrentSN.AutoSize = true;
            this.lblCurrentSN.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentSN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSN.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentSN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentSN.Location = new System.Drawing.Point(5, 72);
            this.lblCurrentSN.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblCurrentSN.Name = "lblCurrentSN";
            this.lblCurrentSN.Size = new System.Drawing.Size(490, 19);
            this.lblCurrentSN.TabIndex = 30;
            this.lblCurrentSN.Text = "本機序號:";
            this.lblCurrentSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSplit2
            // 
            this.pnlSplit2.AutoSize = true;
            this.pnlSplit2.BackColor = System.Drawing.Color.Black;
            this.pnlSplit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplit2.Location = new System.Drawing.Point(3, 135);
            this.pnlSplit2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.pnlSplit2.Name = "pnlSplit2";
            this.pnlSplit2.Size = new System.Drawing.Size(492, 1);
            this.pnlSplit2.TabIndex = 29;
            // 
            // pnlSplit1
            // 
            this.pnlSplit1.AutoSize = true;
            this.pnlSplit1.BackColor = System.Drawing.Color.Black;
            this.pnlSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplit1.Location = new System.Drawing.Point(3, 66);
            this.pnlSplit1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.pnlSplit1.Name = "pnlSplit1";
            this.pnlSplit1.Size = new System.Drawing.Size(492, 1);
            this.pnlSplit1.TabIndex = 28;
            // 
            // tlpFix
            // 
            this.tlpFix.AutoSize = true;
            this.tlpFix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpFix.ColumnCount = 2;
            this.tlpFix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFix.Controls.Add(this.btnFixed, 1, 0);
            this.tlpFix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFix.Location = new System.Drawing.Point(3, 204);
            this.tlpFix.Name = "tlpFix";
            this.tlpFix.RowCount = 1;
            this.tlpFix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpFix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpFix.Size = new System.Drawing.Size(492, 33);
            this.tlpFix.TabIndex = 27;
            // 
            // btnFixed
            // 
            this.btnFixed.AutoSize = true;
            this.btnFixed.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFixed.Location = new System.Drawing.Point(390, 3);
            this.btnFixed.Name = "btnFixed";
            this.btnFixed.Size = new System.Drawing.Size(99, 27);
            this.btnFixed.TabIndex = 35;
            this.btnFixed.Text = "修復序號";
            this.btnFixed.UseVisualStyleBackColor = true;
            this.btnFixed.Click += new System.EventHandler(this.BtnFixed_Click);
            // 
            // lblCustomCPU
            // 
            this.lblCustomCPU.AutoSize = true;
            this.lblCustomCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomCPU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomCPU.ForeColor = System.Drawing.Color.Black;
            this.lblCustomCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomCPU.Location = new System.Drawing.Point(5, 3);
            this.lblCustomCPU.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblCustomCPU.Name = "lblCustomCPU";
            this.lblCustomCPU.Size = new System.Drawing.Size(490, 19);
            this.lblCustomCPU.TabIndex = 20;
            this.lblCustomCPU.Text = "指定電腦:";
            this.lblCustomCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFixSN
            // 
            this.lblFixSN.AutoSize = true;
            this.lblFixSN.BackColor = System.Drawing.Color.Transparent;
            this.lblFixSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFixSN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixSN.ForeColor = System.Drawing.Color.Black;
            this.lblFixSN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFixSN.Location = new System.Drawing.Point(5, 141);
            this.lblFixSN.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblFixSN.Name = "lblFixSN";
            this.lblFixSN.Size = new System.Drawing.Size(490, 19);
            this.lblFixSN.TabIndex = 21;
            this.lblFixSN.Text = "修復序號:";
            this.lblFixSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbGiveCPU
            // 
            this.tbGiveCPU.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbGiveCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGiveCPU.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbGiveCPU.ForeColor = System.Drawing.Color.LightCoral;
            this.tbGiveCPU.Location = new System.Drawing.Point(3, 31);
            this.tbGiveCPU.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.tbGiveCPU.MaxLength = 128;
            this.tbGiveCPU.Name = "tbGiveCPU";
            this.tbGiveCPU.ReadOnly = true;
            this.tbGiveCPU.Size = new System.Drawing.Size(492, 27);
            this.tbGiveCPU.TabIndex = 22;
            this.tbGiveCPU.Text = "67097";
            // 
            // tbGiveSN
            // 
            this.tbGiveSN.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbGiveSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGiveSN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbGiveSN.ForeColor = System.Drawing.Color.LightCoral;
            this.tbGiveSN.Location = new System.Drawing.Point(3, 169);
            this.tbGiveSN.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.tbGiveSN.MaxLength = 128;
            this.tbGiveSN.Name = "tbGiveSN";
            this.tbGiveSN.ReadOnly = true;
            this.tbGiveSN.Size = new System.Drawing.Size(492, 27);
            this.tbGiveSN.TabIndex = 23;
            this.tbGiveSN.Text = "CUPC7-DHYMJ-B5Y1N-8U7AE-ZPJYB-XA6S";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 240);
            this.Controls.Add(this.tlpBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "MYP序號修復工具 V1.0.0.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpFix.ResumeLayout(false);
            this.tlpFix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblCustomCPU;
        private System.Windows.Forms.Label lblFixSN;
        private System.Windows.Forms.TextBox tbGiveCPU;
        private System.Windows.Forms.TextBox tbGiveSN;
        private System.Windows.Forms.TableLayoutPanel tlpFix;
        private System.Windows.Forms.Button btnFixed;
        private System.Windows.Forms.Panel pnlSplit1;
        private System.Windows.Forms.TextBox tbCurrentSN;
        private System.Windows.Forms.Label lblCurrentSN;
        private System.Windows.Forms.Panel pnlSplit2;
    }
}

