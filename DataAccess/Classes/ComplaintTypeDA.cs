using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class ComplaintTypeDA
    {
        public static bool Add(ComplaintType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into ComplaintTypes( Name, DepartmentTypeId) values('{0}','{1}')", info.Name,info.DepartmentTypeId));
        }

        public static bool Update(ComplaintType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update ComplaintTypes set Name='{1}',DepartmentTypeId='{2}'where Id={3}",info.Name, info.DepartmentTypeId,info.Id));
        }

        public static bool Delete(ComplaintType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("Delete from ComplaintTypes where Id='{0}'",info.Id));
        }

        public static ComplaintType GetDetails(int id)
        {
            ComplaintType info = null;
            info = BaseDataAccess.GetRecords<ComplaintType>(string.Format("select * from ComplaintTypes where Id='{0}'", id));
            return info;
        }

        public static List<ComplaintType> GetAll()
        {
            List<ComplaintType> list = BaseDataAccess.GetRecordsList<ComplaintType>(String.Format("select * from ComplaintTypes"));

            foreach (ComplaintType info in list)
            {
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
            }
            return list;
        }

        public static List<ComplaintType> GetAllForDepartment(int departmentTypeId)
        {
            List<ComplaintType> list = BaseDataAccess.GetRecordsList<ComplaintType>(String.Format("select * from ComplaintTypes where DepartmentTypeId='{0}' ", departmentTypeId));

            foreach (ComplaintType info in list)
            {
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
            }
            return list;
        }
    }
}
