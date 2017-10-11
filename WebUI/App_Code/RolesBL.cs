using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI
{


    /// <summary>
    /// Summary description for RolesBL
    /// </summary>
    public class RolesBL
    {
        public RolesBL()
        {
            //
            // TODO: Add constructor logic here
            //
            
        }

        public static List<Roles> GetAllRoles()
        {
            List<Roles> roleList = new List<Roles>();
            Roles roles = null;

            foreach(string rolename in System.Web.Security.Roles.GetAllRoles())
            {
                roles = new Roles();
                roles.Name = rolename;
                roleList.Add(roles);
            }

            return roleList;
        }

        public static List<Roles> GetUserInRoles(string username)
        {
            List<Roles> rolelist = new List<Roles>();
            Roles role = null;
            foreach (string rolename in System.Web.Security.Roles.GetRolesForUser(username))
            {
                role = new Roles();
                role.Name = rolename;
                rolelist.Add(role);
            }
            return rolelist;
        }
    }

    public class Roles
    {
        public string Name { get; set; }
    }
}