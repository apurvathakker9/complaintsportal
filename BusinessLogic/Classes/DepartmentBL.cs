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
    public class DepartmentBL
    {
        /// <summary>
        /// This Function is used to add new Department to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(Department info)
        {
            return DepartmentDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Department in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(Department info)
        {
            return DepartmentDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Department from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(Department info)
        {
            return DepartmentDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Department from Database.
        /// </summary>
        public static Department GetDetails(int id)
        {
            return DepartmentDA.GetDetails(id);
        }

        public static Department GetDetailsByLocationAndType(int stateId, int cityId, int villageId, int localityId, int departmentTypeId)
        {
            return DepartmentDA.GetDetailsByLocationAndType(stateId, cityId, villageId, localityId, departmentTypeId);
        }

        /// <summary>
        /// This Function is used to get list of all the Department from Database.
        /// </summary>
        public static List<Department> GetAll()
        {
            return DepartmentDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the Department using username from Database.
        /// </summary>
        public static List<Department> GetAllByUseraname(string username)
        {
            return DepartmentDA.GetAllByUseraname(username);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using location or type of locations from Database.
        /// </summary>
        public static List<Department> GetAllByLocationAndType(int stateId, int cityId, int villageId, int localityId, int departmentTypeId)
        {
            return DepartmentDA.GetAllByLocationAndType(stateId, cityId, villageId, localityId, departmentTypeId);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using department type from Database.
        /// </summary>
        public static List<Department> GetAllByType(int departmentTypeId)
        {
            return DepartmentDA.GetAllByType(departmentTypeId);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using state Id  from Database.
        /// </summary>
        public static List<Department> GetAllByState(int stateId)
        {
            return DepartmentDA.GetAllByState(stateId);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using city Id  from Database.
        /// </summary>
        public static List<Department> GetAllByCity(int cityId)
        {
            return DepartmentDA.GetAllByCity(cityId);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using village Id  from Database.
        /// </summary>
        public static List<Department> GetAllByVillageId(int villageId)
        {
            return DepartmentDA.GetAllByVillageId( villageId);
        }
        /// <summary>
        /// This Function is used to get list of all the Department using locality Id  from Database.
        /// </summary>
        public static List<Department> GetAllByLocality(int localityId)
        {
            return DepartmentDA.GetAllByLocality(localityId);
        }
    }
}
