using LIbraryManagmentSystem_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LIbraryManagmentSystem.Global_Classes
{
    public class clsGlobal
    {
        public delegate void RefreshObjects(clsUser user);
        static public RefreshObjects refreshObject;

        public static clsUser CurrentUser;
        public static string encryptipnKey
        {
            get
            {
                return "mkJIa7BeEfyfev9MQqGTgA==";
            }
        }
    }
}
