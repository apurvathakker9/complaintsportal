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
    /// All the basic crud operations are defined in this class.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class DepartmentTypeBL
    {
        /// <summary>
        /// This Function is used to add new Department Type to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentType info)
        {
            return DepartmentTypeDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Department Type in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentType info)
        {
            return DepartmentTypeDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Department Type from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentType info)
        {
            return DepartmentTypeDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Department Type from Database.
        /// </summary>
        public static DepartmentType GetDetails(int id)
        {
            return DepartmentTypeDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Department Types from Database.
        /// </summary>
        public static List<DepartmentType> GetAll()
        {
            return DepartmentTypeDA.GetAll() ;
        }
    }
}
