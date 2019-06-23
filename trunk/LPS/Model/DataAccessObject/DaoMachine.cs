using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    /// <summary>
    /// 機台資訊
    /// </summary>
    public class DaoMachine
    {
        public string 機台代碼 { get; set; }

        public string 描述 { get; set; }
        
        public string 預設機台 { get; set; }

        public string Default
        {
            set { }
            get { return 預設機台.Equals("Y") ? "是" : "否"; }
        }
    }
}
