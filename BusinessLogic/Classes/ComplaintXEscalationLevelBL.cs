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
    public class ComplaintXEscalationLevelBL
    {
        /// <summary>
        /// This Function is used to add new ComplaintXEscalationLevel to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(ComplaintXEscalationLevel info)
        {
            return ComplaintXEscalationLevelDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added ComplaintXEscalationLevel in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(ComplaintXEscalationLevel info)
        {
            return ComplaintXEscalationLevelDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added ComplaintXEscalationLevel from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(ComplaintXEscalationLevel info)
        {
            return ComplaintXEscalationLevelDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the ComplaintXEscalationLevel from Database.
        /// </summary>
        public static ComplaintXEscalationLevel GetDetails(int id)
        {
            return ComplaintXEscalationLevelDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the ComplaintXEscalationLevel from Database.
        /// </summary>
        public static List<ComplaintXEscalationLevel> GetAll()
        {
            return ComplaintXEscalationLevelDA.GetAll();
        }


        /// <summary>
        /// This Function is used to get list of all the ComplaintXEscalationLevel using complaint from Database.
        /// </summary>
        public static List<ComplaintXEscalationLevel> GetAllByComplaintId(int Id)
        {
            return ComplaintXEscalationLevelDA.GetAllByComplaintId(Id);
        }

    }
}
