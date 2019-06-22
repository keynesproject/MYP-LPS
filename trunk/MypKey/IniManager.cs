using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace MypKey
{
    internal class IniManager
    {
        private string m_Path;
        private string m_EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        internal IniManager(string IniPath = null)
        {
            m_Path = new FileInfo(IniPath ?? m_EXE + ".ini").FullName.ToString();
        }

        internal string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? m_EXE, Key, "", RetVal, 255, m_Path);
            return RetVal.ToString();
        }

        internal void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? m_EXE, Key, Value, m_Path);
        }

        internal void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? m_EXE);
        }

        internal void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? m_EXE);
        }

        internal bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
