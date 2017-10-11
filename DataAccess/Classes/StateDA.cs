using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class StateDA
    {
        public static bool Add(State info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into states(Name) values('{0}') ", info.Name));
        }

        public static bool Update(State info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update states set Name = '{0}' where Id='{1}' ", info.Name, info.Id));
        }

        public static bool Delete(State info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("Delete from states where Id='{0}'", info.Id));
        }

        public static State GetDetails(int id)
        {
            
            return BaseDataAccess.GetRecords<State>(String.Format("select * from states where Id='{0}' ", id));
        }

        public static List<State> GetAll()
        {
            List<State> list = BaseDataAccess.GetRecordsList<State>(String.Format("select * from states"));
            return list;
        }
    }
}
