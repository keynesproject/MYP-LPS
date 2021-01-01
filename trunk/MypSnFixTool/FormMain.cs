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

namespace MypSnFixTool
{
    public partial class FormMain : Form
    {
        private MypSerialKeyValidator m_KeyGen = new MypSerialKeyValidator("LPS");

        private KeyValidate m_CustomKeyValidate = null;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            tbCurrentSN.Text = m_KeyGen.GetKeyFromRegistry();
        }

        private void BtnFixed_Click(object sender, EventArgs e)
        {
            //先產生一組序號;//
            string sn = m_KeyGen.GenKey(30);

            //取得此SN的機械碼;//
            m_CustomKeyValidate = m_KeyGen.ValidateGenKey(sn);
            string machineCode = m_CustomKeyValidate.DecodedMachineCode.ToString();

            //判斷是否為指定的電腦，不是的話不可使用此程式;//
            if (machineCode != tbGiveCPU.Text)
            {
                MessageBox.Show(this, "非指定電腦，不允許進行此操作!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //進行序號修復;//
            m_KeyGen.SaveSN(tbGiveSN.Text);

            //更新本機電腦資訊;//
            tbCurrentSN.Text = m_KeyGen.GetKeyFromRegistry();
        }

    }
}
