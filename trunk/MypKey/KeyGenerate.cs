using System;

namespace MypKey
{
    internal class KeyGenerate : BaseConfiguration
    {
        //this class have to be inherited because of the key which is shared with both encryption/decryption classes.
        private SerialKeyConfiguration m_skc = new SerialKeyConfiguration();
        private methods m_methods = new methods();
        private Random m_random = new Random();

        internal KeyGenerate()
        {
            // No overloads works with Sub New
            m_random = new Random(DateTime.Now.Millisecond);
        }

        internal KeyGenerate(SerialKeyConfiguration _serialKeyConfiguration)
        {
            m_skc = _serialKeyConfiguration;
            m_random = new Random(DateTime.Now.Millisecond);
        }

        private string m_secretPhase;

        /// <summary>
        /// If the key is to be encrypted, enter a password here.
        /// </summary>
        internal string secretPhase
        {
            get { return m_secretPhase; }
            set
            {
                if ((value != m_secretPhase) && (!string.IsNullOrEmpty(value)))
                {
                    m_secretPhase = m_methods.twentyfiveByteHash(value);
                }
            }
        }

        private int m_numUsers;

        internal int numUsers
        {
            get { return m_numUsers; }
            set
            {
                m_numUsers = value;
            }
        }

        /// <summary>
        /// This function will generate a key.
        /// </summary>
        /// <param name="timeLeft">For instance, 30 days.</param>
        internal string doKey(int timeLeft, int users = 0, int assets = 0, int concurrentUsers = 0)
        {
            return doKey(timeLeft, DateTime.Now, users, assets, concurrentUsers); // removed extra argument false
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeLeft">For instance, 30 days</param>
        /// <param name="useMachineCode">Lock a serial key to a specific machine, given its "machine code". Should be 5 digits long.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        internal object doKey(int timeLeft, int useMachineCode, int users = 0, int assets = 0, int concurrentUsers = 0)
        {
            return doKey(timeLeft, DateTime.Now, useMachineCode, users, assets, concurrentUsers);
        }

        /// <summary>
        /// This function will generate a key. You may also change the creation date.
        /// </summary>
        /// <param name="timeLeft">For instance, 30 days.</param>
        /// <param name="creationDate">Change the creation date of a key.</param>
        /// <param name="useMachineCode">Lock a serial key to a specific machine, given its "machine code". Should be 5 digits long.</param>
        internal string doKey(int timeLeft, System.DateTime creationDate, int useMachineCode = 0, int users = 0, int assets = 0, int concurrentUsers = 0)
        {
            if (timeLeft > 999)
            {
                //Checking if the timeleft is NOT larger than 999..
                throw new ArgumentException("The timeLeft is larger than 999. It can only consist of three digits.");
            }
            if (users > 100000)
            {
                //Checking if the timeleft is NOT larger than 999. .
                throw new ArgumentException("Users is larger than 99,999. It can only consist of five digits.");
            }
            if (assets > 100)
            {
                //Checking if the timeleft is NOT larger than 999. .
                throw new ArgumentException("Assets is larger than 99. It can only consist of two digits.");
            }
            if (MachineCode > 99999)
            {
                //Checking if the timeleft is NOT larger than 999. .
                throw new ArgumentException("Machine ID is larger than 99999. It can only consist of five digits.");
            }
            if (concurrentUsers > 9999)
            {
                //Checking if the timeleft is NOT larger than 999. .
                throw new ArgumentException("concurrentUsers is larger than 9999. It can only consist of four digits.");
            }

            if (!string.IsNullOrEmpty(secretPhase) | secretPhase != null)
            {
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

            //if no exception is thown, do following
            string strStageThree = null;
            if (useMachineCode > 0 & useMachineCode <= 99999)
            {
                strStageThree = m_methods._encrypt(users, timeLeft, m_skc.Features, secretPhase, useMachineCode, creationDate, assets, concurrentUsers);
                // stage one
            }
            else
            {
                strStageThree = m_methods._encrypt(users, timeLeft, m_skc.Features, secretPhase, m_random.Next(0, 99999), creationDate, assets, concurrentUsers);
                // stage one
            }

            //if it is the same value as default, we do not need to mix chars. This step saves generation time.

            if (m_skc.addSplitChar == true)
            {
                // by default, a split character will be added - this loop adds a split at every 5 characters.
                Key = "";
                var i = 0;
                foreach (char c in strStageThree)
                {
                    if (i % 5 == 0 && i != 0)
                    {
                        Key = Key + "-";
                    }
                    Key = Key + c;
                    i++;
                }
            }
            else
            {
                Key = strStageThree;
            }

            //we also include the key in the Key variable to make it possible for user to get this key without generating a new one.
            return Key;
        }
    }
}
