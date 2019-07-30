using MypKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MypSnGenerator
{
    public partial class FormMain : Form
    {
        private MypSerialKeyValidator m_KeyGen = new MypSerialKeyValidator("LPS");

        private KeyValidate m_CustomKeyValidate = null;

        private KeyValidate m_Verify = null;

        private string m_TextBoxInfo = "請先輸入客戶序號.";

        public FormMain()
        {
            InitializeComponent();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string Version = fvi.FileVersion;
            this.Text += string.Format(" - V{0} - MYP內部應用程式", Version);

            tbCustomSerialNo.Text = m_TextBoxInfo;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (m_CustomKeyValidate == null)
                return;

            if (tbCustomSerialNo.Text.Length <= 0)
                return;

            if (m_CustomKeyValidate.IsValid == false)
                return;

            tbVerificationCode.Text = m_KeyGen.GenKey(Convert.ToInt32(numVerifyDaysLeft.Value), m_CustomKeyValidate.DecodedMachineCode);

            m_Verify = m_KeyGen.ValidateGenKey(tbVerificationCode.Text);

            if (m_Verify.IsValid == false)
            {
                lblVerifyIsValidValue.Text = "X";

                lblVerifyIsValidValue.Visible = false;
                lblVerifyCreationDateValue.Visible = false;
                lblVerifyMachineCodeValue.Visible = false;
                lblVerifyExpiredDateValue.Visible = false;
            }
            else
            {
                lblVerifyIsValidValue.Text = "O";

                lblVerifyIsValidValue.Visible = true;
                lblVerifyCreationDateValue.Visible = true;
                lblVerifyMachineCodeValue.Visible = true;
                lblVerifyExpiredDateValue.Visible = true;

                lblVerifyCreationDateValue.Text = m_Verify.CreationDate.ToString("yyyy/MM/dd hh:mm:ss");
                lblVerifyExpiredDateValue.Text = m_Verify.ExpireDate.ToString("yyyy/MM/dd hh:mm:ss");
                lblVerifyMachineCodeValue.Text = m_Verify.DecodedMachineCode.ToString();
            }
        }

        private void btnCustomSN_Click(object sender, EventArgs e)
        {
            tbCustomSerialNo.Text = m_KeyGen.GenKey(30);

            //KeyValidate test = m_KeyGen.ValidateKey(tbCustomSerialNo.Text);
            //Console.WriteLine("Is Valid : " + test.IsValid);
            //Console.WriteLine("Expire Date : " + test.ExpireDate);
            //Console.WriteLine("Is On Right Machine : " + test.IsOnRightMachine);
        }

        private void tbCustomSerialNo_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomSerialNo.Text.Length <= 0)
                return;

            m_CustomKeyValidate = m_KeyGen.ValidateGenKey(tbCustomSerialNo.Text);

            lblCustomIsValidValue.Visible = true;

            if (m_CustomKeyValidate.IsValid == false)
            {
                lblCustomIsValidValue.Text = "X";

                lblCustomCreationDateValue.Visible = false;
                lblCustomMachineCodeValue.Visible = false;
                lblCustomIsExpiredValue.Visible = false;
                lblCustomExpiredDateValue.Visible = false;
                lblCustomDaysLeftValue.Visible = false;
            }
            else
            {
                lblCustomIsValidValue.Text = "O";

                lblCustomCreationDateValue.Visible = true;
                lblCustomMachineCodeValue.Visible = true;
                lblCustomIsExpiredValue.Visible = true;
                lblCustomExpiredDateValue.Visible = true;
                lblCustomDaysLeftValue.Visible = true;

                lblCustomIsExpiredValue.Text = m_CustomKeyValidate.IsExpired == false ? "O" : "X";
                lblCustomCreationDateValue.Text = m_CustomKeyValidate.CreationDate.ToString("yyyy/MM/dd hh:mm:ss");
                lblCustomExpiredDateValue.Text = m_CustomKeyValidate.ExpireDate.ToString("yyyy/MM/dd hh:mm:ss");
                lblCustomMachineCodeValue.Text = m_CustomKeyValidate.DecodedMachineCode.ToString();
                lblCustomDaysLeftValue.Text = m_CustomKeyValidate.DaysLeft.ToString();
            }
        }

        private void tbCustomSerialNo_Enter(object sender, EventArgs e)
        {
            if (tbCustomSerialNo.Text == m_TextBoxInfo)
            {
                tbCustomSerialNo.Text = "";
            }
        }

        private void tbCustomSerialNo_Leave(object sender, EventArgs e)
        {
            if (tbCustomSerialNo.Text.Length <= 0)
            {
                tbCustomSerialNo.Text = m_TextBoxInfo;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            m_KeyGen.DeleteAllKey();
        }
    }
}
