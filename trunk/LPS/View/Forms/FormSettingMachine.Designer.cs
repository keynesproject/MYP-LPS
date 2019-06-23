namespace LPS.View.Forms
{
    partial class FormSettingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingMachine));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpOption = new System.Windows.Forms.TableLayoutPanel();
            this.lblDotMachine = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDotDefault = new System.Windows.Forms.Label();
            this.lbDotDescription = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbDefult = new System.Windows.Forms.ComboBox();
            this.cbMachine = new System.Windows.Forms.ComboBox();
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
            this.tlpBase.Controls.Add(this.tlpButton, 0, 2);
            this.tlpBase.Controls.Add(this.tlpOption, 0, 0);
            this.tlpBase.Controls.Add(this.lblSplit, 0, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 3;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Size = new System.Drawing.Size(332, 257);
            this.tlpBase.TabIndex = 0;
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
            this.tlpButton.Location = new System.Drawing.Point(3, 198);
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
            this.btnCancel.Text = "取  消";
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
            this.tlpOption.Controls.Add(this.lblDotMachine, 0, 0);
            this.tlpOption.Controls.Add(this.tbDescription, 2, 2);
            this.tlpOption.Controls.Add(this.lblDotDefault, 0, 1);
            this.tlpOption.Controls.Add(this.lbDotDescription, 0, 2);
            this.tlpOption.Controls.Add(this.lblMachine, 1, 0);
            this.tlpOption.Controls.Add(this.lblDefault, 1, 1);
            this.tlpOption.Controls.Add(this.lblDescription, 1, 2);
            this.tlpOption.Controls.Add(this.cbDefult, 2, 1);
            this.tlpOption.Controls.Add(this.cbMachine, 2, 0);
            this.tlpOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOption.Location = new System.Drawing.Point(3, 3);
            this.tlpOption.Name = "tlpOption";
            this.tlpOption.RowCount = 3;
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOption.Size = new System.Drawing.Size(326, 186);
            this.tlpOption.TabIndex = 1;
            // 
            // lblDotMachine
            // 
            this.lblDotMachine.AutoSize = true;
            this.lblDotMachine.BackColor = System.Drawing.Color.Transparent;
            this.lblDotMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotMachine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotMachine.Location = new System.Drawing.Point(3, 0);
            this.lblDotMachine.Name = "lblDotMachine";
            this.lblDotMachine.Size = new System.Drawing.Size(14, 30);
            this.lblDotMachine.TabIndex = 1;
            this.lblDotMachine.Text = "˙";
            this.lblDotMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(98, 66);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tbDescription.MaxLength = 64;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ShortcutsEnabled = false;
            this.tbDescription.Size = new System.Drawing.Size(208, 120);
            this.tbDescription.TabIndex = 2;
            // 
            // lblDotDefault
            // 
            this.lblDotDefault.AutoSize = true;
            this.lblDotDefault.BackColor = System.Drawing.Color.Transparent;
            this.lblDotDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDotDefault.Location = new System.Drawing.Point(3, 30);
            this.lblDotDefault.Name = "lblDotDefault";
            this.lblDotDefault.Size = new System.Drawing.Size(14, 30);
            this.lblDotDefault.TabIndex = 2;
            this.lblDotDefault.Text = "˙";
            this.lblDotDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDotDescription
            // 
            this.lbDotDescription.AutoSize = true;
            this.lbDotDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDotDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDotDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDotDescription.Location = new System.Drawing.Point(3, 63);
            this.lbDotDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbDotDescription.Name = "lbDotDescription";
            this.lbDotDescription.Size = new System.Drawing.Size(14, 123);
            this.lbDotDescription.TabIndex = 4;
            this.lbDotDescription.Text = "˙";
            this.lbDotDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.BackColor = System.Drawing.Color.Transparent;
            this.lblMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(23, 3);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(3);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(72, 24);
            this.lblMachine.TabIndex = 156;
            this.lblMachine.Text = "機台代碼";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.BackColor = System.Drawing.Color.Transparent;
            this.lblDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefault.Location = new System.Drawing.Point(23, 33);
            this.lblDefault.Margin = new System.Windows.Forms.Padding(3);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(72, 24);
            this.lblDefault.TabIndex = 157;
            this.lblDefault.Text = "預設機台";
            this.lblDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 63);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 120);
            this.lblDescription.TabIndex = 164;
            this.lblDescription.Text = "描述";
            // 
            // cbDefult
            // 
            this.cbDefult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDefult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefult.FormattingEnabled = true;
            this.cbDefult.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cbDefult.Location = new System.Drawing.Point(98, 36);
            this.cbDefult.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.cbDefult.Name = "cbDefult";
            this.cbDefult.Size = new System.Drawing.Size(208, 24);
            this.cbDefult.TabIndex = 1;
            // 
            // cbMachine
            // 
            this.cbMachine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMachine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbMachine.Location = new System.Drawing.Point(98, 6);
            this.cbMachine.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(208, 24);
            this.cbMachine.TabIndex = 0;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplit.Location = new System.Drawing.Point(3, 192);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(326, 3);
            this.lblSplit.TabIndex = 4;
            // 
            // FormSettingMachine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 257);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "機台資訊";
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
        private System.Windows.Forms.TableLayoutPanel tlpOption;
        private System.Windows.Forms.Label lblDotMachine;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDotDefault;
        private System.Windows.Forms.Label lbDotDescription;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbDefult;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMachine;
    }
}