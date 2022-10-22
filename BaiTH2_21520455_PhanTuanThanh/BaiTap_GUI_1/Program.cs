using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_GUI_1
{
    public class SinhVien
    {
        public string MSSV, Name, Class;
        public double Score;
    }

    public class CheckString : Exception
    {
        public CheckString() { }
        public static void ValidateMSSV(string str)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(str))
                throw new CheckString();
        }

        public static void ValidateClass(string str)
        {
            Regex regex = new Regex("^[0-9A-Za-z]+$");
            if (!regex.IsMatch(str))
                throw new CheckString();
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
}
