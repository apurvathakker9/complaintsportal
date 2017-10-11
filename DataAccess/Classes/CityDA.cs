using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class CityDA
    {
        public static bool Add(City info)
        {
        return BaseDataAccess.ExecuteSQL(String.Format("insert into Cities (StateId, Name, PinCode) values('{0}','{1}','{2}')",info.StateId,info.Name,info.PinCode));
        }

        public static bool Update(City info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update Cities set StateId='{0}',Name='{1}',PinCode='{2}' where Id='{3}'",info.StateId,info.Name,info.PinCode,info.Id));
        }

        public static bool Delete(City info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from Cities where Id='{0}'",info.Id));
        }

        public static City GetDetails(int id)
        {
            City obj = null;
            obj = BaseDataAccess.GetRecords<City>(String.Format("select * from Cities where Id='{0}' ", id));

            if (obj != null)
            {
                obj.State = StateDA.GetDetails(obj.StateId);
                return obj;
            }
            else
            {
                return null;
            }

        }

        public static List<City> GetAll()
        {
            List<City> list = null;
            list = BaseDataAccess.GetRecordsList<City>(String.Format("select * from Cities"));

            foreach (City info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
            }
            return list;
        }

        public static List<City> GetAllByState(int stateId)
        {
            List<City> list = null;
            list = BaseDataAccess.GetRecordsList<City>(String.Format("select * from Cities where StateId='{0}' ", stateId));

            foreach (City info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
            }
            return list;
        }
    }
}
