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
    /// All the basic crud operations are defined in this class along with an additional operation i.e. get city by State.
    /// These Functions are Add,Update,Delete,GetDetails,GetAll.
    /// </summary>
    public class CityBL
    {
        /// <summary>
        /// This Function is used to add new City to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(City info)
        {
            return CityDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added City in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(City info)
        {
            return CityDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added City from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(City info)
        {
            return CityDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the City from Database.
        /// </summary>
        public static City GetDetails(int id)
        {
            return CityDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the Cities from Database.
        /// </summary>
        public static List<City> GetAll()
        {
            return CityDA.GetAll();
        }

        /// <summary>
        /// This Function is used to get list of all the Cities in a particular State from Database.
        /// </summary>
        public static List<City> GetAllByState(int stateId)
        {
            return CityDA.GetAllByState(stateId);
        }
    }
}
