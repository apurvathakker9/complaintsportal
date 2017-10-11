using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentXOfficialsDA
    {
        public static bool Add(DepartmentXOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentXOfficials (DepartmentId, GovernmentOfficialId, DesignationId) values('{0}','{1}','{2}')",info.DepartmentId, info.GovernmentOfficialId, info.DesignationId));
        }

        public static bool Update(DepartmentXOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentXOfficials set DepartmentId='{0}',GovernmentOfficialId='{1}', DesignationId='{2}'where Id='{3}'", info.DepartmentId, info.GovernmentOfficialId, info.DesignationId, info.Id));
        }

        public static bool Delete(DepartmentXOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentXOfficials where Id='{0}'",info.Id));
        }

        public static DepartmentXOfficial GetDetails(int id)
        {
            DepartmentXOfficial info= null;
            info = BaseDataAccess.GetRecords<DepartmentXOfficial>(String.Format("select * from DepartmentXOfficials where Id='{0}'", id));
            if(info!=null)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.GovernmentOfficialId);
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return info;
        }

        public static List<DepartmentXOfficial> GetAll()
        {
            List<DepartmentXOfficial> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXOfficial>(String.Format("select * from DepartmentXOfficials"));

            foreach (DepartmentXOfficial info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.GovernmentOfficialId);
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
            }

        public static List<DepartmentXOfficial> GetAllByUsername(string userName)
        {
            List<DepartmentXOfficial> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXOfficial>(String.Format("select * from DepartmentXOfficials where ContactNumber='{0}' ", userName));

            foreach (DepartmentXOfficial info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.GovernmentOfficialId);
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
        }

        public static List<DepartmentXOfficial> GetAllByDepartment(int departmentId)
        {
            List<DepartmentXOfficial> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXOfficial>(String.Format("select * from DepartmentXOfficials where DepartmentId='{0}' ", departmentId));

            foreach (DepartmentXOfficial info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.GovernmentOfficialId);
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
        }

        public static List<DepartmentXOfficial> GetAllForOfficial(int officialId)
        {
            List<DepartmentXOfficial> list = null;
            list = BaseDataAccess.GetRecordsList<DepartmentXOfficial>(String.Format("select * from DepartmentXOfficials where GovernmentOfficialId='{0}' ", officialId));

            foreach (DepartmentXOfficial info in list)
            {
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.GovernmentOfficialId);
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
        }
    }
}
