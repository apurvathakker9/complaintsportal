using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentEscalationLevelDA
    {
        public static bool Add(DepartmentEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentEscalationLevels(DepartmentId,EscalationLevelName, DesignatedOfficialId, LevelNumber) values('{0}','{1}','{2}','{3}')",info.DepartmentId, info.EscalationLevelName,info.DesignatedOfficialId,info.LevelNumber));
        }

        public static bool Update(DepartmentEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentEscalationLevels set DepartmentId='{0}', EscalationLevelName='{1}', DesignatedOfficialId='{2}', LevelNumber='{3}' where Id='{4}'",info.DepartmentId, info.EscalationLevelName, info.DesignatedOfficialId, info.LevelNumber,info.Id));
        }

        public static bool Delete(DepartmentEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentEscalationLevels where Id='{0}'", info.Id));
        }

        public static DepartmentEscalationLevel GetDetails(int id)
        {
            DepartmentEscalationLevel info = null;
            info = BaseDataAccess.GetRecords<DepartmentEscalationLevel>(String.Format("select * from DepartmentEscalationLevels where Id='{0}'", id));
            if(info!=null)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.DesignatedOfficialId);
            }
            return info;
        }

        public static DepartmentEscalationLevel GetDetailsByDepartmentId(int id, int LevelNumber)
        {
            DepartmentEscalationLevel info = null;
            info = BaseDataAccess.GetRecords<DepartmentEscalationLevel>(String.Format("select * from DepartmentEscalationLevels where DepartmentId='{0}' and LevelNumber = '{1}'", id,LevelNumber));
            if(info!=null)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.DesignatedOfficialId);
            }
            return info;
        }
        public static List<DepartmentEscalationLevel> GetAll()
        {
            List<DepartmentEscalationLevel> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentEscalationLevel>(String.Format("select * from DepartmentEscalationLevels"));

            foreach (DepartmentEscalationLevel info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.DesignatedOfficialId);
            }
            return list;
        }

        public static List<DepartmentEscalationLevel> GetAllForDepartment(int departmentId)
        {
            List<DepartmentEscalationLevel> list = new List<DepartmentEscalationLevel>();
            list = BaseDataAccess.GetRecordsList<DepartmentEscalationLevel>(String.Format("select * from DepartmentEscalationLevels where DepartmentId='{0}'",departmentId));

            foreach (DepartmentEscalationLevel info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.DesignatedOfficialId);
            }
            return list;
        }

        public static List<DepartmentEscalationLevel> GetAllForDepartmentAndLevel(int departmentId, int levelNumber)
        {
            return null;
        }
    }
}
