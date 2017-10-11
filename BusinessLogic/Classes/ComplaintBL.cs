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
    public class ComplaintBL
    {
        /// <summary>
        /// This Function is used to add new Complaint to database and is performed by SuperAdmin Only.
        /// </summary>
        public static int Add(Complaint  info)
        {
            return ComplaintDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Complaint in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(Complaint info)
        {
            return ComplaintDA.Update(info);
        }

        public static bool UpdateClosing(Complaint info)
        {
            return ComplaintDA.UpdateClosing(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Complaint from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(Complaint info)
        {
            return ComplaintDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Complaint from Database.
        /// </summary>
        public static Complaint GetDetails(int id)
        {
            return ComplaintDA.GetDetails(id);
        }


        /// <summary>
        /// This Function is used to get list of all the Complaint from Database.
        /// </summary>
        public static List<Complaint> GetAll()
        {
            return ComplaintDA.GetAll();
        }

        public static List<Complaint> GetAllByDateRange(int departmentId)
        {
            return ComplaintDA.GetAllByDateRange(departmentId);
        }

        public static List<Complaint> GetAllOpenComplaints(int departmentId)
        {
            return ComplaintDA.GetAllOpenComplaints(departmentId);
        }

        public static List<Complaint> GetAllByAdhar(string Adhar)
        {
            return ComplaintDA.GetAllByAdhar(Adhar);
        }
    }
}
