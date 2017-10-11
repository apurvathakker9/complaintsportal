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
    public class DepartmentXAreaOnDutyBL
    {
        /// <summary>
        /// This Function is used to add new DepartmentXAreaOnDuty to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentXAreaOnDuty info)
        {
            return DepartmentXAreaOnDutyDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added DepartmentXAreaOnDuty in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentXAreaOnDuty info)
        {
            return DepartmentXAreaOnDutyDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added DepartmentXAreaOnDuty from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentXAreaOnDuty info)
        {
            return DepartmentXAreaOnDutyDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the DepartmentXAreaOnDuty from Database.
        /// </summary>
        public static DepartmentXAreaOnDuty GetDetails(int id)
        {
            return DepartmentXAreaOnDutyDA.GetDetails(id);
        }

        public static DepartmentXAreaOnDuty GetByTime(int departmentId, DateTime timeOfDay)
        {
            return DepartmentXAreaOnDutyDA.GetByTime(departmentId, timeOfDay);
        }

        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAll()
        {
            return DepartmentXAreaOnDutyDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using location and department from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllByLocationAndDepartment(int localityId, int departmentId)
        {
            return DepartmentXAreaOnDutyDA.GetAllByLocationAndDepartment(localityId,departmentId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using department id from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllForDepartment(int departmentId)
        {
            return DepartmentXAreaOnDutyDA.GetAllForDepartment(departmentId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using locality id from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllForLocality(int localityId)
        {
            return DepartmentXAreaOnDutyDA.GetAllForLocality(localityId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using village id from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllForVillageId(int villageId)
        {
            return DepartmentXAreaOnDutyDA.GetAllForVillageId(villageId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using city id from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllForCity(int cityId)
        {
            return DepartmentXAreaOnDutyDA.GetAllForCity(cityId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentXAreaOnDuty using state id from Database.
        /// </summary>
        public static List<DepartmentXAreaOnDuty> GetAllForState(int stateId)
        {
            return DepartmentXAreaOnDutyDA.GetAllForState(stateId);
        }
    }
}
