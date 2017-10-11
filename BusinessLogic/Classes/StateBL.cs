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
    public class StateBL
    {
        /// <summary>
        /// This Function is used to add new State to database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Add(State info)
        {
            return StateDA.Add(info);
        }

        /// <summary>
        /// This Function is used to Update previously added State in database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Update(State info)
        {
            return StateDA.Update(info);
        }

        /// <summary>
        /// This Function is used to Delete previously added State from database and is performed by SuperAdmin Only.
        /// </summary>
        public static bool Delete(State info)
        {
            return StateDA.Delete(info);
        }

        /// <summary>
        /// This Function is used to get Details of the State from Database.
        /// </summary>
        public static State GetDetails(int id)
        {
            return StateDA.GetDetails(id);
        }

        /// <summary>
        /// This Function is used to get list of all the States from Database.
        /// </summary>
        public static List<State> GetAll()
        {
            return StateDA.GetAll();
        }
    }
}
