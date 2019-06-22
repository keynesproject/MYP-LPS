using System;

namespace MypKey 
{
    internal class KeyValidate : BaseConfiguration
    {
        //this class have to be inherited becuase of the key which is shared with both encryption/decryption classes.

        private SerialKeyConfiguration m_skc = new SerialKeyConfiguration();
        private methods m_methods = new methods();

        internal KeyValidate()
        {
            // No overloads works with Sub New
        }

        internal KeyValidate(SerialKeyConfiguration _serialKeyConfiguration)
        {
            m_skc = _serialKeyConfiguration;
        }

        /// <summary>
        /// Enter a key here before validating.
        /// </summary>
        internal override string Key
        {
            //re-defining the Key
            get
            {
                return m_key;
            }

            set
            {
                m_res = "";
                m_key = value;
            }
        }

        private string m_secretPhase = "";

        /// <summary>
        /// If the key has been encrypted, when it was generated, please set the same secretPhase here.
        /// </summary>
        internal string secretPhase
        {
            get { return m_secretPhase; }
            set
            {
                if ((value != m_secretPhase) && (!string.IsNullOrEmpty(value)))
                {
                    m_secretPhase = m_methods.twentyfiveByteHash(value);
                    m_res = "";
                }
            }
        }

        /// <summary>
        /// This is the decrypted, decoded key, is only set if the key has been processed, and is reset to blank if the key is changed.
        /// </summary>
        private string m_res = "";

        private void decodeKeyToString()
        {
            // checking if the key already have been decoded.
            if (string.IsNullOrEmpty(m_res) | m_res == null)
            {

                string _stageOne = "";

                Key = Key.Replace("-", "");

                //if the admBlock has been changed, the getMixChars will be executed.
                
                _stageOne = Key;

                // _stageTwo = _a._decode(_stageOne)

                if (!string.IsNullOrEmpty(secretPhase) | secretPhase != null)
                {
                    //if no value "secretPhase" given, the code will directly decrypt without using somekind of encryption
                    //if some kind of value is assigned to the variable "secretPhase", the code will execute it FIRST.
                    //the secretPhase shall only consist of digits!
                    System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("^\\d$");

                    //cheking the string
                    if (reg.IsMatch(secretPhase))
                    {
                        //throwing new exception if the string contains non-numrical letters.
                        throw new ArgumentException("The secretPhase consist of non-numerical letters.");
                    }
                }
                m_res = m_methods._decrypt(_stageOne, secretPhase);
            }
        }

        private bool _IsValid()
        {
            //Dim _a As New methods ' is only here to provide the geteighthashcode method
            try
            {
                if (string.IsNullOrEmpty(m_res))
                {
                    decodeKeyToString();
                    string _decodedHash = m_res.Substring(0, 9);
                    string _calculatedHash = m_methods.getEightByteHash(m_res.Substring(9, m_res.Length - 9)).ToString().Substring(0, 9);
                    // changed Math.Abs(_res.Substring(0, 17).GetHashCode).ToString.Substring(0, 8)

                    //When the hashcode is calculated, it cannot be taken for sure, 
                    //that the same hash value will be generated.
                    //learn more about this issue: http://msdn.microsoft.com/en-us/library/system.object.gethashcode.aspx
                    if (_decodedHash == _calculatedHash)
                    {
                        return true;
                    }
                    else
                    {
                        //reset the decoded string
                        m_res = "";
                        return false;
                    }
                }
                else
                {
                    //_res contains decrypted valid key - so this is valid
                    return true;
                }

            }
            catch (Exception)
            {
                //if something goes wrong, for example, when decrypting, 
                //this function will return false, so that user knows that it is unvalid.
                //if the key is valid, there won't be any errors.
                return false;
            }
        }

