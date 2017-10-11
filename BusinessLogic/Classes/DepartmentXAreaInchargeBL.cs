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
    public class DepartmentXAreaInchargeBL
    {
        /// <summary>
        /// This Function is used to add new DepartmentXAreaIncharge to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentXAreaIncharge info)
        {
            return DepartmentXAreaInchargeDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added DepartmentXAreaIncharge in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentXAreaIncharge info)
        {
            return DepartmentXAreaInchargeDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added DepartmentXAreaIncharge from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentXAreaIncharge info)
        {
            return DepartmentXAreaInchargeDA.Delete(info);
        }


        /// <summary>
        /// This Function is used to get Details of the DepartmentXAreaIncharge from Database.
        /// </summary>
        public static DepartmentXAreaIncharge GetDetails(int id)
        {
            return DepartmentXAreaInchargeDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAll()
        {
            return DepartmentXAreaInchargeDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge using department id from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAllForDepartment(int departmentId)
        {
            return DepartmentXAreaInchargeDA.GetAllForDepartment(departmentId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge using locality id from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAllForLocality(int localityId)
        {
            return DepartmentXAreaInchargeDA.GetAllForLocality(localityId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge using city id from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAllForCity(int cityId)
        {
            return DepartmentXAreaInchargeDA.GetAllForCity(cityId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge using State id from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAllForState(int stateId)
        {
            return DepartmentXAreaInchargeDA.GetAllForState(stateId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaIncharge using Village id from Database.
        /// </summary>
        public static List<DepartmentXAreaIncharge> GetAllForVillage(int villageId)
        {
            return DepartmentXAreaInchargeDA.GetAllForVillage(villageId);
        }
    }
}
