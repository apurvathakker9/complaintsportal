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
    public class ComplaintStatusBL
    {
        /// <summary>
        /// This Function is used to add new Complaint Status to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(ComplaintStatus info)
        {
            return ComplaintStatusDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Complaint Status in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(ComplaintStatus info)
        {
            return ComplaintStatusDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Complaint Status from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(ComplaintStatus info)
        {
            return ComplaintStatusDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Complaint Status from Database.
        /// </summary>
        public static ComplaintStatus GetDetails(int id)
        {
            return ComplaintStatusDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Complaint Status from Database.
        /// </summary>
        /// <returns></returns
        public static List<ComplaintStatus> GetAll()
        {
            return ComplaintStatusDA.GetAll();
        }

        
    }
}
