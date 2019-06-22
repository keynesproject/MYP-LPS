using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MypKey
{
    public static class RegistryKeyExtension
    {
        /// <summary>
        /// 檢查指定的Key欄位是否存在
        /// </summary>
        /// <param name="Reg"></param>
        /// <param name="KeyName"></param>
        /// <returns></returns>
        public static bool ExistKey(this RegistryKey Reg, string KeyName)
        {
            return Reg.GetValue(KeyName) == null ? false : true;
        }
    }
}