        /// <summary>
        /// Checks whether the key has been modified or not. If the key has been modified - returns false; if the key has not been modified - returns true.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return _IsValid();
            }
        }

        private bool _IsExpired()
        {
            if (DaysLeft > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// If the key has expired - returns true; if the key has not expired - returns false.
        /// </summary>
        internal bool IsExpired
        {
            get { return _IsExpired(); }
        }

        private System.DateTime _CreationDay()
        {
            if (this.IsValid)
            {
                System.DateTime _date = new System.DateTime();
                _date = new DateTime(Convert.ToInt32(m_res.Substring(9, 4)), Convert.ToInt32(m_res.Substring(13, 2)), Convert.ToInt32(m_res.Substring(15, 2)));
                return _date;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Returns the creation date of the key.
        /// </summary>
        internal System.DateTime CreationDate
        {
            get
            {
                if (IsValid)
                    return _CreationDay();
                else
                    return DateTime.MinValue;
            }
        }

        private int _DaysLeft()
        {
            int _setDays = SetTime;

            //建立日期時間大於本機電腦時間，表示使用者調過電腦本機時間，所以回傳時間剩餘0天，;//
            //大於1是用於時區不同的一天緩衝時間;//
            if (((TimeSpan)(CreationDate - DateTime.Today)).TotalDays > 1)
                return 0;

            return Convert.ToInt32(((TimeSpan)(ExpireDate - DateTime.Today)).TotalDays); //or viseversa
        }

        /// <summary>
        /// Returns the amount of days the key will be valid.
        /// </summary>
        internal int DaysLeft
        {
            get
            {
                if (IsValid)
                    return _DaysLeft();
                else
                    return 0;
            }
        }

        private int _ConcurrentUsers()
        {
            if (m_res.Length > 35)
                return Convert.ToInt32(m_res.Substring(35, 4));
            else //old license, no concurrent users.
                return 0;
        }

        internal int ConcurrentUsers
        {
            get
            {
                if (IsValid)
                    return _ConcurrentUsers();
                else
                    return 0;
            }
        }

        internal int MaxUsers
        {
            get
            {
                if (IsValid)
                    return _MaxUsers();
                else
                    return 0;
            }
        }

        private int _MaxUsers()
        {
            return Convert.ToInt32(m_res.Substring(28, 5));
        }

        internal int MaxAssets
        {
            get
            {
                if (IsValid)
                    return _MaxAssets();
                else
                    return 0;
            }
        }

        private int _MaxAssets()
        {
            return Convert.ToInt32(m_res.Substring(33, 2));
        }

        private int _SetTime()
        {
            return Convert.ToInt32(m_res.Substring(17, 3));
        }

        /// <summary>
        /// Returns the actual amount of days that were set when the key was generated.
        /// </summary>
        internal int SetTime
        {
            get
            {
                if (IsValid)
                    return _SetTime();
                else
                    return 0;
            }
        }

        private System.DateTime _ExpireDate()
        {
            if (IsValid)
            {
                System.DateTime _date = new System.DateTime();
                _date = CreationDate;
                if (SetTime > 0)
                {
                    return _date.AddDays(SetTime);
                }
                else
                {
                    return DateTime.MaxValue;
                }
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Returns the date when the key is to be expired.
        /// </summary>
        internal System.DateTime ExpireDate
        {
            get
            {
                return _ExpireDate();
            }
        }

        private bool[] _Features()
        {
            return m_methods.intToBoolean(Convert.ToInt32(m_res.Substring(20, 3)));
        }

        /// <summary>
        /// Returns all 8 features in a boolean array
        /// </summary>
        internal bool[] Features
        {
            //we already have defined Features in the BaseConfiguration class. 
            //Here we only change it to Read Only.
            get
            {
                if (IsValid)
                    return _Features();
                else
                    return new bool[] { false, false, false, false, false, false, false, false };
            }
        }

        internal int DecodedMachineCode
        {
            get
            {
                if (IsValid)
                {
                    return Convert.ToInt32(m_res.Substring(23, 5));
                }
                else
                    return -1;
            }
        }

        /// <summary>
        /// If the current machine's machine code is equal to the one that this key is designed for, return true.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        internal bool IsOnRightMachine
        {
            get
            {
                if (IsValid)
                {
                    int decodedMachineCode = Convert.ToInt32(m_res.Substring(23, 5));
                    return decodedMachineCode == MachineCode || decodedMachineCode == 1;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Valid: {0} \n Days Left: {1} \n Features: {2},{3},{4},{5},{6},{7},{8},{9} \n machine code: {10} \n current machine code:{11} \n Valid on machine: {12} \n Users: {13} \n Assets: {14}\n ConcurrentUsers: {15}\n",
                                        this.IsValid,
                                        this.DaysLeft,
                                        this.Features[0],
                                        this.Features[1],
                                        this.Features[2],
                                        this.Features[3],
                                        this.Features[4],
                                        this.Features[5],
                                        this.Features[6],
                                        this.Features[7],
                                        this.DecodedMachineCode,
                                        this.MachineCode,
                                        this.IsOnRightMachine,
                                        this.MaxUsers,
                                        this.MaxAssets,
                                        this.ConcurrentUsers);
        }

    }
}
