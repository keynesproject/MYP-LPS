using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LPS.Model.Extension;
using LPS.Model.Log;

namespace LPS.Model.DataAccessObject
{
    internal class DaoSQL
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly DaoSQL m_instance = new DaoSQL();

        internal static DaoSQL Instance { get { return m_instance; } }
                
        private DaoSQL()
        {
        }

        #endregion Singleton物件宣告

        #region event

        /// <summary>
        /// 資料庫連線狀態改變通知delegate
        /// </summary>
        public delegate void DatabaseConnectedChangeDelegate(bool isConnected);

        /// <summary>
        /// 資料庫連線狀態更新事件
        /// </summary>
        public event DatabaseConnectedChangeDelegate DatabaseConnectedChange;
        
        #endregion event

        /// <summary>
        /// 資料庫讀取物件
        /// </summary>
        private DaoDbCommon m_SQL = null;

        /// <summary>
        /// 連接使用的資料庫
        /// </summary>
        internal DaoErrMsg OpenDatabase()
        {
            DaoErrMsg Msg = new DaoErrMsg();
            try
            {
                Msg = ConnectAccess();
                if (Msg.isError == true )
                {
                    Log.Logger.Error(string.Format("Connect SQL Server database error. Message:{0}", Msg.ErrorMsg));                    
                    //throw new NotImplementedException("System data fail. Please re-install application.");
                }
                else
                {
                    //檢查必要資料表是否存在;//
                    Msg = CheckDatabase();
                }
            }
            catch (Exception ex)
            {
                Msg.isError = true;
                Msg.ErrorMsg = string.Format("Connect SQL Server database throw exception. Message:{0}", ex.Message);
                Log.Logger.Error(Msg.ErrorMsg);
                return Msg;
            }

            return Msg;
        }

        /// <summary>
        /// 關閉資料庫連接
        /// </summary>
        internal void CloseDatabase()
        {
            if (m_SQL == null)
                return;

            m_SQL.Close();

            m_SQL = null;

            DatabaseConnectedChange?.Invoke(false);
        }

        /// <summary>
        /// 連接Access資料庫
        /// </summary>
        /// <returns></returns>
        private DaoErrMsg ConnectAccess()
        {
            DaoErrMsg Err = new DaoErrMsg();

            if (m_SQL != null)
            {
                //表示已開啟過;//
                return Err;
            }

            string ServerPath = DaoConfigFile.Instance.FileDatabase;
            string DbPW = "BIS";
            string strConnection = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Jet OLEDB:Database Password={1};",
                                                 ServerPath, DbPW);

            m_SQL = new DaoDbCommon(strConnection, new OleDbConnection());

            Err = m_SQL.Connect();

            if (Err.isError)
            {
                System.Diagnostics.Debug.WriteLine(Err.ErrorMsg);
                m_SQL = null;
                return Err;
            }

            DatabaseConnectedChange?.Invoke(true);

