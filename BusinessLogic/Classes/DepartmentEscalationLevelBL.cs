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
    public class DepartmentEscalationLevelBL
    {
        /// <summary>
        /// This Function is used to add new DepartmentEscalationLevel to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(DepartmentEscalationLevel info)
        {
            return DepartmentEscalationLevelDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added DepartmentEscalationLevel in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(DepartmentEscalationLevel info)
        {
            return DepartmentEscalationLevelDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added DepartmentEscalationLevel from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(DepartmentEscalationLevel info)
        {
            return DepartmentEscalationLevelDA.Delete(info);
        }


        /// <summary>
        /// This Function is used to get Details of the DepartmentEscalationLevel from Database.
        /// </summary>
        public static DepartmentEscalationLevel GetDetails(int id)
        {
            return DepartmentEscalationLevelDA.GetDetails(id);
        }

        public static DepartmentEscalationLevel GetDetailsByDepartmentId(int id, int LevelNumber)
        {
            return DepartmentEscalationLevelDA.GetDetailsByDepartmentId(id,LevelNumber);
        }

        /// <summary>
        /// This Function is used to get list of all the DepartmentEscalationLevel from Database.
        /// </summary>
        public static List<DepartmentEscalationLevel> GetAll()
        {
            return DepartmentEscalationLevelDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentEscalationLevel using department type from Database.
        /// </summary>
        public static List<DepartmentEscalationLevel> GetAllForDepartment(int departmentId)
        {
            return DepartmentEscalationLevelDA.GetAllForDepartment(departmentId);
        }
        /// <summary>
        /// This Function is used to get list of all the DepartmentEscalationLevel using department with its level from Database.
        /// </summary>
        public static List<DepartmentEscalationLevel> GetAllForDepartmentAndLevel(int departmentId, int levelNumber)
        {
            return DepartmentEscalationLevelDA.GetAllForDepartmentAndLevel( departmentId, levelNumber);
        }
    }
}
