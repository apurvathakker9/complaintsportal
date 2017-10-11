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
    /// All the basic crud operations are defined in this class along with an additional operation.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class DepartmentXOfficialsBL
    {
        /// <summary>
        /// This Function is used to add new DepartmentXOfficials to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentXOfficial info)
        {
            return DepartmentXOfficialsDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added DepartmentXOfficials in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentXOfficial info)
        {
            return DepartmentXOfficialsDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added City from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentXOfficial info)
        {
            return DepartmentXOfficialsDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the DepartmentXOfficial from Database.
        /// </summary>
        public static DepartmentXOfficial GetDetails(int id)
        {
            return DepartmentXOfficialsDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the DepartmentXOfficial from Database.
        /// </summary>
        public static List<DepartmentXOfficial> GetAll()
        {
            return DepartmentXOfficialsDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXOfficial using username from Database.
        /// </summary>
        public static List<DepartmentXOfficial> GetAllByUsername(string userName)
        {
            return DepartmentXOfficialsDA.GetAllByUsername(userName);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXOfficial using department id from Database.
        /// </summary>
        public static List<DepartmentXOfficial> GetAllByDepartment(int departmentId)
        {
            return DepartmentXOfficialsDA.GetAllByDepartment(departmentId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXOfficial using official id from Database.
        /// </summary>
        public static List<DepartmentXOfficial> GetAllForOfficial(int officialId)
        {
            return DepartmentXOfficialsDA.GetAllForOfficial(officialId);
        }
    }
}
