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
            s += "Attribution-NonCommercial-NoDerivatives 4.0 International (CC BY-NC-ND 4.0) This license requires that reusers give credit to the creator. It allows reusers to copy and distribute the material in any medium or format, for noncommercial purposes only. If others remix, adapt, or build upon the material, they may not distribute the modified material. To view a copy of this license, visit";
            s += Environment.NewLine;
            s += Environment.NewLine;
            s += "https://creativecommons.org/licenses/by-nc-nd/4.0";

            return s;
        }
    }
}
