using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MypKey
{
    public class MypSerialKeyValidator
    {
        #region public function

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="Product">產品名稱,用來區分註冊機碼路徑</param>
        public MypSerialKeyValidator(string Product = "")
        {
            m_Product = Product;
        }
        
        /// <summary>
        /// 建立試用期序號，並依照產品類別，儲存資訊到wisdows註冊機
        /// 當序號已被產生過，此Function會無作用，並回傳NULL
        /// </summary>
        /// <param name="TrialExp">試用日期,單位:天,範圍:0~999,0表示沒有試用期限</param>
        /// <returns>建立成功則回傳建立的序號，NULL表示建立失敗</returns>
        public string CreateTrialSerialKey(int TrialExp)
        {
            //若輸入天數大於999，則返回不作用;//
            if (TrialExp > 999 || TrialExp < 0)
                return null;

            //檢查註冊機碼是否有序號，有序號的話則不與重新建立;//
            if (this.GetExistKey() != null)
                return null;
            
            //表示不為空,依照設定的試用日期建立試用序號;//
            string SN = this.GenKey(TrialExp);

            //儲存serial Key資訊,剛建立時只先儲存至註冊表及使用者資料夾;//
            //不儲存至應用程式目錄是因為有可能是在安裝時呼叫此Function，造成資料儲存路徑錯誤;//
            SaveSnToRegistry(SN, true);
            SaveSnToAppData(SN, true);

            return SN;
        }
        
        /// <summary>
        /// 更新序號，當要輸入新的序號時須呼叫此Function
        /// </summary>
        /// <param name="SN">新序號</param>
        /// <returns></returns>
        public ValidateResult UpdateSerialKey(string SN)
        {
            //驗證序號完整的合法性;//
            ValidateResult Ret = this.ValidateKeyFull(SN, KeyPhase.Phase + KeyGold.Gold);
            if (Ret != ValidateResult.eVALIDATE_SUCCESS)
                return Ret;

            //更新儲存序號;//
            SaveSN(SN, true);

            return ValidateResult.eVALIDATE_SUCCESS;
        }
        
        /// <summary>
        /// 檢查註冊機碼，並驗證相關數值(合法性、是否到期、是否為本機適用序號)
        /// </summary>
        /// <returns></returns>
        public ValidateResult ValidateSerialKey()
        {
            //檢查序號是否存在,不存在則回傳失敗;//
            string SN = this.GetExistKey();
            if (SN == null)
            {
                //建立一組試用天數為30天序號;//
                SN = CreateTrialSerialKey(30);                
                //return ValidateResult.eVALIDATE_NO_SN;
            }

            //將此序號儲存至指定的目錄，此用意是防止使用者修改序號檔案資訊;//
            this.SaveSN(SN);

            //驗證序號;//
            ValidateResult Ret = this.ValidateKeyFull(SN, KeyPhase.Phase + KeyGold.Gold);
            if (Ret != ValidateResult.eVALIDATE_SUCCESS)
                return Ret;

            return ValidateResult.eVALIDATE_SUCCESS;
        }

        /// <summary>
        /// 取得現有儲存的序號
        /// </summary>
        /// <returns></returns>
        public string GetSerialKey()
        {
            string SN = GetExistKey();

            if (SN == null)
            {
                //表示序號為空的，建立一組試用天數為30天序號;//
                //這邊有待處理，因為如果使用者刪除全部的序號資料，則可以無限期的使用下去，只要使用前先刪除序號即可;//
                return CreateTrialSerialKey(30);
            }

            //將此序號儲存至指定的目錄，此用意是防止使用者修改序號檔案資訊;//
            this.SaveSN(SN);

            return SN;
        }

        /// <summary>
        /// 回傳本機儲存的序號剩餘可試用天數,
        /// </summary>
        /// <returns>
        /// 小於0天，表示無序號
        /// 大於999天，表示為無限期使用
        /// 0~999，表示剩餘可用天數
        /// </returns>
        public int GetTrialExp()
        {
            string SN = this.GetExistKey();

            //判斷有無序號,回傳-1;//
            if (SN == null)
                return -1;

            KeyValidate Validator = new KeyValidate();
            Validator.secretPhase = KeyPhase.Phase + KeyGold.Gold;
            Validator.Key = SN;            

            //序號驗證錯誤，回傳0天使用期限;//
            if (Validator.IsValid == false)
                return 0;

            //驗證機械碼錯誤，回傳0天使用期;//
            if (Validator.IsOnRightMachine == false)
                return 0;

            //序號已到期，回傳0天使用期限;//
            if (Validator.IsExpired == true)
                return 0;
            
            //回傳剩餘天數;//
            return Validator.DaysLeft;
        }

        /// <summary>
        /// 回傳指定序號可試用天數
        /// </summary>
        /// <param name="SN">要驗證的序號</param>
        /// <returns>
        /// 小於0天，表示無序號
        /// 大於999天，表示為無限期使用
        /// 0~999，表示剩餘可用天數
        /// </returns>
        public int GetTrialExp(string SN)
        {            
            KeyValidate Validator = new KeyValidate();
            Validator.secretPhase = KeyPhase.Phase + KeyGold.Gold;
            Validator.Key = SN;

            if (Validator.IsValid == false)
                return 0;

            if (Validator.IsOnRightMachine == false)
                return 0;

            return Validator.DaysLeft;
        }

        /// <summary>
        /// 驗證指定序號的合法性，驗證合法性及機械碼，不驗證日期
        /// </summary>
        /// <param name="SN">要驗證的序號</param>
        /// <returns></returns>
        public bool ValidateKey(string SN)
        {
            if (SN == null 
                || SN.Length <= 0)
                return false;

            KeyValidate Validator = new KeyValidate();
            Validator.secretPhase = KeyPhase.Phase + KeyGold.Gold;
            Validator.Key = SN;

            //驗證合法性性;//
            if (Validator.IsValid == false)
                return false;

            //驗證是否為相同的機械碼;//
            if (Validator.IsOnRightMachine == false)
                return false;

            return true;
        }

        internal KeyValidate ValidateGenKey(string SN)
        {
            KeyValidate Validator = new KeyValidate();
            Validator.secretPhase = KeyPhase.Phase + KeyGold.Gold;
            Validator.Key = SN;

            return Validator;
        }

        #endregion

        #region private function

        /// <summary>
        /// 產生序號
        /// </summary>
        /// <param name="ExpireDay"></param>
        /// <returns></returns>
        internal string GenKey(int ExpireDay)
        {
            //初始化方式不可按照visual studio建議的減化方式，否則建立出來的序號機械碼解碼出來後不會正確;//
            KeyGenerate GenKey = new KeyGenerate();
            GenKey.secretPhase = KeyPhase.Phase + KeyGold.Gold;

            return GenKey.doKey(ExpireDay, DateTime.Now, GenKey.MachineCode);
        }

        /// <summary>
        /// 產生序號
        /// </summary>        
        /// <param name="ExpireDay">期限</param>
        /// <param name="MachineCode">PC的機械碼，5位數</param>
        /// <returns></returns>
        public string GenKey(int ExpireDay, int MachineCode = 0)
        {
            KeyGenerate GenKey = new KeyGenerate();
            GenKey.secretPhase = KeyPhase.Phase + KeyGold.Gold;

            if (MachineCode == 0)
                return GenKey.doKey(ExpireDay, DateTime.Now, GenKey.MachineCode);
            else
                return GenKey.doKey(ExpireDay, DateTime.Now, MachineCode);
        }

        /// <summary>
        /// 驗證序號完整性，包括1.序號格式 2.綁定PC機械碼 3.是否過期
        /// </summary>
        /// <param name="SN"></param>
        /// <param name="GoldKey">解密金鑰</param>
        /// <returns></returns>
        private ValidateResult ValidateKeyFull(string SN, string GoldKey)
        {
            KeyValidate Validator = new KeyValidate();
            Validator.secretPhase = GoldKey;
            Validator.Key = SN;

            //先驗證序號合不合法;//
            if (Validator.IsValid == false)
                return ValidateResult.eVALIDATE_SN_INVALID;

            //驗證是否為同台機械碼;//
            if (Validator.IsOnRightMachine == false)
                return ValidateResult.eVALIDATE_NOT_RIGHT_MACHINE;

            //驗證是否過期;//
            if (Validator.IsExpired == true)
                return ValidateResult.eVALIDATE_EXPIRED;

            return ValidateResult.eVALIDATE_SUCCESS;
        }

        /// <summary>
        /// 取得現有合法的序號,儲存序號的地方共有三個,檔名為Serial Key
        /// 1.註冊機馬表:(64位元)HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MYP\Product_Name
        ///            (32位元)HKEY_LOCAL_MACHINE\SOFTWARE\MYP\Product_Name
        /// 2.c:\Users\UserName\AppData\Roaming
        /// 3.應用程式安裝目錄\Data\Config
        /// </summary>
        /// <returns></returns>
        private string GetExistKey()
        {
            string SerialKey = null;

            //檢查並驗證註冊機碼是否有序號;//
            SerialKey = GetKeyFromRegistry();
            if (   SerialKey != null
                && this.ValidateKey(SerialKey) == true)
            {
                return SerialKey;
            }

            //檢查使用者資料夾是否有序號資料;//
            SerialKey = GetKeyFromAppData();
            if (   SerialKey != null
                && this.ValidateKey(SerialKey) == true)
            {
                return SerialKey;
            }

            //檢查檔案目錄下是否有序號資料;//
            SerialKey = GetKeyFromApplication();
            if (   SerialKey != null
                && this.ValidateKey(SerialKey) == true)
            {
                return SerialKey;
            }

            return null;
        }

        /// <summary>
        /// 取得註冊機碼下的Serial Key
        /// </summary>
        /// <returns></returns>
        private string GetKeyFromRegistry()
        {
            RegistryKey Product = Registry.LocalMachine.OpenSubKey(RegistryPath, true);
            if (Product != null)
            {
                //判斷現在是否有註冊機碼，這邊不驗證SN正確性;//
                if (Product.GetValue(m_RegistrySN) == null)
                {
                    Product.Close();
                    return null;
                }

                string ExistSN = Product.GetValue(m_RegistrySN).ToString();
                if (ExistSN.Length >= 0)
                {
                    Product.Close();
                    return ExistSN;
                }
                Product.Close();
            }

            return null;
        }

        /// <summary>
        /// 取得AppData下已儲存的序號
        /// </summary>
        /// <returns></returns>
        private string GetKeyFromAppData()
        {
            return this.GetKeyFromGivePath(this.AppDataPath);
        }

        /// <summary>
        /// 取得程式安裝目錄下的序號
        /// </summary>
        /// <returns></returns>
        private string GetKeyFromApplication()
        {
            return GetKeyFromGivePath(this.ApplicationPath);
        }

        /// <summary>
        /// 取得指定目錄下的Serial No
        /// </summary>
        /// <param name="KeyDir"></param>
        /// <returns></returns>
        private string GetKeyFromGivePath(string KeyDir)
        {
            //檢查資料夾是否存在;//
            if (Directory.Exists(KeyDir) == false)
                return null;

            string FileFullPath = string.Format(@"{0}\{1}", KeyDir, m_KeyFileName);

            //檢查指定檔案是否存在;//
            if (File.Exists(FileFullPath) == false)
                return null;

            IniManager KeyIni = new IniManager(FileFullPath);
            return KeyIni.Read( m_RegistrySN, m_KeyIniSettion);
        }

        /// <summary>
        /// 記錄序號資訊,儲存序號的地方共有三個,檔名開頭為Serial Key
        /// 1.註冊機馬表:(64位元)HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MYP\Product_Name
        ///            (32位元)HKEY_LOCAL_MACHINE\SOFTWARE\MYP\Product_Name
        /// 2.c:\Users\UserName\AppData\Roaming
        /// 3.應用程式安裝目錄\Data\Config
        /// </summary>
        /// <param name="SN"></param>
        private void SaveSN(string SN, bool IsUpdateDate = false)
        {
            //將資訊記錄至註冊機碼表;//
            this.SaveSnToRegistry(SN, IsUpdateDate);

            //另存一份資訊至APP DATA;//
            this.SaveSnToAppData(SN, IsUpdateDate);

            //另存一份至安裝目錄;//
            this.SaveSnToApplication(SN, IsUpdateDate);
        }

        /// <summary>
        /// 儲存SN資訊至註冊機碼表，路徑: 
        ///  (64位元)HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MYP\Product Name
        ///  (32位元)HKEY_LOCAL_MACHINE\SOFTWARE\MYP\Product Name
        /// </summary>
        /// <param name="SN"></param>
        private void SaveSnToRegistry(string SN, bool IsUpdateDate = false)
        {
            RegistryKey RegistryProduct = Registry.LocalMachine.CreateSubKey(RegistryPath);
            RegistryProduct.SetValue(m_RegistrySN, SN);
            if (IsUpdateDate == true)
                RegistryProduct.SetValue(m_RegistryInstallDate, DateTime.Now.ToString(m_DateFormat));
            RegistryProduct.Close();
        }

        /// <summary>
        /// 儲存SN資訊至使用者資料夾
        /// EX:c:\Users\UserName\AppData\Roaming
        /// </summary>
        /// <param name="SN"></param>
        private void SaveSnToAppData(string SN, bool IsUpdateDate = false)
        {
            this.SaveSNToGivePath( SN, this.AppDataPath, IsUpdateDate);
        }

        /// <summary>
        /// 儲存SN資訊至使用者安裝目錄
        /// EX:C:\Program Files (x86)\MYP\LPS\Data\Config
        /// </summary>
        private void SaveSnToApplication(string SN, bool IsUpdateDate = false)
        {
            this.SaveSNToGivePath( SN, this.ApplicationPath, IsUpdateDate);
        }

        /// <summary>
        /// 儲存SN資訊至指定目錄
        /// </summary>
        /// <param name="SN"></param>
        /// <param name="SaveDir">儲存檔案的目錄路徑</param>
        private void SaveSNToGivePath(string SN, string SaveDir, bool IsUpdateDate = false)
        {
            //先檢查目標資料夾存不存在;//
            try
            {
                if (Directory.Exists(SaveDir) == false)
                {
                    //建立指定目錄;//
                    Directory.CreateDirectory(SaveDir);
                }
            }
            catch(Exception)
            {
                //表示無法順利建立目錄;//
                return;
            }

            //儲存資訊至指定路徑;//
            IniManager KeyIni = new IniManager(string.Format(@"{0}\{1}", SaveDir, m_KeyFileName));
            KeyIni.Write(m_RegistrySN, SN, m_KeyIniSettion);
            if (IsUpdateDate == true)
                KeyIni.Write(m_RegistryInstallDate, DateTime.Now.ToString(m_DateFormat), m_KeyIniSettion);
        }

        /// <summary>
        /// 刪除所有儲存Serial Key的資料
        /// </summary>
        private void DeleteAllKey()
        {
            //刪除註冊表機碼;//
            DeleteKeyInRegistry();

            //刪除AppData的檔案;//
            DeleteKeyInAppData();

            //刪除安裝目錄下的檔案;//
            DeleteKeyInApplication();
        }
        
        /// <summary>
        /// 刪除註冊表機碼
        /// </summary>
        private void DeleteKeyInRegistry()
        {
            RegistryKey RegistryProduct = Registry.LocalMachine.CreateSubKey(RegistryPath);
            if (RegistryProduct == null)
                return;

            if (RegistryProduct.ExistKey(m_RegistrySN))
                RegistryProduct.DeleteValue(m_RegistrySN);

            if (RegistryProduct.ExistKey(m_RegistryInstallDate))
                RegistryProduct.DeleteValue(m_RegistryInstallDate);

            RegistryProduct.Close();
        }

        /// <summary>
        /// 刪除AppData下的Serial Key目錄
        /// </summary>
        private void DeleteKeyInAppData()
        {            
            try
            {
                //先檢查指定目錄是否存在;//
                if (Directory.Exists(this.AppDataPath) == false)
                    return;

                //刪除目錄;//
                Directory.Delete(AppDataPath, true);
            }
            catch(Exception)
            {

            }
        }

        /// <summary>
        /// 刪除安裝目錄下的Serial Key檔案
        /// </summary>
        private void DeleteKeyInApplication()
        {
            string FileFullPath = string.Format(@"{0}\{1}", this.ApplicationPath, this.m_KeyFileName);

            try
            {
                //檢查檔案是否存在;//
                if (File.Exists(FileFullPath) == false)
                    return;

                File.Delete(FileFullPath);
            }
            catch(Exception)
            {

            }
        }

        #endregion

        #region private parameter

        /// <summary>
        /// 記錄產品名稱
        /// </summary>
        private string m_Product = string.Empty;

        /// <summary>
        /// 取得註冊機碼路徑
        /// </summary>
        private string RegistryPath
        {
            get
            {                
                return string.Format(@"SOFTWARE\MYP\{0}", m_Product);
            }
        }

        /// <summary>
        /// 取得使用者目錄的資料夾路徑
        /// </summary>
        private string AppDataPath
        {
            get
            {
                string UserAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return string.Format(@"{0}\MYP\{1}", UserAppDataPath, m_Product);
            }
        }

        /// <summary>
        /// 應用程式路徑
        /// </summary>
        private string ApplicationPath
        {
            get
            {
                return @".\Data\Config\";
            }
        }

        /// <summary>
        /// 註冊機碼表儲存序號的名稱
        /// </summary>
        private readonly string m_RegistrySN = "Serial Key";

        /// <summary>
        /// 註冊機碼表儲存日期的名稱
        /// </summary>
        private readonly string m_RegistryInstallDate = "Install Date";

        /// <summary>
        /// 儲存序號的ini資訊檔名，命名為dat是要混淆而已
        /// </summary>
        private readonly string m_KeyFileName = "Mypkey.dat";

        /// <summary>
        /// ini檔儲存的區塊
        /// </summary>
        private readonly string m_KeyIniSettion = "Config";

        /// <summary>
        /// 日期儲存格式
        /// </summary>
        private readonly string m_DateFormat = "yyyyMMddHHmmss";

        #endregion
    }
}
