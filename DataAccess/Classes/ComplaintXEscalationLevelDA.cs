using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class ComplaintXEscalationLevelDA
    {
        public static bool Add(ComplaintXEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into ComplaintXEscalationLevel(ComplaintId, EscalationLevelNumber, EscalationTime, EscalationReason) values ('{0}','{1}','{2}','{3}')",info.ComplaintId,info.EscalationLevelNumber,info.EscalationTime,info.EscalationReason));
        }

        public static bool Update(ComplaintXEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("Update ComplaintXEscalationLevel set ComplaintId='{0}',EscalationLevelNumber='{1}', EscalationTime='{2}', EscalationReason='{3}' where Id='{4}'",info.ComplaintId, info.EscalationLevelNumber,info.EscalationTime,info.EscalationReason,info.Id));
        }

        public static bool Delete(ComplaintXEscalationLevel info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from ComplaintXEscalationLevel where Id='{0}'",info.Id));
        }

        public static ComplaintXEscalationLevel GetDetails(int id)
        {
            ComplaintXEscalationLevel info = null;
            info = BaseDataAccess.GetRecords<ComplaintXEscalationLevel>(String.Format("select * from ComplaintXEscalationLevel where Id='{0}'", id));
            if(info!=null)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            }
            return info;

            
        }

        public static List<ComplaintXEscalationLevel> GetAll()
        {
            List<ComplaintXEscalationLevel> list = null;
            list = BaseDataAccess.GetRecordsList<ComplaintXEscalationLevel>(String.Format("select * from ComplaintXEscalationLevel"));

            foreach (ComplaintXEscalationLevel info in list)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            }
            return list;
        }

        public static List<ComplaintXEscalationLevel> GetAllByComplaintId(int Id)
        {
            List<ComplaintXEscalationLevel> list = null;
            list = BaseDataAccess.GetRecordsList<ComplaintXEscalationLevel>(String.Format("Select *  from ComplaintXEscalationLevel where ComplaintId='{0}'", Id));
            
            foreach(ComplaintXEscalationLevel info in list)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            }
            return list;
        }

    }
}
