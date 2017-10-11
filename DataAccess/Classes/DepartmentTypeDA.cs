using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentTypeDA
    {
        public static bool Add(DepartmentType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentTypes(Name) values('{0}') ", info.Name));
        }

        public static bool Update(DepartmentType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentTypes set Name='{0}' where id='{1}' ", info.Name,info.Id));
        }

        public static bool Delete(DepartmentType info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentTypes where Id='{0}' ", info.Id));
        }

        public static DepartmentType GetDetails(int id)
        {
            return BaseDataAccess.GetRecords<DepartmentType>(String.Format("select * from DepartmentTypes where Id='{0}' ", id));
        }

        public static List<DepartmentType> GetAll()
        {
            return BaseDataAccess.GetRecordsList<DepartmentType>(String.Format("select * from DepartmentTypes"));
        }
    }
}
