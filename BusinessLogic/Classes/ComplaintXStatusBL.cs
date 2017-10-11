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
    public class ComplaintXStatusBL
    {
        /// <summary>
        /// This Function is used to add new ComplaintXStatus to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(ComplaintXStatus info)
        {
            return ComplaintXStatusDA.Add(info);
        }


        /// <summary>
        /// This Function is used to Update previously added ComplaintXStatus in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(ComplaintXStatus info)
        {
            return ComplaintXStatusDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added ComplaintXStatus from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(ComplaintXStatus info)
        {
            return ComplaintXStatusDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the ComplaintXStatus from Database.
        /// </summary>
        public static ComplaintXStatus GetDetails(int id)
        {
            return ComplaintXStatusDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the ComplaintXStatus from Database.
        /// </summary>
        public static List<ComplaintXStatus> GetAll()
        {
            return ComplaintXStatusDA.GetAll();
        }

        /// <summary>
        /// This Function is used to get the list of all the ComplaintXStatus using statusId from Database.
        /// </summary>
        public static List<ComplaintXStatus> GetAllByStatus(int statusId)
        {
            return ComplaintXStatusDA.GetAllByStatus(statusId);
        }
        /// <summary>
        /// This Function is used to get the list of all the ComplaintXStatus using complaintId from Database.
        /// </summary>
        public static List<ComplaintXStatus> GetAllByComplaint(int complaintId)
        {
            return ComplaintXStatusDA.GetAllByComplaint(complaintId);
        }
    }
}
