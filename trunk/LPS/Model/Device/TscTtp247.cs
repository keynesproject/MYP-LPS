using LPS.Model.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LPS.Model.Device
{
    public class TscTtp247
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly TscTtp247 m_instance = new TscTtp247();

        internal static TscTtp247 Instance { get { return m_instance; } }

        #endregion

        private string m_LabelPrintName = "TSC TTP-247";

        public void PrintOK(string Serial, DaoMachine Machine, DaoPartNumber PN, DateTime TestTime)
        {
            if (TSCLIB_DLL.openport(m_LabelPrintName) == 0)
                return;

            string ResultSerial = string.Format("{0}{1}{2}", Machine.機台代碼, PN.簡碼, Serial);

            TSCLIB_DLL.setup("18", "12", "2", "7", "1", "3", "0");
            TSCLIB_DLL.clearbuffer();
            TSCLIB_DLL.sendcommand(string.Format("QRCODE 12,8,L,2,A,0,M2,S7,\"UCC,{0},{1}\"", ResultSerial, TestTime.ToString("yyyy/MM/dd")));
            TSCLIB_DLL.windowsfont(76, 11, 30, 0, 2, 0, "新細明體", "OK");
            TSCLIB_DLL.windowsfont(66, 40, 20, 0, 0, 0, "新細明體", TestTime.ToString("yy/MM/dd"));
            TSCLIB_DLL.windowsfont(5, 62, 20, 0, 0, 0, "新細明體", PN.車型);
            TSCLIB_DLL.printlabel("1", "1");

            TSCLIB_DLL.closeport();
        }

        public void PrintNG(DateTime TestTime)
        {
            if (TSCLIB_DLL.openport(m_LabelPrintName) == 0)
                return;

            TSCLIB_DLL.setup("18", "12", "2", "12", "1", "3", "0");
            TSCLIB_DLL.clearbuffer();
            TSCLIB_DLL.windowsfont(40, 3, 40, 0, 2, 0, "新細明體", "NG");
            TSCLIB_DLL.windowsfont(15, 40, 30, 0, 0, 0, "新細明體", TestTime.ToString("yy/MM/dd"));
            TSCLIB_DLL.printlabel("1", "1");

            TSCLIB_DLL.closeport();
        }

        public void PrintLabel(string Serial, DaoMachine Machine, DaoPartNumber PN, string Result, DateTime TestTime)
        {
            if (TSCLIB_DLL.openport(m_LabelPrintName) == 0)
                return;

            string ResultSerial = string.Format("{0}{1}{2}", Machine.機台代碼, PN.簡碼, Serial);

            TSCLIB_DLL.setup("18", "12", "2", "12", "1", "3", "0");
            TSCLIB_DLL.clearbuffer();
            TSCLIB_DLL.sendcommand(string.Format("QRCODE 12,8,L,2,A,0,M2,S7,\"UCC,{0},{1}\"", ResultSerial, TestTime.ToString("yyyy/MM/dd")));
            TSCLIB_DLL.windowsfont(76, 11, 30, 0, 2, 0, "新細明體", Result);
            TSCLIB_DLL.windowsfont(66, 40, 20, 0, 0, 0, "新細明體", TestTime.ToString("yy/MM/dd"));
            TSCLIB_DLL.windowsfont(5, 62, 20, 0, 0, 0, "新細明體", PN.車型);
            TSCLIB_DLL.printlabel("1", "1");

            TSCLIB_DLL.closeport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] result = System.Text.Encoding.GetEncoding("utf-16").GetBytes("unicode test");

            //TSCLIB_DLL.about();
            //TSCLIB_DLL.openport(m_LabelPrintName);
            //TSCLIB_DLL.sendcommand("SIZE 100 mm, 80 mm");
            //TSCLIB_DLL.sendcommand("SPEED 4");
            //TSCLIB_DLL.sendcommand("DENSITY 12");
            //TSCLIB_DLL.sendcommand("DIRECTION 1");
            //TSCLIB_DLL.sendcommand("SET TEAR ON");
            //TSCLIB_DLL.clearbuffer();
            //TSCLIB_DLL.barcode("10", "10", "128", "10", "1", "0", "2", "2", "Barcode Test");
            //TSCLIB_DLL.printerfont("10", "25", "3", "0", "1", "1", "Print Font Test");
            //TSCLIB_DLL.windowsfont(10, 30, 10, 0, 0, 0, "ARIAL", "Windows Arial Font Test");
            //TSCLIB_DLL.windowsfontUnicode(10, 35, 10, 0, 0, 0, "ARIAL", result);
            //TSCLIB_DLL.downloadpcx("UL.PCX", "UL.PCX");
            //TSCLIB_DLL.sendcommand("PUTPCX 100,400,\"UL.PCX\"");
            /////////////////////////////
        }
    }

    public class TSCLIB_DLL
    {
        [DllImport("TSCLIB.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport("TSCLIB.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport("TSCLIB.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport("TSCLIB.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport("TSCLIB.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport("TSCLIB.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport("TSCLIB.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport("TSCLIB.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport("TSCLIB.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport("TSCLIB.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport("TSCLIB.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);
        [DllImport("TSCLIB.dll", EntryPoint = "windowsfontUnicode")]
        public static extern int windowsfontUnicode(int x, int y, int fontheight,
                         int rotation, int fontstyle, int fontunderline,
                         string szFaceName, byte[] content);
    }
}
