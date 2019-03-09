using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedPackageManager
{
    static class Program
    {
        static void Main(string[] args)
        {
            var error = UnitedPackageLibrary.Global.CheckHealth();
            if(error != null)
            {
                MessageBox.Show(error.Message, "United Package Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            if(args.Contains("--finish-install"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                new UnitedPackageManager.UI.InstallFinalize().ShowDialog();
            }
        }
    }
}
