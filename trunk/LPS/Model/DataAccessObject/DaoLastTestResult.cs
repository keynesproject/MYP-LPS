using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.DataAccessObject
{
    /// <summary>
    /// 紀錄最後一次測試結果
    /// </summary>
    public class DaoLastTestResult
    {
        public bool isSuccess { get; set; }

        public DaoPartNumber PN { get; set; }

        public string Serial { get; set; }

        public DateTime TestTime { get; set; }
    }
}
