using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// All the basic crud operations are defined in this class along with an additional operations i.e. get locality by Village or City.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class DepartmentDesignationBL
    {
        /// <summary>
        /// This Function is used to add new Department Designation to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentDesignation info)
        {
            return DepartmentDesignationDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Department Designation in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentDesignation info)
        {
            return DepartmentDesignationDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Department Designation from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentDesignation info)
        {
            return DepartmentDesignationDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Department Designation from Database.
        /// </summary>
        public static DepartmentDesignation GetDetails(int id)
        {
            return DepartmentDesignationDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Department Designations from Database.
        /// </summary>
        public static List<DepartmentDesignation> GetAll()
        {
            return DepartmentDesignationDA.GetAll() ;
        }
    }
}
