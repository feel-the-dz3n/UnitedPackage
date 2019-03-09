using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedPackageLibrary
{
    public class Settings
    {
        public string ManagerPath
        {
            get
            {
                using (var k = Global.GetUnitedPackageReg())
                    return (string)k.GetValue("ManagerPath");
            }
        }

        public string DatabasePath
        {
            get
            {
                using (var k = Global.GetUnitedPackageReg())
                    return (string)k.GetValue("DatabasePath");
            }
        }
    }
}
