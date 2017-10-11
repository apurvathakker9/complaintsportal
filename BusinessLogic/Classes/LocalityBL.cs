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
    /// All the basic crud operations are defined in this class along with an additional operations i.e. get locality by Village or City.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class LocalityBL
    {
        /// <summary>
        /// This Function is used to add new locality to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(Locality info)
        {
            return LocalityDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added Locality in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(Locality info)
        {
            return LocalityDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added Locality from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(Locality info)
        {
            return LocalityDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the Village from Database.
        /// </summary>
        public static Locality GetDetails(int id)
        {
            return LocalityDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Locality in a particular City and Village from Database.
        /// </summary>
        public static List<Locality> GetDetails(int CityId, int VillageId)
        {
            return LocalityDA.GetDetails(CityId, VillageId);
        }

        /// <summary>
        /// This Function is used to get list of all the Localities from Database.
        /// </summary>
        public static List<Locality> GetAll()
        {
            return LocalityDA.GetAll() ;
        }

        /// <summary>
        /// This Function is used to get list of all the Localities in a particular City from Database.
        /// </summary>
        public static List<Locality> GetAllForCity(int cityId)
        {
            return LocalityDA.GetAllForCity(cityId);
        }

        /// <summary>
        /// This Function is used to get list of all the Localities in a particular Village from Database.
        /// </summary>
        public static List<Locality> GetAllForVillage(int villageId)
        {
            return LocalityDA.GetAllForVillage(villageId);
        }
    }
}
