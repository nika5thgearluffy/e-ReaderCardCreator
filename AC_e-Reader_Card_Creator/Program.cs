using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_e_Reader_Card_Creator
{
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
            Application.Run(new eReaderCCC());

            // Get the Windows Registry setting for the dark mode option
            object regValue = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) ?? "";

            // If "regValue" is not -1 (Not found), turn on dark mode
            if ((int)regValue != -1)
            {
                var eReaderCCCRef = new eReaderCCC();
                eReaderCCCRef.EnableDarkMode();
            }
        }
    }
}
