using LPS.Model.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPS.View.Forms
{
    public class FormSnVerify
    {
        /// <summary>
        /// 驗證序號，若序號驗證錯誤會顯示序號輸入視窗
        /// </summary>
        /// <returns></returns>
        public static bool VerifyMachineSN()
        {
            //驗證序號錯誤;//
            if (DaoSnControl.Instance.VerifyMachineSN() == false)
            {
                FormActivate AcitvateSnForm = new FormActivate();
                AcitvateSnForm.BringToFront();
                DialogResult Ret = AcitvateSnForm.ShowDialog();
                if (Ret != DialogResult.OK)
                    return false;
            }

            return true;
        }
    }
}
