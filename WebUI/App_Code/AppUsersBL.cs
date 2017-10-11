using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI
{


    /// <summary>
    /// Summary description for AppUsersBL
    /// </summary>
    public class AppUsersBL
    {
        public AppUsersBL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static List<AppUser> GetAllUsers()
        {
            List<AppUser> userlist = new List<AppUser>();
            AppUser appuser = null;

            foreach(System.Web.Security.MembershipUser username in System.Web.Security.Membership.GetAllUsers())
            {
                appuser = new AppUser();
                appuser.Name = username.UserName;
                userlist.Add(appuser);
            }
            return userlist;
        }
    }

    public class AppUser
    {
        public string Name { get; set; }
    }
}