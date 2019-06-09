using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    /// <summary>
    /// 作業員
    /// </summary>
    public class DaoUser
    {        
        public string 代碼 { get; set; }

        public string 作業員姓名 { get; set; }

        public string 密碼 { get; set; }

        public string 權限 { get; set; }

        public string Serial
        {
            set { }
            get { return 代碼 + " " + 作業員姓名; }
        }

        public bool Permission
        {
            set { }
            get { return 權限.Equals("Y") ? true : false;  }
        }
    }
}
