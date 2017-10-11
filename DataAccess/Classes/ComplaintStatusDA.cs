using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class ComplaintStatusDA
    {
        public static bool Add(ComplaintStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into ComplaintStatus(Name) values('{0}')", info.Name));
        }

        public static bool Update(ComplaintStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update ComplaintStatus set Name='{0}' where Id='{1}') ", info.Name,info.Id));
        }

        public static bool Delete(ComplaintStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from ComplaintStatus where Id='{0}' ", info.Id));
        }

        public static ComplaintStatus GetDetails(int id)
        {
            return BaseDataAccess.GetRecords<ComplaintStatus>(String.Format("select * from ComplaintStatus where Id='{0}' ", id));
        }

        public static List<ComplaintStatus> GetAll()
        {
            return BaseDataAccess.GetRecordsList<ComplaintStatus>(String.Format("select * from ComplaintStatus"));
        }

        
    }
}
