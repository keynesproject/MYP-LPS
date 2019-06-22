using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Management;

namespace MypKey
{
    #region CONFIGURATION

    public abstract class BaseConfiguration
    {
        //Put all functions/variables that should be shared with
        //all other classes that inherit this class.
        //
        //note, this class cannot be used as a normal class that
        //you define because it is MustInherit.

        protected internal string m_key = "";               

        internal static int MachineCodeMaxDigit
        {
            get { return 5; }
        }

        /// <summary>
        /// The key will be stored here
        /// </summary>
        internal virtual string Key
        {
            //will be changed in both generating and validating classe.
            get { return m_key; }
            set { m_key = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        internal int MachineCode
        {
            get
            {
                return BaseConfigParameter.Instance.MachineCode;
            }
        }
    }

    internal class SerialKeyConfiguration : BaseConfiguration
    {
        private bool[] _Features = new bool[8]
        {
            false,
            false,
            false,
            false,
            false,
            false,
            false,
            false
		    //the default value of the Fetures array.
	    };

        internal virtual bool[] Features
        {
            //will be changed in validating class.
            get { return _Features; }
            set { _Features = value; }
        }

        private bool m_addSplitChar = true;
        internal bool addSplitChar
        {
            get { return m_addSplitChar; }
            set { m_addSplitChar = value; }
        }        
    }

    #endregion

    #region Core Caculate method

    internal class methods : SerialKeyConfiguration
    {
        //The construction of the key
        protected internal string _encrypt(int _users, int _days, bool[] _tfg, string _secretPhase, int ID, System.DateTime _creationDate, int _assets = 0, int _concurrentUsers = 0)
        {
            // This function will store information in Artem's ISF-2
            Random rnd = new Random();
            int _retInt = Convert.ToInt32(_creationDate.ToString("yyyyMMdd"));
            // today
            string keygen = _retInt.ToString("D8");
            // adding the current date; the generation date; today.
            keygen += _days.ToString("D3");
            // adding time left
            keygen += booleanToInt(_tfg).ToString("D3");
            // adding features
            keygen += ID.ToString("D5");
            // adding machineID
            keygen += _users.ToString("D4");
            keygen += _assets.ToString("D3");
            keygen += _concurrentUsers.ToString("D4");
            //add a random number to the end to make a unique license - so that we could revoke it if we want to.
            keygen += rnd.Next(0, 10000).ToString("D5");
            // This part of the function uses Artem's SKA-2

            if (string.IsNullOrEmpty(_secretPhase) | _secretPhase == null)
            {
                // if not password is set, return an unencrypted key
                return base10ToBase36((getEightByteHash(keygen) + keygen));
            }
            else
            {
                // if password is set, return an encrypted 
                return base10ToBase36((getEightByteHash(keygen) + _encText(keygen, _secretPhase)));
            }
        }

        protected internal string _decrypt(string _key, string _secretPhase)
        {
            if (string.IsNullOrEmpty(_secretPhase) | _secretPhase == null)
            {
                // if not password is set, return an unencrypted key
                return base36ToBase10(_key);
            }
            else
            {
                // if password is set, return an encrypted 
                string usefulInformation = base36ToBase10(_key);
                return usefulInformation.Substring(0, 9) + _decText(usefulInformation.Substring(9), _secretPhase);
            }

        }
        //Deeper - encoding, decoding, et cetera.

        //Convertions, et cetera.----------------
        protected internal int booleanToInt(bool[] _booleanArray)
        {
            int _aVector = 0;
            //
            //In this function we are converting a binary value array to a int
            //A binary array can max contain 4 values.
            //Ex: new boolean(){1,1,1,1}
            for (int _i = 0; _i < _booleanArray.Length; _i++)
            {
                switch (_booleanArray[_i])
                {
                    case true:
                        _aVector += Convert.ToInt32((Math.Pow(2, (_booleanArray.Length - _i - 1))));
                        // times 1 has been removed
                        break;
                }
            }
            return _aVector;
        }

        protected internal bool[] intToBoolean(int _num)
        {
            //In this function we are converting an integer (created with privious function) to a binary array

            int _bReturn = Convert.ToInt32(Convert.ToString(_num, 2));
            string _aReturn = _bReturn.ToString("D8");
            bool[] _cReturn = new bool[8];
            for (int i = 0; i <= 7; i++)
            {
                _cReturn[i] = _aReturn.ToString().Substring(i, 1) == "1" ? true : false;
            }
            return _cReturn;
        }

        protected internal string _encText(string _inputPhase, string _secretPhase)
        {
            //in this class we are encrypting the integer array.
            string _res = "";

            for (int i = 0; i <= _inputPhase.Length - 1; i++)
            {
                _res += modulo(Convert.ToInt32(_inputPhase.Substring(i, 1)) + Convert.ToInt32(_secretPhase.Substring(modulo(i, _secretPhase.Length), 1)), 10);
            }

            return _res;
        }

        protected internal string _decText(string _encryptedPhase, string _secretPhase)
        {
            //in this class we are decrypting the text encrypted with the function above.
            string _res = "";

            for (int i = 0; i <= _encryptedPhase.Length - 1; i++)
            {
                _res += modulo(Convert.ToInt32(_encryptedPhase.Substring(i, 1)) - Convert.ToInt32(_secretPhase.Substring(modulo(i, _secretPhase.Length), 1)), 10);
            }

            return _res;
        }

        protected internal int modulo(int _num, int _base)
        {
            // canged return type to integer.
            //this function simply calculates the "right modulo".
            //by using this function, there won't, hopefully be a negative
            //number in the result!
            return _num - _base * Convert.ToInt32(Math.Floor((decimal)_num / (decimal)_base));
        }

        protected internal string twentyfiveByteHash(string s)
        {
            int amountOfBlocks = s.Length / 5;
            string[] preHash = new string[amountOfBlocks + 1];

            if (s.Length <= 5)
            {
                //if the input string is shorter than 5, no need of blocks! 
                preHash[0] = getEightByteHash(s).ToString();
            }
            else if (s.Length > 5)
            {
                //if the input is more than 5, there is a need of dividing it into blocks.
                for (int i = 0; i <= amountOfBlocks - 2; i++)
                {
                    preHash[i] = getEightByteHash(s.Substring(i * 5, 5)).ToString();
                }

                preHash[preHash.Length - 2] = getEightByteHash(s.Substring((preHash.Length - 2) * 5, s.Length - (preHash.Length - 2) * 5)).ToString();
            }
            return string.Join("", preHash);
        }

        protected internal int getEightByteHash(string s, int MUST_BE_LESS_THAN = 1000000000)
        {
            //This function generates a eight byte hash

            //The length of the result might be changed to any length
            //just set the amount of zeroes in MUST_BE_LESS_THAN
            //to any length you want
            uint hash = 0;

            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(s))
            {
                hash += b;
                hash += (hash << 10);
                hash ^= (hash >> 6);
            }

            hash += (hash << 3);
            hash ^= (hash >> 11);
            hash += (hash << 15);

            int result = (int)(hash % MUST_BE_LESS_THAN);
            int check = MUST_BE_LESS_THAN / result;

            if (check > 1)
            {
                result *= check;
            }

            return result;
        }

        //protected string licenseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890%$#@*&~";
        protected string m_licenseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        protected internal string base10ToBase36(string s)
        {
            // This method is converting a base 10 number to base 26 number.
            // Note that this method will still work, even though you only 
            // it is limited at 232 characters with a bigint.
            char[] allowedLetters = m_licenseCharacters.ToCharArray();
            var numletters = allowedLetters.Count();
            BigInteger num = BigInteger.Parse(s);
            int reminder = 0;

            char[] result = new char[s.ToString().Length + 1];
            int j = 0;


            while ((num >= numletters))
            {
                reminder = (int)(num % numletters);
                result[j] = allowedLetters[reminder];
                num = (num - reminder) / numletters;
                j += 1;
            }

            result[j] = allowedLetters[(int)(num)];
            // final calculation

            string returnNum = "";

            for (int k = j; k >= 0; k -= 1)  // not sure
            {
                returnNum += result[k];
            }
            return returnNum;

        }

        protected internal string base36ToBase10(string s)
        {
            // This function will convert a number that has been generated
            // with functin above, and get the actual number in decimal
            //
            // This function requieres Mega Math to work correctly.

            string allowedLetters = m_licenseCharacters;
            System.Numerics.BigInteger result = new System.Numerics.BigInteger();
            for (int i = 0; i <= s.Length - 1; i += 1)
            {
                BigInteger pow = powof(allowedLetters.Length, (s.Length - i - 1));
                result = result + allowedLetters.IndexOf(s.Substring(i, 1)) * pow;
            }

            return result.ToString(); //not sure
        }

        protected internal BigInteger powof(int x, int y)
        {
            // Because of the uncertain answer using Math.Pow and ^, 
            // this function is here to solve that issue.
            // It is currently using the MegaMath library to calculate.
            BigInteger newNum = 1;

            if (y == 0)
            {
                return 1;
                // if 0, return 1, e.g. x^0 = 1 (mathematicaly proven!) 
            }
            else if (y == 1)
            {
                return x;
                // if 1, return x, which is the base, e.g. x^1 = x
            }
            else
            {
                for (int i = 0; i <= y - 1; i++)
                {
                    newNum = newNum * x;
                }
                return newNum;
                // if both conditions are not satisfied, this loop
                // will continue to y, which is the exponent.
            }
        }
    }

