using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class LocalityDA
    {
        public static bool Add(Locality info)
        {
            if (info.VillageId != 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into Localities(CityId, VillageId, Name, PinCode, Latitude, Longitude) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}' ) ", info.CityId, info.VillageId, info.Name, info.Pincode, info.Latitude, info.Longitude));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into Localities(CityId, Name, PinCode, Latitude, Longitude) values('{0}', '{1}', '{2}', '{3}', '{4}' ) ", info.CityId, info.Name, info.Pincode, info.Latitude, info.Longitude));
            }

        }

        public static bool Update(Locality info)
        {
            if (info.VillageId != 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update Localities set CityId='{0}', VillageId='{1}', Name='{2}', PinCode='{3}', Latitude='{4}', Longitude='{5}' where Id='{6}' ", info.CityId, info.VillageId, info.Name, info.Pincode, info.Latitude, info.Longitude, info.Id));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update Localities set CityId='{0}', Name='{1}', PinCode='{2}', Latitude='{3}', Longitude='{4}' where Id='{5}' ", info.CityId, info.Name, info.Pincode, info.Latitude, info.Longitude, info.Id));
            }
        }

        public static bool Delete(Locality info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from Localities where Id='{0}' ", info.Id)); ;
        }

        public static Locality GetDetails(int id)
        {
            Locality info = null;
            info = BaseDataAccess.GetRecords<Locality>(String.Format("select * from Localities where Id='{0}' ", id));
            if (info != null)
            {
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                return info;
            }
            else
            {
                return info;
            }
            
        }

        public static List<Locality> GetDetails(int CityId, int VillageId)
        {
            List<Locality> list = null;
            if (VillageId != 0)
            {
                list = BaseDataAccess.GetRecordsList<Locality>(String.Format("select * from Localities where CityId='{0}' and VillageId='{1}' ", CityId, VillageId));
            }
            else
            {
                list = BaseDataAccess.GetRecordsList<Locality>(String.Format("select * from Localities where CityId='{0}' and VillageId is NULL ", CityId));
            }
            
            foreach(Locality info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
                if(info.VillageId!=0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
            }
            return list;
            
        }

        public static List<Locality> GetAll()
        {
            List<Locality> list = null;
            list = BaseDataAccess.GetRecordsList<Locality>(String.Format("select * from Localities"));

            foreach (Locality info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
            }
            return list;
        }

        public static List<Locality> GetAllForCity(int cityId)
        {
            List<Locality> list = null;
            list = BaseDataAccess.GetRecordsList<Locality>(String.Format("select * from Localities where CityId='{0}' ", cityId));

            foreach (Locality info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
            }
            return list;
        }

        public static List<Locality> GetAllForVillage(int villageId)
        {
            List<Locality> list = null;
            list = BaseDataAccess.GetRecordsList<Locality>(String.Format("select * from Localities where VillageId='{0}' ", villageId));

            foreach (Locality info in list)
            {
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
            }
            return list;
        }
    }
}
