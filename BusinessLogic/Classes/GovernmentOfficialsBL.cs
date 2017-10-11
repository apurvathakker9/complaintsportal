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
    public class GovernmentOfficialsBL
    {
        /// <summary>
        /// This Function is used to add new GovernmentOfficials to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(GovernmentOfficial info)
        {
            return GovernmentOfficialDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added GovernmentOfficials in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(GovernmentOfficial info)
        {
            return GovernmentOfficialDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added GovernmentOfficials from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(GovernmentOfficial info)
        {
            return GovernmentOfficialDA.Delete(info);
        }


        /// <summary>
        /// This Function is used to get Details of the GovernmentOfficial from Database.
        /// </summary>
        public static GovernmentOfficial GetDetails(int id)
        {
            return GovernmentOfficialDA.GetDetails(id);
        }
        /// <summary>
        /// This Function is used to get Details of the GovernmentOfficial using official code from Database.
        /// </summary>
        public static GovernmentOfficial GetDetails(string officialCode)
        {
            return GovernmentOfficialDA.GetDetails(officialCode);
        }
        /// <summary>
        /// This Function is used to get Details of the GovernmentOfficial using contact number from Database.
        /// </summary>
        public static GovernmentOfficial GetDetailsByContactNumber(string ContactNumber)
        {
            return GovernmentOfficialDA.GetDetailsByContactNumber( ContactNumber);
        }

        /// <summary>
        /// This Function is used to get list of all the GovernmentOfficial from Database.
        /// </summary>
        public static List<GovernmentOfficial> GetAll()
        {
            return GovernmentOfficialDA.GetAll();
        }

        /// <summary>
        /// This Function is used to get list of all the GovernmentOfficial using designation id from Database.
        /// </summary>
        public static List<GovernmentOfficial> GetAllByDesignation(int designationId)
        {
            return GovernmentOfficialDA.GetAllByDesignation(designationId);
        }
    }
}
