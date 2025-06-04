using LIbraryManagmentSystem_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryManagmentSystem_Business
{
    public class clsFineSettings
    {
        public static DataTable GetFineSettingInfo()
        {
            return clsFineSettingData.GetFineSettingsInfo();
        }
        public static bool UpdateFineSettings(DataTable dt)
        {
            return clsFineSettingData.UpdateFineSettings(dt);
        }
    }
}
