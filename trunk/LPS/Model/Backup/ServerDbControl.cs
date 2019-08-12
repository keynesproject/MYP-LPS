using LPS.Model.DataAccessObject;
using LPS.Model.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPS.Model.Backup
{
    class ServerDbControl
    {
        public enum DbCheckState
        {
            eDB_FOUND,
            eDB_NOT_FOUND,
            eDB_PATH_ERROR,
            eDB_PATH_FIELD_EMPTY,
        }

        public static DbCheckState MyNetworkPlacesDbTest(out string ErrMsg)
        {
            ErrMsg = string.Empty;

            //檢查是否有設定Server DB的路徑位置;//
            string ServerPath = string.Empty;
            string serverDbPath = string.Empty;
            if (DaoSQL.Instance.CheckServerDbInfo(out ServerPath, out serverDbPath) == false)
                return DbCheckState.eDB_PATH_FIELD_EMPTY;
                        
            if (MyNetworkPlacesTest(ServerPath) == false)
                return DbCheckState.eDB_PATH_ERROR;

            DaoErrMsg Err = DaoSQL.Instance.CheckServerDb(serverDbPath);
            if (Err.isError == true)
            {
                ErrMsg = Err.ErrorMsg;
                return DbCheckState.eDB_NOT_FOUND;
            }

            return DbCheckState.eDB_FOUND;
        }

        private static bool MyNetworkPlacesTest(string ServerPath)
        {
            string Account = string.Empty;
            string PW = string.Empty;
            DaoSQL.Instance.GetServerAccount(out Account, out PW);

            NetTranslate.KillLink(ServerPath);

            if (NetTranslate.connectState(ServerPath, Account, PW) == false)
            {
                return false;
            }

            NetTranslate.KillLink(ServerPath);

            return true;
        }
    }
}
