using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static string LicenseInfo()
        {
            string s = string.Empty;

            s += Environment.NewLine;
            s += Environment.NewLine;
            s += "MIT License. ModMan is free and open source. You are free to use, copy, modify, merge, publish, distribute, and sublicense it, provided the copyright notice and this permission notice are included in all copies. The software is provided \"as is\", without warranty of any kind. To view a copy of this license, visit";
            s += Environment.NewLine;
            s += Environment.NewLine;
            s += "https://opensource.org/license/mit";

            return s;
        }
    }
}
