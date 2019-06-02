using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    public class DaoMachine
    {
        public string 機台代碼 { get; set; }

        public string 描述 { get; set; }

        
        public string Serial
        {
            set { }
            get { return 機台代碼; }
        }
    }
}
