using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class VillageDA
    {
        public static bool Add(Village info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into Villages(CityId, Name, PinCode)values('{0}','{1}','{2}')", info.CityId, info.Name, info.PinCode));
        }

        public static bool Update(Village info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update Villages set CityId='{0}',Name='{1}', PinCode='{2}' where Id='{3}'", info.CityId, info.Name, info.PinCode, info.Id));
        }

        public static bool Delete(Village info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from Villages where Id='{0}'", info.Id));
        }

        public static Village GetDetails(int id)
        {
            Village info = BaseDataAccess.GetRecords<Village>(String.Format("select * from Villages where id='{0}' ", id));

            if (info != null)
            {
                info.City = CityDA.GetDetails(info.CityId);
                return info;
            }
            else
            {
                return info;
            }

        }

        public static List<Village> GetAll()
        {
            List<Village> list = BaseDataAccess.GetRecordsList<Village>(String.Format("select * from villages"));

            foreach (Village info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
            }
            return list;
        }

        public static List<Village> GetAllForCity(int cityId)
        {
            List<Village> list = null;
            list = BaseDataAccess.GetRecordsList<Village>(String.Format("select * from villages where CityId='{0}' ", cityId));

            foreach (Village info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
            }
            return list;
        }
    }
}
