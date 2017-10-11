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
    public class AdharXContactNumberBL
    {
        /// <summary>
        /// This Function is used to add new AdharXContactNumber to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(AdhaarXContactNumber info)
        {
            return AdharXContactNumberDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added AdharXContactNumber in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(AdhaarXContactNumber info)
        {
            return AdharXContactNumberDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added AdhaarXContactNumber from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(AdhaarXContactNumber info)
        {
            return AdharXContactNumberDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the AdhaarXContactNumber from Database.
        /// </summary>
        public static AdhaarXContactNumber GetDetails(int id)
        {
            return AdharXContactNumberDA.GetDetails(id);
        }
        /// <summary>
        /// This Function is used to get list of all the AdhaarXContactNumber using Adhaar from Database.
        /// </summary>
        public static AdhaarXContactNumber GetDetailsByAdhaar(string Adhaar)
        {
            return AdharXContactNumberDA.GetDetailsByAdhaar(Adhaar);
        }

        /// <summary>
        /// This Function is used to get list of all the AdhaarXContactNumber from Database.
        /// </summary>
        public static List<AdhaarXContactNumber> GetAll()
        {
            return AdharXContactNumberDA.GetAll();
        }
    }
}
