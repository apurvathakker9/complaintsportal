using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentXAreaOnDutyDA
    {
        public static bool Add(DepartmentXAreaOnDuty info)
        {
            if(info.VillageId==0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentXAreaOnDuty(DepartmentId, StateId, CityId,LocalityId, OnDutyPersonId, DutyTimeFrom, DutyTimeTo)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", info.DepartmentId, info.StateId, info.CityId, info.LocalityId, info.OnDutyPersonId, info.DutyTimeFrom.ToShortTimeString(), info.DutyTimeTo.ToShortTimeString()));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentXAreaOnDuty(DepartmentId, StateId, CityId,VillageId,LocalityId, OnDutyPersonId, DutyTimeFrom, DutyTimeTo)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", info.DepartmentId, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.OnDutyPersonId, info.DutyTimeFrom.ToShortTimeString(), info.DutyTimeTo.ToShortTimeString()));
            }
        }

        public static bool Update(DepartmentXAreaOnDuty info)
        {
            if(info.VillageId==0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentXAreaOnDuty set DepartmentId='{0}', StateId='{1}', CityId='{2}', VillageId='{3}',LocalityId='{4}', OnDutyPersonId='{5}',DutyTimeFrom='{6}',DutyTimeTo='{7}' where Id='{8}'", info.DepartmentId, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.OnDutyPersonId, info.DutyTimeFrom.ToShortTimeString(), info.DutyTimeTo.ToShortTimeString(), info.Id));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentXAreaOnDuty set DepartmentId='{0}', StateId='{1}', CityId='{2}', VillageId='{3}',LocalityId='{4}', OnDutyPersonId='{5}',DutyTimeFrom='{6}',DutyTimeTo='{7}' where Id='{8}'", info.DepartmentId, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.OnDutyPersonId, info.DutyTimeFrom.ToShortTimeString(), info.DutyTimeTo.ToShortTimeString(), info.Id));
            }
        }

        public static bool Delete(DepartmentXAreaOnDuty info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentXAreaOnDuty where Id='{0}'", info.Id));
        }

        public static DepartmentXAreaOnDuty GetDetails(int id)
        {
            DepartmentXAreaOnDuty info = null;
            info = BaseDataAccess.GetRecords<DepartmentXAreaOnDuty>(String.Format("select * from DepartmentXAreaOnDuty where Id='{0}' ", id));

            if (info != null)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if(info.VillageId!=0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovermentOfficial = GovernmentOfficialDA.GetDetails(info.OnDutyPersonId);

            }
            return info;
        }

        public static DepartmentXAreaOnDuty GetByTime(int departmentId, DateTime timeOfDay)
        {
            DepartmentXAreaOnDuty info = null;
            info = BaseDataAccess.GetRecords<DepartmentXAreaOnDuty>(String.Format("select * from DepartmentXAreaOnDuty where DepartmentId='{0}'", departmentId));
            if (info != null)
            {

                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovermentOfficial = GovernmentOfficialDA.GetDetails(info.OnDutyPersonId);

            }
            return info;
        }

        public static List<DepartmentXAreaOnDuty> GetAll()
        {
            List<DepartmentXAreaOnDuty> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXAreaOnDuty>(String.Format("select * from DepartmentXAreaOnDuty "));

            foreach (DepartmentXAreaOnDuty info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovermentOfficial = GovernmentOfficialDA.GetDetails(info.OnDutyPersonId);
            }
            return list;
        }

        public static List<DepartmentXAreaOnDuty> GetAllByLocationAndDepartment(int localityId, int departmentId)
        {
            List<DepartmentXAreaOnDuty> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXAreaOnDuty>(String.Format("select * from DepartmentXAreaOnDuty where LocalityId='{0}' and DepartmentId='{1}' ", localityId, departmentId));

            foreach (DepartmentXAreaOnDuty info in list)
            {
                info.DutyTimeFrom = Convert.ToDateTime(info.DutyTimeFrom.ToString("hh:mm:ss"));
                info.DutyTimeTo = Convert.ToDateTime(info.DutyTimeTo.ToString("hh:mm:ss"));
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovermentOfficial = GovernmentOfficialDA.GetDetails(info.OnDutyPersonId);
            }
            return list;
        }

        public static List<DepartmentXAreaOnDuty> GetAllForDepartment(int departmentId)
        {
            return null;
        }

        public static List<DepartmentXAreaOnDuty> GetAllForLocality(int localityId)
        {
            return null;
        }

        public static List<DepartmentXAreaOnDuty> GetAllForVillageId(int villageId)
        {
            return null;
        }

        public static List<DepartmentXAreaOnDuty> GetAllForCity(int cityId)
        {
            return null;
        }

        public static List<DepartmentXAreaOnDuty> GetAllForState(int stateId)
        {
            return null;
        }
    }
}
