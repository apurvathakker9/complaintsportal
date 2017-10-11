using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentDesignationDA
    {
        public static bool Add(DepartmentDesignation info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into DepartmentDesignations(Name) values('{0}') ", info.Name));
        }

        public static bool Update(DepartmentDesignation info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update DepartmentDesignations set Name='{0}' where Id='{1}' ", info.Name,info.Id));
        }

        public static bool Delete(DepartmentDesignation info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from DepartmentDesignations where Id='{0}' ", info.Id));
        }

        public static DepartmentDesignation GetDetails(int id)
        {
            return BaseDataAccess.GetRecords<DepartmentDesignation>(String.Format("select * from DepartmentDesignations where Id='{0}' ", id));
        }

        public static List<DepartmentDesignation> GetAll()
        {
            return BaseDataAccess.GetRecordsList<DepartmentDesignation>(String.Format("select * from DepartmentDesignations"));
        }
    }
}
