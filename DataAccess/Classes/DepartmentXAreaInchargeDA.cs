using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentXAreaInchargeDA
    {
        public static bool Add(DepartmentXAreaIncharge info)
        {
            if (info.VillageId != 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentXAreaIncharges(DepartmentId, StateId, CityId,VillageId,LocalityId, InchargeId)values('{0}','{1}','{2}','{3}','{4}','{5}')", info.DepartmentId, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.InchargeId));
            }
            else 
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentXAreaIncharges(DepartmentId, StateId, CityId,LocalityId, InchargeId)values('{0}','{1}','{2}','{3}','{4}')", info.DepartmentId, info.StateId, info.CityId, info.LocalityId, info.InchargeId));
            }
        }

        public static bool Update(DepartmentXAreaIncharge info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentXAreaIncharges set DepartmentId='{0}',StateId='{1}',CityId='{2}',VillageId='{3}',LocalityId='{4}',InchargeId='{5}' where Id='{6}'",info.DepartmentId,info.StateId, info.CityId, info.VillageId, info.LocalityId, info.InchargeId, info.Id));
        }

        public static bool Delete(DepartmentXAreaIncharge info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentXAreaIncharges where Id='{0}'",info.Id));
        }

        public static DepartmentXAreaIncharge GetDetails(int id)
        {
            DepartmentXAreaIncharge info = null;
            info = BaseDataAccess.GetRecords<DepartmentXAreaIncharge>(String.Format("select * from DepartmentXAreaIncharges where Id='{0}'", id));
            info.Department = DepartmentDA.GetDetails(info.DepartmentId);
            info.State = StateDA.GetDetails(info.StateId);
            info.City = CityDA.GetDetails(info.CityId);
            if(info.VillageId!=0)
            {
                info.Village = VillageDA.GetDetails(info.VillageId);
            }
            info.Locality = LocalityDA.GetDetails(info.LocalityId);
            info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.InchargeId);

            return info;
        }

        public static List<DepartmentXAreaIncharge> GetAll()
        {
            List<DepartmentXAreaIncharge> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXAreaIncharge>(String.Format("select * from DepartmentXAreaIncharges"));

            foreach (DepartmentXAreaIncharge info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.InchargeId);
            }
            return list;
        }

        public static List<DepartmentXAreaIncharge> GetAllForDepartment(int departmentId)
        {
            List<DepartmentXAreaIncharge> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXAreaIncharge>(String.Format("select * from DepartmentXAreaIncharges where departmentId='{0}' ",departmentId));

            foreach (DepartmentXAreaIncharge info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.InchargeId);
            }
            return list;
        }

        public static List<DepartmentXAreaIncharge> GetAllForLocality(int localityId)
        {
            return null;
        }

        public static List<DepartmentXAreaIncharge> GetAllForCity(int cityId)
        {
            return null;
        }

        public static List<DepartmentXAreaIncharge> GetAllForState(int stateId)
        {
            return null;
        }

        public static List<DepartmentXAreaIncharge> GetAllForVillage(int villageId)
        {
            return null;
        }
    }
}
