using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    static class Program
    {
        public static FileInfo[] ManagerFiles =
        {
            new FileInfo("UnitedPackageLibrary.dll"),
            new FileInfo("UnitedPackageManager.UI.dll"),
            new FileInfo("UnitedPackageManager.exe"),
            new FileInfo("upman.exe")
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
