using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class GovernmentOfficialDA
    {
        public static bool Add(GovernmentOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into GovernmentOfficials(Name, ContactNumber, ContactEmail, Picture, DesignationId, OfficialCode) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}') ", info.Name, info.ContactNumber, info.ContactEmail,info.Picture, info.DesignationId, info.OfficialCode));
        }

        public static bool Update(GovernmentOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update GovernmentOfficials set Name='{0}', ContactNumber='{1}', ContactEmail='{2}', Picture='{3}', DesignationId='{4}', OfficialCode='{5}' where Id='{6}'", info.Name, info.ContactNumber, info.ContactEmail, info.Picture, info.DesignationId,info.OfficialCode, info.Id));
        }

        public static bool Delete(GovernmentOfficial info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from GovernmentOfficials where Id='{0}'", info.Id));
        }

        public static GovernmentOfficial GetDetails(int id)
        {
            GovernmentOfficial info = null;
            info = BaseDataAccess.GetRecords<GovernmentOfficial>(string.Format("select * from GovernmentOfficials where Id='{0}'", id));
            if (info != null)
            {
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return info;
        }

        public static GovernmentOfficial GetDetails(string officialCode)
        {
            GovernmentOfficial info = null; 
            info = BaseDataAccess.GetRecords<GovernmentOfficial>(string.Format("select * from GovernmentOfficials where OfficialCode='{0}'", officialCode));
            if (info != null)
            {
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return info;
        }

        public static GovernmentOfficial GetDetailsByContactNumber(string ContactNumber)
        {
            GovernmentOfficial info = null;
            info = BaseDataAccess.GetRecords<GovernmentOfficial>(string.Format("select * from GovernmentOfficials where ContactNumber='{0}'", ContactNumber));
           
            return info;
        }

        public static List<GovernmentOfficial> GetAll()
        {
            List<GovernmentOfficial> list = null;
            list = BaseDataAccess.GetRecordsList<GovernmentOfficial>(String.Format("select * from GovernmentOfficials"));

            foreach (GovernmentOfficial info in list)
            {
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
        }

        public static List<GovernmentOfficial> GetAllByDesignation(int designationId)
        {
            List<GovernmentOfficial> list = null;
                list = BaseDataAccess.GetRecordsList<GovernmentOfficial>(String.Format("select * from GovernmentOfficials where DesignationId='{0}' ", designationId));

            foreach (GovernmentOfficial info in list)
            {
                info.DepartmentDesignation = DepartmentDesignationDA.GetDetails(info.DesignationId);
            }
            return list;
        }
    }
}
