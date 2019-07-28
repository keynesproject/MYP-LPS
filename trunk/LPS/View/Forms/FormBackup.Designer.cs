namespace LPS.View.Forms
{
    partial class FormBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackup));
            this.tlpMsg = new System.Windows.Forms.TableLayoutPanel();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tlpMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMsg
            // 
            this.tlpMsg.ColumnCount = 3;
            this.tlpMsg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMsg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMsg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMsg.Controls.Add(this.pbProcess, 1, 1);
            this.tlpMsg.Controls.Add(this.lblMsg, 1, 0);
            this.tlpMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMsg.Location = new System.Drawing.Point(0, 0);
            this.tlpMsg.Margin = new System.Windows.Forms.Padding(9, 2, 2, 2);
            this.tlpMsg.Name = "tlpMsg";
            this.tlpMsg.RowCount = 3;
            this.tlpMsg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMsg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpMsg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMsg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMsg.Size = new System.Drawing.Size(464, 142);
            this.tlpMsg.TabIndex = 2;
            // 
            // pbProcess
            // 
            this.pbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProcess.Location = new System.Drawing.Point(43, 51);
            this.pbProcess.MarqueeAnimationSpeed = 1;
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(378, 39);
            this.pbProcess.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblMsg.Location = new System.Drawing.Point(43, 0);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(3, 0, 9, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(372, 48);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "備份資料";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBackup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(464, 142);
            this.Controls.Add(this.tlpMsg);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "資訊備份";
            this.Shown += new System.EventHandler(this.FormBackup_Shown);
            this.tlpMsg.ResumeLayout(false);
            this.tlpMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMsg;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Label lblMsg;
    }
}