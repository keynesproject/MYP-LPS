using MypKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    internal class DaoSnControl
    {
        #region Singleton物件宣告

        private static readonly DaoSnControl m_instance = new DaoSnControl();

        internal static DaoSnControl Instance { get { return m_instance; } }

        #endregion

        /// <summary>
        /// 序號有更新事件通知Delegate
        /// </summary>
        internal delegate void UpdateSnDelegate(string SN, int ExpDay);

        /// <summary>
        /// 序號有更新事件通知
        /// </summary>
        internal event UpdateSnDelegate UpdateSnEvent;

        /// <summary>
        /// 序號驗證物件
        /// </summary>
        private MypSerialKeyValidator m_KeyGen = new MypSerialKeyValidator("LPS");

        /// <summary>
        /// 驗證本機序號
        /// </summary>
        /// <returns></returns>
        internal bool VerifyMachineSN()
        {
            if (m_KeyGen.ValidateSerialKey() == ValidateResult.eVALIDATE_SUCCESS)
                return true;

            return false;
        }

        /// <summary>
        /// 取得本機序號
        /// </summary>
        /// <returns></returns>
        internal string GetSN()
        {
            return m_KeyGen.GetSerialKey();
        }

        /// <summary>
        /// 取得序號剩餘天數
        /// </summary>
        /// <returns>        
        /// 小於0天，表示無序號
        /// 大於999天，表示為無限期使用
        /// 0~999，表示剩餘可用天數
        /// </returns>
        internal int GetTrialExp()
        {
            return m_KeyGen.GetTrialExp();
        }

        /// <summary>
        /// 驗證指定序號的合法性，驗證合法性及機械碼，不驗證日期
        /// </summary>
        /// <param name="SN">要驗證的序號</param>
        /// <returns></returns>
        internal bool VerifySN(string SN)
        {
            return m_KeyGen.ValidateKey(SN);
        }

        /// <summary>
        /// 更新序號，當要輸入新的序號時須呼叫此Function
        /// </summary>
        /// <param name="SN">新序號</param>
        /// <returns></returns>
        internal void UpdateSN(string SN)
        {
            if (m_KeyGen.UpdateSerialKey(SN) == ValidateResult.eVALIDATE_SUCCESS)
            {
                int ExpDay = GetTrialExp();
                //序號有更新事件通知;//
                UpdateSnEvent?.Invoke(SN, ExpDay);
            }
        }

    }
}
