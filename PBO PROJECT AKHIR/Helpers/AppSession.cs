using Microsoft.VisualBasic.ApplicationServices;
using PBO_PROJECT_AKHIR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJECT_AKHIR.Helpers
{
    public class AppSession
    {
        public static User CurrentUser { get; set; }
        public static bool IsAuthenticated => CurrentUser != null;
        public static void SetUser(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
