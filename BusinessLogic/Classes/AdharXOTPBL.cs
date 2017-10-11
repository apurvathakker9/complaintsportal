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
    public class AdharXOTPBL
    {
        /// <summary>
        /// This Function is used to add new AdharXOTP to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(AdhaarXOTP info)
        {
            return AdharXOTPDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added AdharXOTP in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(AdhaarXOTP info)
        {
            return AdharXOTPDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added AdhaarXOTP from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(AdhaarXOTP info)
        {
            return AdharXOTPDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the AdhaarXOTP from Database.
        /// </summary>
        public static AdhaarXOTP GetDetails(int id)
        {
            return AdharXOTPDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the AdhaarXOTP from Database.
        /// </summary>
        public static List<AdhaarXOTP> GetAll()
        {
            return AdharXOTPDA.GetAll();
        }
    }
}
