using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedPackageLibrary
{
    public class Global
    {
        public static Exception CheckHealth()
        {
            using (var key = GetUnitedPackageReg())
            {
                if (key.GetValue("ManagerPath", null) == null)
                    return new Exception("Manager path not found. Please, reinstall United Package Manager");

                if (key.GetValue("DatabasePath", null) == null)
                    return new Exception("Database path not found. Please, reinstall United Package Manager");
            }

            return null;
        }

		public static Microsoft.Win32.RegistryKey GetUnitedPackageReg()
        {
            return Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("United Package", true);
        }
    }
}
