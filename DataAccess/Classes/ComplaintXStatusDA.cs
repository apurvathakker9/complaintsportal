using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class ComplaintXStatusDA
    {
        public static bool Add(ComplaintXStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into ComplaintXStatus ( ComplaintId, StatusId, StatusAssignTime, StatusChangeSummary)values('{0}','{1}','{2}','{3}')", info.ComplaintId,info.StatusId,DateTime.Now,info.StatusChangeSummary));
        }

        public static bool Update(ComplaintXStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update ComplaintXStatus set ComplaintId='{0}',StatusId='{1}', StatusAssignTime='{2}',StatusChangeSummary='{3}' where Id='{4}'",info.ComplaintId,info.StatusId, info.StatusAssignTime, info.StatusChangeSummary, info.Id));
        }

        public static bool Delete(ComplaintXStatus info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from ComplaintXStatus where Id='{0}'",info.Id));
        }

        public static ComplaintXStatus GetDetails(int id)
        {
            ComplaintXStatus info = null;
            info = BaseDataAccess.GetRecords<ComplaintXStatus>(String.Format("select * from ComplaintXStatus where Id='{0}' ", id));
            return info;
        }

        public static List<ComplaintXStatus> GetAll()
        {
            List<ComplaintXStatus> list = null;
            list = BaseDataAccess.GetRecordsList<ComplaintXStatus>(String.Format("select * from ComplaintXStatus"));

            foreach(ComplaintXStatus info in list)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.StatusId);
            }
            return list;
        }

        public static List<ComplaintXStatus> GetAllByComplaint(int complaintId)
        {
            List<ComplaintXStatus> list = null;
            list = BaseDataAccess.GetRecordsList<ComplaintXStatus>(String.Format("select * from ComplaintXStatus where ComplaintId='{0}'",complaintId));

            foreach (ComplaintXStatus info in list)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.StatusId);
            }
            return list;
        }

        public static List<ComplaintXStatus> GetAllByStatus(int StatusId)
        {
            List<ComplaintXStatus> list = null;
            list = BaseDataAccess.GetRecordsList<ComplaintXStatus>(String.Format("select * from ComplaintXStatus where Status='{0}' ", StatusId));

            foreach (ComplaintXStatus info in list)
            {
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.StatusId);
            }
            return list;
        }

        public static List<ComplaintXStatus> GetAllByComplaintId(int id)
        {
            return BaseDataAccess.GetRecordsList<ComplaintXStatus>(String.Format("select * from ComplaintXStatus where ComplaintId='{0}'", id));

        }
    }
}
