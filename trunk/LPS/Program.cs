using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LPS.Model.DataAccessObject;
using LPS.Model.Log;
using LPS.View.Forms;

namespace LPS
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger.Info("LPS application booting.");

            //開啟資料庫;//
            DaoSQL.Instance.OpenDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //Application.Run(new FormLogin());
        }
    }
}
