using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            foreach(var file in Program.ManagerFiles)
                if(!file.Exists)
                {
                    MessageBox.Show("Seems like setup is corruped. Can't continue.\r\n\r\n(File " + file.Name + " not found.)", "United Package Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }

            InitializeComponent();
            ManagerPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "United Package");
            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "United Package", "Programs");
        }

        public string ManagerPath
        {
            get => (string)tbManagerPath.Tag;
            set
            {
                tbManagerPath.ReadOnly = false;
                tbManagerPath.Text = "Database: " + value;
                tbManagerPath.Tag = value;
                tbManagerPath.ReadOnly = true;
            }
        }

        public string DatabasePath
        {
            get => (string)tbDatabasePath.Tag;
            set
            {
                tbDatabasePath.ReadOnly = false;
                tbDatabasePath.Text = "Database: " + value;
                tbDatabasePath.Tag = value;
                tbDatabasePath.ReadOnly = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbManagerPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                f.SelectedPath = ManagerPath;
                f.Description = "Select Manager path";

                if (f.ShowDialog() == DialogResult.OK)
                    ManagerPath = f.SelectedPath;
            }
        }

        private void tbDatabasePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                f.SelectedPath = DatabasePath;
                f.Description = "Select Database path";

                if (f.ShowDialog() == DialogResult.OK)
                    DatabasePath = f.SelectedPath;
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            this.Hide();

            try
            {
                if (!Directory.Exists(ManagerPath))
                    Directory.CreateDirectory(ManagerPath);

                if (!Directory.Exists(DatabasePath))
                    Directory.CreateDirectory(DatabasePath);

                foreach(var file in Program.ManagerFiles)
                    file.CopyTo(Path.Combine(ManagerPath, file.Name), true);

                using (var reg = UnitedPackageLibrary.Global.GetUnitedPackageReg())
                {
                    reg.SetValue("ManagerPath", ManagerPath);
                    reg.SetValue("DatabasePath", DatabasePath);
                }

                Process.Start(Path.Combine(ManagerPath, "UnitedPackageManager.exe"), "--finish-install");

                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Can't Install United Package Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }
    }
}
