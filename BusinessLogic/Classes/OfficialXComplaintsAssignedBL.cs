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
    public class OfficialXComplaintsAssignedBL
    {
        /// <summary>
        /// This Function is used to add new OfficialXComplaintsAssigned to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(OfficialXComplaintsAssigned info)
        {
            return OfficialXComplaintsAssignedDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added OfficialXComplaintsAssigned in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(OfficialXComplaintsAssigned info)
        {
            return OfficialXComplaintsAssignedDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added OfficialXComplaintsAssigned from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(OfficialXComplaintsAssigned info)
        {
            return OfficialXComplaintsAssignedDA.Delete(info);
        }


        /// <summary>
        /// This Function is used to get Details of the OfficialXComplaintsAssigned from Database.
        /// </summary>
        public static OfficialXComplaintsAssigned GetDetails(int id)
        {
            return OfficialXComplaintsAssignedDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the OfficialXComplaintsAssigned from Database.
        /// </summary>
        public static List<OfficialXComplaintsAssigned> GetAll()
        {
            return OfficialXComplaintsAssignedDA.GetAll();
        }
        /// <summary>
        /// This Function is used to get list of all the OfficialXComplaintsAssigned using official id from Database.
        /// </summary>
        public static List<OfficialXComplaintsAssigned> GetAllByOfficialId(int officialId)
        {
            return OfficialXComplaintsAssignedDA.GetAllByOfficialId(officialId);
        }
    }
}