    #endregion

    #region Core parameter

    internal class BaseConfigParameter
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly BaseConfigParameter m_Instance = new BaseConfigParameter();

        internal static BaseConfigParameter Instance { get { return m_Instance; } }

        #endregion

        /// <summary>
        /// 記錄已建立的本機Machine Code，避免重複運算機械碼造成效能下降
        /// </summary>
        private int m_MachineCode = -1;

        /// <summary>
        /// 取本機機械識別碼
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        internal int MachineCode
        {
            get
            {
                if (m_MachineCode <= 0)
                    m_MachineCode = getMachineCode();

                return m_MachineCode;
            }
        }

        private static int getMachineCode()
        {
            //This code will generate a 5 digits long key, finger print, of the system
            //where this method is being executed. However, that might be changed in the
            //hash function "GetStableHash", by changing the amount of zeroes in
            //MUST_BE_LESS_OR_EQUAL_TO to the one you want to have. Ex 1000 will return 
            //3 digits long hash.
            methods m = new methods();

            //string collectedInfo = System.Environment.MachineName;
            string collectedInfo = string.Empty;

            var x = new List<string>();

            //取得CPU ID;//
            ManagementObjectSearcher SearchCPU = new ManagementObjectSearcher(@"SELECT * FROM Win32_Processor");
            foreach (ManagementObject Win32ProcessObj in SearchCPU.Get())
            {
                // 取得CPU 序號
                if (Win32ProcessObj["ProcessorId"] != null)
                    x.Add(Win32ProcessObj["ProcessorId"].ToString());
            }
            x.Sort();
            collectedInfo += string.Join("", x);
            x.Clear();

            //取得Bios UUID;//
            ManagementObjectSearcher SearchSystemProduct = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_ComputerSystemProduct");
            foreach (ManagementObject SystemObj in SearchSystemProduct.Get())
            {
                if (SystemObj["UUID"] != null)
                {
                    x.Add(SystemObj["UUID"].ToString().Replace("-", ""));
                }
            }
            x.Sort();
            collectedInfo += string.Join("", x);
            x.Clear();

            //取得網卡MAC 碼;//
            //var Name = new List<string>();
            //foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            //{
            //    // probably need to do some filtering on ni.NetworkInterfaceType here
            //    //collectedInfo += ni.GetPhysicalAddress();
            //    x.Add(ni.GetPhysicalAddress().ToString());
            //    Name.Add(ni.Name);
            //}
            //x.Sort();
            //collectedInfo += x[x.Count - 1];
            //x.Clear();

            ManagementObjectSearcher SearchPhysicalMedia = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject wmi_HD in SearchPhysicalMedia.Get())
            {
                // get the hardware serial no.
                if (wmi_HD["SerialNumber"] == null
                    && wmi_HD["Removable"] == null
                    && wmi_HD["Replaceable"] == null)
                {
                    // Don't add
                }
                else
                {
                    //serialNo = wmi_HD["SerialNumber"].ToString();
                    //hotSwap = Convert.ToBoolean(wmi_HD["HotSwappable"]);
                    //Console.WriteLine(hotSwap);
                    x.Add(wmi_HD["SerialNumber"].ToString());
                }
            }
            x.Sort();
            collectedInfo += string.Join("", x);

            //表示都沒有取到設備的識別序號，直接給定一個值;//
            if (collectedInfo.Length <= 0)
                collectedInfo = "productmachine";
            int LessThan = Convert.ToInt32(Math.Pow(10, BaseConfiguration.MachineCodeMaxDigit));
            return m.getEightByteHash(collectedInfo, LessThan);
        }
    }

    #endregion

}
