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
    public class ComplaintTypeBL
    {
        /// <summary>
        /// This Function is used to add new ComplaintType to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(ComplaintType info)
        {
            return ComplaintTypeDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added ComplaintType in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(ComplaintType info)
        {
            return ComplaintTypeDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added ComplaintType from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(ComplaintType info)
        {
            return ComplaintTypeDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the ComplaintType from Database.
        /// </summary>
        public static ComplaintType GetDetails(int id)
        {
            return ComplaintTypeDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the ComplaintType from Database.
        /// </summary>
        public static List<ComplaintType> GetAll()
        {
            return ComplaintTypeDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the ComplaintType of department from Database.
        /// </summary>
        public static List<ComplaintType> GetAllForDepartment(int departmentId)
        {
            return ComplaintTypeDA.GetAllForDepartment(departmentId);
        }
    }
}
