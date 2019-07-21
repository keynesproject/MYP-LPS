namespace LPS.View.Forms
{
    partial class FormSettingCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingCars));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.lblDotPN = new System.Windows.Forms.Label();
            this.lblDotCar = new System.Windows.Forms.Label();
            this.lbDotCode = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.tbCar = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.tlpBase.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.tlpButton, 0, 4);
            this.tlpBase.Controls.Add(this.tlpOption, 0, 0);
            this.tlpBase.Controls.Add(this.lblSplit, 0, 2);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 5;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.Size = new System.Drawing.Size(332, 174);
            this.tlpBase.TabIndex = 1;
            // 
            // tlpButton
            // 
            this.tlpButton.AutoSize = true;
            this.tlpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButton.Controls.Add(this.btnAdd, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 115);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(326, 56);
            this.tlpButton.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.Location = new System.Drawing.Point(231, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "離  開";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.Location = new System.Drawing.Point(134, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新  增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAdd_MouseUp);
            // 
            // tlpOption
            // 
            this.tlpOption.AutoSize = true;
            this.tlpOption.ColumnCount = 4;
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOption.Controls.Add(this.lblDotPN, 0, 0);
            this.tlpOption.Controls.Add(this.lblDotCar, 0, 1);
            this.tlpOption.Controls.Add(this.lbDotCode, 0, 2);
            this.tlpOption.Controls.Add(this.lblPN, 1, 0);
            this.tlpOption.Controls.Add(this.lblCar, 1, 1);
            this.tlpOption.Controls.Add(this.lblCode, 1, 2);
            this.tlpOption.Controls.Add(this.tbPN, 2, 0);
            this.tlpOption.Controls.Add(this.tbCar, 2, 1);
            this.tlpOption.Controls.Add(this.tbCode, 2, 2);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 3);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 3;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.Size = new System.Drawing.Size(326, 93);
            this.tlpOption.TabIndex = 1;
            // 
            // lblDotPN
            // 
            this.lblDotPN.AutoSize = true;
            this.lblDotPN.BackColor = System.Drawing.Color.Transparent;
            this.lblDotPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotPN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotPN.Location = new System.Drawing.Point(3, 3);
            this.lblDotPN.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotPN.Name = "lblDotPN";
            this.lblDotPN.Size = new System.Drawing.Size(14, 25);
            this.lblDotPN.TabIndex = 1;
            this.lblDotPN.Text = "˙";
            this.lblDotPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotCar
            // 
            this.lblDotCar.AutoSize = true;
            this.lblDotCar.BackColor = System.Drawing.Color.Transparent;
            this.lblDotCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotCar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotCar.Location = new System.Drawing.Point(3, 34);
            this.lblDotCar.Margin = new System.Windows.Forms.Padding(3);
            this.lblDotCar.Name = "lblDotCar";
            this.lblDotCar.Size = new System.Drawing.Size(14, 25);
            this.lblDotCar.TabIndex = 2;
            this.lblDotCar.Text = "˙";
            this.lblDotCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDotCode
            // 
            this.lbDotCode.AutoSize = true;
            this.lbDotCode.BackColor = System.Drawing.Color.Transparent;
            this.lbDotCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDotCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDotCode.Location = new System.Drawing.Point(3, 65);
            this.lbDotCode.Margin = new System.Windows.Forms.Padding(3);
            this.lbDotCode.Name = "lbDotCode";
            this.lbDotCode.Size = new System.Drawing.Size(14, 25);
            this.lbDotCode.TabIndex = 4;
            this.lbDotCode.Text = "˙";
            this.lbDotCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.BackColor = System.Drawing.Color.Transparent;
            this.lblPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPN.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPN.Location = new System.Drawing.Point(23, 3);
            this.lblPN.Margin = new System.Windows.Forms.Padding(3);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(56, 25);
            this.lblPN.TabIndex = 156;
            this.lblPN.Text = "件    號";
            this.lblPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.BackColor = System.Drawing.Color.Transparent;
            this.lblCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(23, 34);
            this.lblCar.Margin = new System.Windows.Forms.Padding(3);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(56, 25);
            this.lblCar.TabIndex = 157;
            this.lblCar.Text = "車    型";
            this.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(23, 65);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 25);
            this.lblCode.TabIndex = 164;
            this.lblCode.Text = "簡    碼";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPN
            // 
            this.tbPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPN.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPN.Location = new System.Drawing.Point(85, 3);
            this.tbPN.MaxLength = 15;
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(218, 25);
            this.tbPN.TabIndex = 0;
            // 
            // tbCar
            // 
            this.tbCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCar.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCar.Location = new System.Drawing.Point(85, 34);
            this.tbCar.MaxLength = 20;
            this.tbCar.Name = "tbCar";
            this.tbCar.Size = new System.Drawing.Size(218, 25);
            this.tbCar.TabIndex = 1;
            // 
            // tbCode
            // 
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCode.Location = new System.Drawing.Point(85, 65);
            this.tbCode.MaxLength = 4;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(218, 25);
            this.tbCode.TabIndex = 2;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit.Location = new System.Drawing.Point(3, 104);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(326, 3);
            this.lblSplit.TabIndex = 4;
            // 
            // FormSettingCars
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 174);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettingCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "車型件號";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpButton.PerformLayout();
            this.tlpOption.ResumeLayout(false);
            this.tlpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Label lblDotPN;
        private System.Windows.Forms.Label lblDotCar;
        private System.Windows.Forms.Label lbDotCode;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.TextBox tbCar;
        private System.Windows.Forms.TextBox tbCode;
    }
}