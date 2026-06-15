using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisSystem
{
    internal static class UserSession
    {
        public static int EmployeeID { get; set; }
        public static string FullName { get; set; }
        public static string Position { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void ClearSession()
        {
            FullName = null;
            Position = null;
            EmployeeID = 0;
            IsLoggedIn = false;
        }

    }
}