            return Err;
        }

        /// <summary>
        /// 照SQL語法取得Table資料
        /// </summary>
        /// <param name="Schema"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string Schema, params object[] Values)
        {
            DataTable Dt;
            DaoErrMsg Err = m_SQL.GetDataTable(Schema, out Dt, Values);

            if (Err.isError)
                return null;

            return Dt;
        }
        
        /// <summary>
        /// 檢查指定的資料表裡有沒有指定的欄位
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="FieldName"></param>
        /// <returns></returns>
        internal bool CheckFileld(string TableName, string FieldName)
        {
            string strSchema = "select * from " + TableName;

            DataTable Dt = GetDataTable(strSchema);

            if (Dt == null)
                return false;

            return Dt.Columns.Contains(FieldName);
        }              

        /// <summary>
        /// 檢查資料庫是否有必要的資料表，沒有的話就建立
        /// </summary>
        private DaoErrMsg CheckDatabase()
        {
            StringBuilder sbSchema = new StringBuilder();

            DaoErrMsg err = new DaoErrMsg();

            if (CheckFileld("機台資訊", "預設機台") == false)
            {
                sbSchema.Append(@"ALTER TABLE 機台資訊 ADD COLUMN 預設機台 VARCHAR(1) DEFAULT 'N'; ");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                if (err.isError == true)
                    return err;

                sbSchema.Init();
                sbSchema.Append(@"UPDATE 機台資訊 SET 預設機台='N';");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                if (err.isError == true)
                    return err;
            }

            if (CheckFileld("備份路徑", "Type") == false)
            {
                sbSchema.Init();
                sbSchema.Append("DROP TABLE 備份路徑;");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                if (err.isError == true)
                    return err;
                
                sbSchema.Init();
                sbSchema.Append(@"CREATE TABLE `備份路徑` (
                                        `Type` VarChar(15) DEFAULT '',
	                                    `ADDR` VarChar(50) WITH COMP );");
                err = m_SQL.ExecuteNonQuery(sbSchema.ToString());
                if (err.isError == true)
                    return err;

                sbSchema.Init();
                string strTable = "備份路徑";
                string strField = "[Type], [ADDR]";
                err = InsertData(strTable, strField, "'Local', ''");
                err = InsertData(strTable, strField, "'Server', ''");
                err = InsertData(strTable, strField, "'ServerAccount', ''");
                err = InsertData(strTable, strField, "'ServerPW', ''");
                err = InsertData(strTable, strField, "'Report', ''");
                err = InsertData(strTable, strField, "'Database', ''");
                if (err.isError == true)
                    return err;
            }

            return err;
        }

        /// <summary>
        /// 插入資料到指定的資料表
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Field"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private DaoErrMsg InsertData(string Table, string Field, string Value)
        {
            DaoErrMsg err = new DaoErrMsg();

            string strSchema = string.Format(@"INSERT INTO {0} ({1}) VALUES ({2});", Table, Field, Value);

            return m_SQL.ExecuteNonQuery(strSchema.ToString()); ;            
        }

        internal bool Login(string Account, string Password)
        {
            string strSchema = "select 代碼 from 作業員 where 代碼=@P0 and 密碼=@P1 and 權限='Y'";

            string UserID;
            DaoErrMsg Err = m_SQL.ExecuteScalar(strSchema, out UserID, Account, Password);

            if (Err.isError)
                return false;

            if (Err.isError)
                return false;

            if (UserID.Length <= 0)
                return false;

            if (int.Parse(UserID) <= 0)
                return false;

            return true;
        }

        /// <summary>
        /// 取的機器代碼資訊
        /// </summary>
        /// <returns>[機台代碼]</returns>
        internal List<DaoMachine> GetMachineNo()
        {
            string strSchema = @"SELECT * FROM 機台資訊 order by 機台代碼;";

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("Default", typeof(string));

            return dt.ToList<DaoMachine>().ToList();
        }

        /// <summary>
        /// 取得作業員姓名
        /// </summary>
        /// <returns></returns>
        internal List<DaoUser> GetUser()
        {
            string strSchema = @"SELECT * FROM 作業員 order by 代碼;";

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("Serial", typeof(string));
            dt.Columns.Add("Permission", typeof(bool));

            return dt.ToList<DaoUser>().ToList();
        }

        /// <summary>
        /// 取得作業員姓名
        /// </summary>
        /// <returns></returns>
        internal DaoUser GetUser(string Code)
        {
            string strSchema = string.Format("SELECT * FROM 作業員 WHERE 代碼='{0}';", Code);

            DataTable dt = GetDataTable(strSchema);

            if (dt.Rows.Count == 0)
                return null;

            dt.Columns.Add("Serial", typeof(string));
            dt.Columns.Add("Permission", typeof(bool));

            return dt.ToList<DaoUser>().ToList()[0];
        }

        /// <summary>
        /// 取得所有的件號資料
        /// </summary>
        /// <param name="PN"></param>
        /// <returns>[件號,車型,簡碼]</returns>
        internal List<DaoPartNumber> GetPartNumber()
        {
            string strSchema = "SELECT * FROM 車型資料 order by 件號";

            DataTable dt = GetDataTable(strSchema);

            return dt.ToList<DaoPartNumber>().ToList();
        }

        /// <summary>
        /// 取得指定的件號資料
        /// </summary>
        /// <param name="PN"></param>
        /// <returns>[件號,車型,簡碼]</returns>
        internal DaoPartNumber GetPartNumber(string PN)
        {
            string strSchema = string.Format(@"SELECT * FROM 車型資料 WHERE 件號='{0}';", PN);

            DataTable dt = GetDataTable(strSchema);

            if (dt.Rows.Count > 0)
                return dt.ToList<DaoPartNumber>().ToList()[0];

            return null;
        }

        /// <summary>
        /// 搜尋件號資訊
        /// </summary>
        /// <param name="Part">開頭字串</param>
        /// <returns></returns>
        internal DataTable SerachPartNumber(string Part)
        {
            string strSchema = string.Format(@"SELECT * FROM 車型資料 WHERE 件號 LIKE '{0}%'", Part);

            return GetDataTable(strSchema);
        }

        /// <summary>
        /// 儲存測試結果資訊
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="Machine"></param>
        /// <param name="User"></param>
        /// <param name="PN"></param>
        /// <param name="Result"></param>
        /// <param name="TestTime"></param>
        /// <returns></returns>
        internal DaoErrMsg SaveTestResult(string Serial, DaoMachine Machine, DaoUser User, DaoPartNumber PN, string Result, DateTime TestTime)
        {
            string ResultSerial = string.Format("{0}{1}{2}", Machine.機台代碼, PN.簡碼, Serial);

            string strSchema = string.Format(@"INSERT INTO 測試結果(流水號, 件號, 車型名稱, 生產日期, 生產時間, 測試結果, 作業員代碼)
                                                            VALUES('{0}','{1}','{2}','{3}','{3}','{4}','{5}');",
                                                             ResultSerial,
                                                             PN.件號,
                                                             PN.車型,
                                                             TestTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                                             Result,
                                                             User.代碼);

            return m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 判斷此機台代碼是否存在
        /// </summary>
        /// <param name="MachineCode"></param>
        /// <returns></returns>
        internal bool IsExistMachine(string MachineCode)
        {
            string strSchema = string.Format("SELECT * FROM 機台資訊 WHERE 機台代碼='{0}'", MachineCode);

            DataTable Dt = GetDataTable(strSchema);

            return Dt.Rows.Count > 0 ? true : false;
        }

        /// <summary>
        /// 更新機台資訊
        /// </summary>
        /// <param name="MacineCode"></param>
        /// <param name="isDefault"></param>
        /// <param name="Description"></param>
        internal void UpdateMachine(string MacineCode, bool isDefault, string Description)
        {
            if(isDefault == true)
            {
                //先將所有機台的預設值更新為N;//
                m_SQL.ExecuteNonQuery("UPDATE 機台資訊 SET 預設機台='N'");
            }

            string strSchema = string.Format("UPDATE 機台資訊 SET 預設機台='{0}', 描述='{1}' WHERE 機台代碼='{2}'",
                                              isDefault == true ? "Y" : "N",
                                              Description,
                                              MacineCode);

            m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 加入一筆新機台資訊
        /// </summary>
        /// <param name="MacineCode"></param>
        /// <param name="isDefault"></param>
        /// <param name="Description"></param>
        internal void AddMachine(string MacineCode, bool isDefault, string Description)
        {
            if (isDefault == true)
            {
                //先將所有機台的預設值更新為N;//
                m_SQL.ExecuteNonQuery("UPDATE 機台資訊 SET 預設機台='N'");
            }

            string strSchema = string.Format("INSERT INTO 機台資訊( [機台代碼], [預設機台], [描述]) VALUES('{0}','{1}','{2}')",
                                              MacineCode,
                                              isDefault == true ? "Y" : "N",
                                              Description );

            m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 刪除指定機台
        /// </summary>
        /// <param name="Machine"></param>
        /// <returns></returns>
        internal DaoErrMsg DeleteMachine(DaoMachine Machine)
        {
            string strSchema = string.Format("DELETE FROM 機台資訊 WHERE 機台代碼 = '{0}' ", Machine.機台代碼);

            return m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 判斷此PN是否存在
        /// </summary>
        /// <param name="PN"></param>
        /// <returns></returns>
        internal bool IsExistPN(string PN)
        {
            string strSchema = string.Format("SELECT * FROM 車型資料 WHERE 件號='{0}'", PN);

            DataTable Dt = GetDataTable(strSchema);

            return Dt.Rows.Count > 0 ? true : false;
        }

        /// <summary>
        /// 更新指定件號
        /// </summary>
        /// <param name="PN"></param>
        /// <param name="Car"></param>
        /// <param name="Code"></param>
        internal void UpdatePN(string PN, string Car, string Code)
        {
            string strSchema = string.Format("UPDATE 車型資料 SET 車型='{0}', 簡碼='{1}' WHERE 件號='{2}'",
                                              Car,
                                              Code,
                                              PN);

            m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 加入一筆新件號
        /// </summary>
        /// <param name="PN"></param>
        /// <param name="Car"></param>
        /// <param name="Code"></param>
        internal void AddPN(string PN, string Car, string Code)
        {
            string strSchema = string.Format("INSERT INTO 車型資料( [件號], [車型], [簡碼]) VALUES('{0}','{1}','{2}')",
                                              PN,
                                              Car,
                                              Code);

            m_SQL.ExecuteNonQuery(strSchema);
        }

        internal DaoErrMsg DeletePN(DaoPartNumber CarPN)
        {
            string strSchema = string.Format("DELETE FROM 車型資料 WHERE 件號 = '{0}' ", CarPN.件號);

            return m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 判斷此使用者代碼是否存在
        /// </summary>
        /// <param name="Serial"></param>
        /// <returns></returns>
        internal bool IsExistUser(string Serial)
        {
            string strSchema = string.Format("SELECT * FROM 作業員 WHERE 代碼='{0}'", Serial);

            DataTable Dt = GetDataTable(strSchema);

            return Dt.Rows.Count > 0 ? true : false;
        }

        /// <summary>
        /// 更新指定使用者
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="Name"></param>
        /// <param name="PW"></param>
        /// <param name="Admin"></param>
        internal void UpdateUser(string Serial, string Name, string PW, string Admin)
        {
            string strSchema = string.Format("UPDATE 作業員 SET 作業員姓名='{0}', 密碼='{1}', 權限='{2}' WHERE 代碼='{3}'",
                                              Name,
                                              PW,
                                              Admin,
                                              Serial);

            m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 加入一筆使用者
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="Name"></param>
        /// <param name="PW"></param>
        /// <param name="Admin"></param>
        internal void AddUser(string Serial, string Name, string PW, string Admin)
        {
            string strSchema = string.Format("INSERT INTO 作業員( [代碼], [作業員姓名], [密碼], [權限]) VALUES('{0}', '{1}', '{2}', '{3}')",
                                              Serial,
                                              Name,
                                              PW,
                                              Admin);

            m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 刪除使用者
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        internal DaoErrMsg DeleteUser(DaoUser User)
        {
            string strSchema = string.Format("DELETE FROM 作業員 WHERE 代碼 = '{0}' ", User.代碼);

            return m_SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 取得測試時間區間的總數量
        /// </summary>
        /// <param name="DateSearchFrom"></param>
        /// <param name="DateSearchTo"></param>
        /// <returns></returns>
        internal int GetTestHistoryTotalNum(string DateSearchFrom, string DateSearchTo)
        {
            string strSchema = "select count(*) as TestTime from 測試結果 ";

            if (DateSearchFrom.Length > 0 || DateSearchTo.Length > 0)
            {
                strSchema += "WHERE ";
            }

            if (DateSearchFrom.Length > 0
                && DateSearchTo.Length > 0)
            {
                //搜尋日期區間;//
                //DateSearchFrom = Convert.ToDateTime(DateSearchFrom).ToStrTimeStamp();
                //DateSearchTo = Convert.ToDateTime(DateSearchTo).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 BETWEEN #{0}# and #{1}# ", DateSearchFrom, DateSearchTo);
            }
            else if (DateSearchFrom.Length > 0
                     && DateSearchTo.Length <= 0)
            {
                //搜尋大於起始日期;//
                //DateSearchFrom = Convert.ToDateTime(DateSearchFrom).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 >= #{0}# ", DateSearchFrom);
            }
            else if (   DateSearchFrom.Length <= 0
                     && DateSearchTo.Length > 0)
            {
                //搜尋小於結束日期;//
                //DateSearchTo = Convert.ToDateTime(DateSearchTo).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 <= #{0}# ", DateSearchTo);
            }

            string HistoryNum = "";
            m_SQL.ExecuteScalar(strSchema, out HistoryNum);

            //表示沒有歷史資訊;//
            if (HistoryNum.Length <= 0)
                return -1;

            return HistoryNum.ToInt();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m_DateSearchFrom"></param>
        /// <param name="m_DateSearchTo"></param>
        /// <returns></returns>
        internal DataTable GetTestHistory(string DateSearchFrom, string DateSearchTo)
        {
            //string strSchema = @"select RIGHT(流水號,7) as 序號, 
            //                            trim(format(生產日期,'yyyy/mm/dd')) as 日期, 
            //                            trim(format(生產時間,'hh:mm:ss')) as 時間, 
            //                            車型名稱 as 車型, 
            //                            作業員代碼 as 操作者代號, 
            //                            測試結果 as 判定 
            //                     from 測試結果 ";
            string strSchema = @"select 流水號 as 序號, 
                                        件號,
                                        trim(format(生產日期,'yyyy/mm/dd')) as 日期, 
                                        trim(format(生產時間,'hh:mm:ss')) as 時間, 
                                        車型名稱 as 車型, 
                                        作業員代碼 as 操作者代號, 
                                        測試結果 as 判定 
                                 from 測試結果 ";

            if (DateSearchFrom.Length > 0 || DateSearchTo.Length > 0)
            {
                strSchema += "WHERE ";
            }

            if (DateSearchFrom.Length > 0
                && DateSearchTo.Length > 0)
            {
                //搜尋日期區間;//
                //DateSearchFrom = Convert.ToDateTime(DateSearchFrom).ToStrTimeStamp();
                //DateSearchTo = Convert.ToDateTime(DateSearchTo).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 BETWEEN #{0}# AND #{1}# ", DateSearchFrom, DateSearchTo);
            }
            else if (DateSearchFrom.Length > 0
                     && DateSearchTo.Length <= 0)
            {
                //搜尋大於起始日期;//
                //DateSearchFrom = Convert.ToDateTime(DateSearchFrom).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 >= #{0}# ", DateSearchFrom);
            }
            else if (DateSearchFrom.Length <= 0
                     && DateSearchTo.Length > 0)
            {
                //搜尋小於結束日期;//
                //DateSearchTo = Convert.ToDateTime(DateSearchTo).ToStrTimeStamp();
                strSchema += string.Format(@"生產日期 <= #{0}# ", DateSearchTo);
            }

            strSchema += "ORDER BY 生產日期 DESC, 生產時間 DESC";

            return GetDataTable(strSchema);
        }

        /// <summary>
        /// 備分相關資料
        /// </summary>
        /// <returns></returns>
        internal DataTable GetBackupInfo()
        {
            string strSchema = "select * from 備份路徑";

            return GetDataTable(strSchema);
        }

        /// <summary>
        /// 更新備分路徑資訊
        /// </summary>
        /// <param name="dt"></param>
        internal void UpdateBackupInfo(DataTable dt)
        {
            for(int i=0; i<dt.Rows.Count; i++)
            {
                string strSchema = string.Format("UPDATE 備份路徑 SET ADDR='{0}' WHERE Type='{1}';", dt.Rows[i]["ADDR"].ToString(), dt.Rows[i]["Type"].ToString());
                DaoErrMsg err = m_SQL.ExecuteNonQuery(strSchema.ToString());
                if (err.isError == true)
                    return;
            }
        }
    }
}