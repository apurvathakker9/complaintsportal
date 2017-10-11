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
    /// All the basic crud operations are defined in this class along with an additional operation i.e. get Village by City.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class VillageBL
    {
        /// <summary>
        /// This Function is used to add new Village to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(Village info)
        {
            return VillageDA.Add( info);
        }

        /// <summary>
        /// This Function is used to Update previously added Village in database and is performed by SuperAdmin Only.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool Update(Village info)
        {
            return VillageDA.Update( info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Village from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(Village info)
        {
            return VillageDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Village from Database.
        /// </summary>
        public static Village GetDetails(int id)
        {
            return VillageDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Villages from Database.
        /// </summary>
        public static List<Village> GetAll()
        {
            return VillageDA.GetAll();
        }

        /// <summary>
        /// This Function is used to get list of all the Villages in a particular City from Database.
        /// </summary>
        public static List<Village> GetAllForCity(int cityId)
        {
            return VillageDA.GetAllForCity(cityId);
        }
    }
}
