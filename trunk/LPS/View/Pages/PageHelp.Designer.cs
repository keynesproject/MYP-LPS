using LPS.Model.DataAccessObject;

namespace LPS.View.Pages
{
    partial class PageHelp
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
            DaoSnControl.Instance.UpdateSnEvent -= this.SnUpdate;

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
            this.pnlLineMiddle = new System.Windows.Forms.Panel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.tlpSupportMyp = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmailMypTitle = new System.Windows.Forms.Label();
            this.lblTelMypValue = new System.Windows.Forms.Label();
            this.lnkLblMypEmail = new System.Windows.Forms.LinkLabel();
            this.lblPhoneMypValue = new System.Windows.Forms.Label();
            this.lblDotPhoneMyp = new System.Windows.Forms.Label();
            this.lblDotTelMyp = new System.Windows.Forms.Label();
            this.lblDotEmailMyp = new System.Windows.Forms.Label();
            this.lblPhoneMypTitle = new System.Windows.Forms.Label();
            this.lblTelMypTitle = new System.Windows.Forms.Label();
            this.lblDotFaxMyp = new System.Windows.Forms.Label();
            this.lblFaxMypTitle = new System.Windows.Forms.Label();
            this.lblFaxMypValue = new System.Windows.Forms.Label();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.tlpSupportHar = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneHarValue = new System.Windows.Forms.Label();
            this.lblDotPhoneHar = new System.Windows.Forms.Label();
            this.lblPhoneHarTitle = new System.Windows.Forms.Label();
            this.lblDotFaxHar = new System.Windows.Forms.Label();
            this.lblFaxHarTitle = new System.Windows.Forms.Label();
            this.lblFaxHarValue = new System.Windows.Forms.Label();
            this.llSupportMyp = new System.Windows.Forms.LinkLabel();
            this.llSupportHar = new System.Windows.Forms.LinkLabel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlLineLeft = new System.Windows.Forms.Panel();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tlpVersion = new System.Windows.Forms.TableLayoutPanel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.tlpBase.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.tlpSupportMyp.SuspendLayout();
            this.tlpSupportHar.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 3;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpBase.Controls.Add(this.pnlLineMiddle, 0, 0);
            this.tlpBase.Controls.Add(this.tlpInfo, 2, 0);
            this.tlpBase.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(765, 391);
            this.tlpBase.TabIndex = 12;
            // 
            // pnlLineMiddle
            // 
            this.pnlLineMiddle.AutoSize = true;
            this.pnlLineMiddle.BackColor = System.Drawing.Color.Black;
            this.pnlLineMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLineMiddle.Location = new System.Drawing.Point(344, 4);
            this.pnlLineMiddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLineMiddle.Name = "pnlLineMiddle";
            this.pnlLineMiddle.Size = new System.Drawing.Size(1, 383);
            this.pnlLineMiddle.TabIndex = 8;
            // 
            // tlpInfo
            // 
            this.tlpInfo.AutoSize = true;
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.pnlLine2, 0, 5);
            this.tlpInfo.Controls.Add(this.tlpSupportMyp, 0, 1);
            this.tlpInfo.Controls.Add(this.pnlLine1, 0, 2);
            this.tlpInfo.Controls.Add(this.lblCopyright, 0, 6);
            this.tlpInfo.Controls.Add(this.tlpSupportHar, 0, 4);
            this.tlpInfo.Controls.Add(this.llSupportMyp, 0, 0);
            this.tlpInfo.Controls.Add(this.llSupportHar, 0, 3);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tlpInfo.Location = new System.Drawing.Point(350, 4);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 7;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.Size = new System.Drawing.Size(412, 383);
            this.tlpInfo.TabIndex = 2;
            // 
            // pnlLine2
            // 
            this.pnlLine2.AutoSize = true;
            this.pnlLine2.BackColor = System.Drawing.Color.Black;
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2.Location = new System.Drawing.Point(3, 228);
            this.pnlLine2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(406, 1);
            this.pnlLine2.TabIndex = 7;
            // 
            // tlpSupportMyp
            // 
            this.tlpSupportMyp.AutoSize = true;
            this.tlpSupportMyp.ColumnCount = 3;
            this.tlpSupportMyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupportMyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupportMyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupportMyp.Controls.Add(this.lblEmailMypTitle, 1, 3);
            this.tlpSupportMyp.Controls.Add(this.lblTelMypValue, 2, 1);
            this.tlpSupportMyp.Controls.Add(this.lnkLblMypEmail, 2, 3);
            this.tlpSupportMyp.Controls.Add(this.lblPhoneMypValue, 2, 0);
            this.tlpSupportMyp.Controls.Add(this.lblDotPhoneMyp, 0, 0);
            this.tlpSupportMyp.Controls.Add(this.lblDotTelMyp, 0, 1);
            this.tlpSupportMyp.Controls.Add(this.lblDotEmailMyp, 0, 3);
            this.tlpSupportMyp.Controls.Add(this.lblPhoneMypTitle, 1, 0);
            this.tlpSupportMyp.Controls.Add(this.lblTelMypTitle, 1, 1);
            this.tlpSupportMyp.Controls.Add(this.lblDotFaxMyp, 0, 2);
            this.tlpSupportMyp.Controls.Add(this.lblFaxMypTitle, 1, 2);
            this.tlpSupportMyp.Controls.Add(this.lblFaxMypValue, 2, 2);
            this.tlpSupportMyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupportMyp.Location = new System.Drawing.Point(3, 23);
            this.tlpSupportMyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSupportMyp.Name = "tlpSupportMyp";
            this.tlpSupportMyp.RowCount = 5;
            this.tlpSupportMyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportMyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportMyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportMyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportMyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportMyp.Size = new System.Drawing.Size(406, 108);
            this.tlpSupportMyp.TabIndex = 5;
            // 
            // lblEmailMypTitle
            // 
            this.lblEmailMypTitle.AutoSize = true;
            this.lblEmailMypTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailMypTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmailMypTitle.Location = new System.Drawing.Point(28, 85);
            this.lblEmailMypTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEmailMypTitle.Name = "lblEmailMypTitle";
            this.lblEmailMypTitle.Size = new System.Drawing.Size(80, 19);
            this.lblEmailMypTitle.TabIndex = 1;
            this.lblEmailMypTitle.Text = "客服信箱 :";
            this.lblEmailMypTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelMypValue
            // 
            this.lblTelMypValue.AutoSize = true;
            this.lblTelMypValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelMypValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelMypValue.Location = new System.Drawing.Point(114, 27);
            this.lblTelMypValue.Name = "lblTelMypValue";
            this.lblTelMypValue.Size = new System.Drawing.Size(289, 27);
            this.lblTelMypValue.TabIndex = 2;
            this.lblTelMypValue.Text = "0933-722-885";
            this.lblTelMypValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkLblMypEmail
            // 
            this.lnkLblMypEmail.AutoSize = true;
            this.lnkLblMypEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkLblMypEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lnkLblMypEmail.Location = new System.Drawing.Point(114, 81);
            this.lnkLblMypEmail.Name = "lnkLblMypEmail";
            this.lnkLblMypEmail.Size = new System.Drawing.Size(289, 27);
            this.lnkLblMypEmail.TabIndex = 2;
            this.lnkLblMypEmail.TabStop = true;
            this.lnkLblMypEmail.Text = "service@myp.net.tw";
            this.lnkLblMypEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLblMypEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblMypEmail_LinkClicked);
            // 
            // lblPhoneMypValue
            // 
            this.lblPhoneMypValue.AutoSize = true;
            this.lblPhoneMypValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneMypValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneMypValue.Location = new System.Drawing.Point(114, 0);
            this.lblPhoneMypValue.Name = "lblPhoneMypValue";
            this.lblPhoneMypValue.Size = new System.Drawing.Size(289, 27);
            this.lblPhoneMypValue.TabIndex = 0;
            this.lblPhoneMypValue.Text = "02-2799-3590";
            this.lblPhoneMypValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotPhoneMyp
            // 
            this.lblDotPhoneMyp.AutoSize = true;
            this.lblDotPhoneMyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotPhoneMyp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotPhoneMyp.Location = new System.Drawing.Point(3, 4);
            this.lblDotPhoneMyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotPhoneMyp.Name = "lblDotPhoneMyp";
            this.lblDotPhoneMyp.Size = new System.Drawing.Size(19, 19);
            this.lblDotPhoneMyp.TabIndex = 0;
            this.lblDotPhoneMyp.Text = "●";
            this.lblDotPhoneMyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotTelMyp
            // 
            this.lblDotTelMyp.AutoSize = true;
            this.lblDotTelMyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotTelMyp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotTelMyp.Location = new System.Drawing.Point(3, 31);
            this.lblDotTelMyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotTelMyp.Name = "lblDotTelMyp";
            this.lblDotTelMyp.Size = new System.Drawing.Size(19, 19);
            this.lblDotTelMyp.TabIndex = 0;
            this.lblDotTelMyp.Text = "●";
            this.lblDotTelMyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotEmailMyp
            // 
            this.lblDotEmailMyp.AutoSize = true;
            this.lblDotEmailMyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotEmailMyp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotEmailMyp.Location = new System.Drawing.Point(3, 85);
            this.lblDotEmailMyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotEmailMyp.Name = "lblDotEmailMyp";
            this.lblDotEmailMyp.Size = new System.Drawing.Size(19, 19);
            this.lblDotEmailMyp.TabIndex = 0;
            this.lblDotEmailMyp.Text = "●";
            this.lblDotEmailMyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneMypTitle
            // 
            this.lblPhoneMypTitle.AutoSize = true;
            this.lblPhoneMypTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneMypTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneMypTitle.Location = new System.Drawing.Point(28, 4);
            this.lblPhoneMypTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPhoneMypTitle.Name = "lblPhoneMypTitle";
            this.lblPhoneMypTitle.Size = new System.Drawing.Size(80, 19);
            this.lblPhoneMypTitle.TabIndex = 0;
            this.lblPhoneMypTitle.Text = "電話 :";
            this.lblPhoneMypTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelMypTitle
            // 
            this.lblTelMypTitle.AutoSize = true;
            this.lblTelMypTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelMypTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelMypTitle.Location = new System.Drawing.Point(28, 31);
            this.lblTelMypTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTelMypTitle.Name = "lblTelMypTitle";
            this.lblTelMypTitle.Size = new System.Drawing.Size(80, 19);
            this.lblTelMypTitle.TabIndex = 1;
            this.lblTelMypTitle.Text = "業務專線 :";
            this.lblTelMypTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotFaxMyp
            // 
            this.lblDotFaxMyp.AutoSize = true;
            this.lblDotFaxMyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotFaxMyp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotFaxMyp.Location = new System.Drawing.Point(3, 58);
            this.lblDotFaxMyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotFaxMyp.Name = "lblDotFaxMyp";
            this.lblDotFaxMyp.Size = new System.Drawing.Size(19, 19);
            this.lblDotFaxMyp.TabIndex = 3;
            this.lblDotFaxMyp.Text = "●";
            this.lblDotFaxMyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFaxMypTitle
            // 
            this.lblFaxMypTitle.AutoSize = true;
            this.lblFaxMypTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxMypTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxMypTitle.Location = new System.Drawing.Point(28, 58);
            this.lblFaxMypTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFaxMypTitle.Name = "lblFaxMypTitle";
            this.lblFaxMypTitle.Size = new System.Drawing.Size(80, 19);
            this.lblFaxMypTitle.TabIndex = 4;
            this.lblFaxMypTitle.Text = "傳真 :";
            this.lblFaxMypTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaxMypValue
            // 
            this.lblFaxMypValue.AutoSize = true;
            this.lblFaxMypValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxMypValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxMypValue.Location = new System.Drawing.Point(114, 54);
            this.lblFaxMypValue.Name = "lblFaxMypValue";
            this.lblFaxMypValue.Size = new System.Drawing.Size(289, 27);
            this.lblFaxMypValue.TabIndex = 5;
            this.lblFaxMypValue.Text = "02-2799-2556";
            this.lblFaxMypValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine1
            // 
            this.pnlLine1.AutoSize = true;
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine1.Location = new System.Drawing.Point(3, 139);
            this.pnlLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(406, 1);
            this.pnlLine1.TabIndex = 6;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCopyright.Location = new System.Drawing.Point(3, 236);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(406, 143);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright © 木研科技有限公司 \r\n2019 All rights reserved. Design by Keynes Lu.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSupportHar
            // 
            this.tlpSupportHar.AutoSize = true;
            this.tlpSupportHar.ColumnCount = 3;
            this.tlpSupportHar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupportHar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupportHar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupportHar.Controls.Add(this.lblPhoneHarValue, 2, 0);
            this.tlpSupportHar.Controls.Add(this.lblDotPhoneHar, 0, 0);
            this.tlpSupportHar.Controls.Add(this.lblPhoneHarTitle, 1, 0);
            this.tlpSupportHar.Controls.Add(this.lblDotFaxHar, 0, 1);
            this.tlpSupportHar.Controls.Add(this.lblFaxHarTitle, 1, 1);
            this.tlpSupportHar.Controls.Add(this.lblFaxHarValue, 2, 1);
            this.tlpSupportHar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupportHar.Location = new System.Drawing.Point(3, 166);
            this.tlpSupportHar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSupportHar.Name = "tlpSupportHar";
            this.tlpSupportHar.RowCount = 2;
            this.tlpSupportHar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportHar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupportHar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSupportHar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSupportHar.Size = new System.Drawing.Size(406, 54);
            this.tlpSupportHar.TabIndex = 8;
            // 
            // lblPhoneHarValue
            // 
            this.lblPhoneHarValue.AutoSize = true;
            this.lblPhoneHarValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneHarValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneHarValue.Location = new System.Drawing.Point(82, 0);
            this.lblPhoneHarValue.Name = "lblPhoneHarValue";
            this.lblPhoneHarValue.Size = new System.Drawing.Size(321, 27);
            this.lblPhoneHarValue.TabIndex = 0;
            this.lblPhoneHarValue.Text = "02-2431-2626";
            this.lblPhoneHarValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotPhoneHar
            // 
            this.lblDotPhoneHar.AutoSize = true;
            this.lblDotPhoneHar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotPhoneHar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotPhoneHar.Location = new System.Drawing.Point(3, 4);
            this.lblDotPhoneHar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotPhoneHar.Name = "lblDotPhoneHar";
            this.lblDotPhoneHar.Size = new System.Drawing.Size(19, 19);
            this.lblDotPhoneHar.TabIndex = 0;
            this.lblDotPhoneHar.Text = "●";
            this.lblDotPhoneHar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneHarTitle
            // 
            this.lblPhoneHarTitle.AutoSize = true;
            this.lblPhoneHarTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneHarTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneHarTitle.Location = new System.Drawing.Point(28, 4);
            this.lblPhoneHarTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPhoneHarTitle.Name = "lblPhoneHarTitle";
            this.lblPhoneHarTitle.Size = new System.Drawing.Size(48, 19);
            this.lblPhoneHarTitle.TabIndex = 0;
            this.lblPhoneHarTitle.Text = "電話 :";
            this.lblPhoneHarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotFaxHar
            // 
            this.lblDotFaxHar.AutoSize = true;
            this.lblDotFaxHar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotFaxHar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotFaxHar.Location = new System.Drawing.Point(3, 31);
            this.lblDotFaxHar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotFaxHar.Name = "lblDotFaxHar";
            this.lblDotFaxHar.Size = new System.Drawing.Size(19, 19);
            this.lblDotFaxHar.TabIndex = 3;
            this.lblDotFaxHar.Text = "●";
            this.lblDotFaxHar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFaxHarTitle
            // 
            this.lblFaxHarTitle.AutoSize = true;
            this.lblFaxHarTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxHarTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxHarTitle.Location = new System.Drawing.Point(28, 31);
            this.lblFaxHarTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFaxHarTitle.Name = "lblFaxHarTitle";
            this.lblFaxHarTitle.Size = new System.Drawing.Size(48, 19);
            this.lblFaxHarTitle.TabIndex = 4;
            this.lblFaxHarTitle.Text = "傳真 :";
            this.lblFaxHarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaxHarValue
            // 
            this.lblFaxHarValue.AutoSize = true;
            this.lblFaxHarValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxHarValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxHarValue.Location = new System.Drawing.Point(82, 27);
            this.lblFaxHarValue.Name = "lblFaxHarValue";
            this.lblFaxHarValue.Size = new System.Drawing.Size(321, 27);
            this.lblFaxHarValue.TabIndex = 5;
            this.lblFaxHarValue.Text = "02-2431-1108";
            this.lblFaxHarValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llSupportMyp
            // 
            this.llSupportMyp.AutoSize = true;
            this.llSupportMyp.Location = new System.Drawing.Point(3, 0);
            this.llSupportMyp.Name = "llSupportMyp";
            this.llSupportMyp.Size = new System.Drawing.Size(179, 19);
            this.llSupportMyp.TabIndex = 10;
            this.llSupportMyp.TabStop = true;
            this.llSupportMyp.Text = "木研科技股份有限公司";
            this.llSupportMyp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSupportMyp_LinkClicked);
            // 
            // llSupportHar
            // 
            this.llSupportHar.AutoSize = true;
            this.llSupportHar.Location = new System.Drawing.Point(3, 143);
            this.llSupportHar.Name = "llSupportHar";
            this.llSupportHar.Size = new System.Drawing.Size(179, 19);
            this.llSupportHar.TabIndex = 11;
            this.llSupportHar.TabStop = true;
            this.llSupportHar.Text = "協核儀器企業有限公司";
            this.llSupportHar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlSupportHar_LinkClicked);
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.pbLogo, 0, 0);
            this.tlpLeft.Controls.Add(this.lblProduct, 0, 1);
            this.tlpLeft.Controls.Add(this.pnlLineLeft, 0, 2);
            this.tlpLeft.Controls.Add(this.tbSN, 0, 4);
            this.tlpLeft.Controls.Add(this.tlpVersion, 0, 3);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 5;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.Size = new System.Drawing.Size(335, 385);
            this.tlpLeft.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::LPS.Properties.Resources.LogoUniCalsonic2;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(3, 4);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(329, 290);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.PbLogo_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(3, 298);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(329, 24);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "友永標籤作業平台";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLineLeft
            // 
            this.pnlLineLeft.AutoSize = true;
            this.pnlLineLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLineLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLineLeft.Location = new System.Drawing.Point(3, 326);
            this.pnlLineLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLineLeft.Name = "pnlLineLeft";
            this.pnlLineLeft.Size = new System.Drawing.Size(329, 1);
            this.pnlLineLeft.TabIndex = 7;
            // 
            // tbSN
            // 
            this.tbSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSN.Font = new System.Drawing.Font("Arial", 11F);
            this.tbSN.Location = new System.Drawing.Point(3, 358);
            this.tbSN.MaxLength = 128;
            this.tbSN.Name = "tbSN";
            this.tbSN.ReadOnly = true;
            this.tbSN.Size = new System.Drawing.Size(329, 24);
            this.tbSN.TabIndex = 8;
            this.tbSN.Text = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX-XXXXX";
            // 
            // tlpVersion
            // 
            this.tlpVersion.AutoSize = true;
            this.tlpVersion.ColumnCount = 2;
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpVersion.Controls.Add(this.lblVersion, 0, 0);
            this.tlpVersion.Controls.Add(this.btnActivate, 1, 0);
            this.tlpVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVersion.Location = new System.Drawing.Point(0, 330);
            this.tlpVersion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVersion.Name = "tlpVersion";
            this.tlpVersion.RowCount = 1;
            this.tlpVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVersion.Size = new System.Drawing.Size(335, 25);
            this.tlpVersion.TabIndex = 9;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 11F);
            this.lblVersion.Location = new System.Drawing.Point(3, 4);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(289, 17);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "試用版剩餘 10 天";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnActivate
            // 
            this.btnActivate.AutoSize = true;
            this.btnActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivate.Font = new System.Drawing.Font("Arial", 9F);
            this.btnActivate.Location = new System.Drawing.Point(295, 0);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(0);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(40, 25);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "啟用";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // PageHelp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.tlpBase);
            this.Name = "PageHelp";
            this.Size = new System.Drawing.Size(765, 391);
            this.Load += new System.EventHandler(this.PageHelp_Load);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpSupportMyp.ResumeLayout(false);
            this.tlpSupportMyp.PerformLayout();
            this.tlpSupportHar.ResumeLayout(false);
            this.tlpSupportHar.PerformLayout();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpVersion.ResumeLayout(false);
            this.tlpVersion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlLineMiddle;
        private System.Windows.Forms.TableLayoutPanel tlpSupportMyp;
        private System.Windows.Forms.Label lblEmailMypTitle;
        private System.Windows.Forms.Label lblTelMypValue;
        private System.Windows.Forms.LinkLabel lnkLblMypEmail;
        private System.Windows.Forms.Label lblPhoneMypValue;
        private System.Windows.Forms.Label lblDotPhoneMyp;
        private System.Windows.Forms.Label lblDotTelMyp;
        private System.Windows.Forms.Label lblDotEmailMyp;
        private System.Windows.Forms.Label lblPhoneMypTitle;
        private System.Windows.Forms.Label lblTelMypTitle;
        private System.Windows.Forms.Label lblDotFaxMyp;
        private System.Windows.Forms.Label lblFaxMypTitle;
        private System.Windows.Forms.Label lblFaxMypValue;
        private System.Windows.Forms.TableLayoutPanel tlpSupportHar;
        private System.Windows.Forms.Label lblPhoneHarValue;
        private System.Windows.Forms.Label lblDotPhoneHar;
        private System.Windows.Forms.Label lblPhoneHarTitle;
        private System.Windows.Forms.Label lblDotFaxHar;
        private System.Windows.Forms.Label lblFaxHarTitle;
        private System.Windows.Forms.Label lblFaxHarValue;
        private System.Windows.Forms.Panel pnlLineLeft;
        private System.Windows.Forms.LinkLabel llSupportMyp;
        private System.Windows.Forms.LinkLabel llSupportHar;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TableLayoutPanel tlpVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnActivate;
    }
}
