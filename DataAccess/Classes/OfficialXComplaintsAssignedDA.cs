using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class OfficialXComplaintsAssignedDA
    {
        public static bool Add(OfficialXComplaintsAssigned info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into OfficialXComplaintsAssigned (OfficialId, ComplaintId, AssignedOn, IsEscalated) values ('{0}','{1}','{2}','{3}')",info.OfficialId,info.ComplaintId,DateTime.Now, info.IsEscalated ));
        }

        public static bool Update(OfficialXComplaintsAssigned info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update OfficialXComplaintsAssigned set OfficialId='{0}',ComplaintId='{1}',AssignedOn='{2}',IsEscalated='{3}' where Id='{4}'",info.OfficialId, info.ComplaintId, info.AssignedOn, info.IsEscalated, info.Id));
        }

        public static bool Delete(OfficialXComplaintsAssigned info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from OfficialXComplaintsAssigned where Id='{0}'",info.Id)) ;
        }

        public static OfficialXComplaintsAssigned GetDetails(int id)
        {
            OfficialXComplaintsAssigned info = null;
            info = BaseDataAccess.GetRecords<OfficialXComplaintsAssigned>(String.Format("select * from OfficialXComplaintsAssigned where Id='{0}'",id));
            info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.OfficialId);
            info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            return info;
        }

        public static List<OfficialXComplaintsAssigned> GetAll()
        {
            List<OfficialXComplaintsAssigned> list = null;
            list = BaseDataAccess.GetRecordsList<OfficialXComplaintsAssigned>(String.Format("select * from OfficialXComplaintsAssigned"));

            foreach (OfficialXComplaintsAssigned info in list)
            {
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.OfficialId);
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            }
            return list;
            }

        public static List<OfficialXComplaintsAssigned> GetAllByOfficialId(int officialId)
        {
            List<OfficialXComplaintsAssigned> list = null;
            list= BaseDataAccess.GetRecordsList<OfficialXComplaintsAssigned>(string.Format("Select * from OfficialXComplaintsAssigned where OfficialId = '{0}'", officialId));
            foreach (OfficialXComplaintsAssigned info in list)
            {
                info.GovernmentOfficial = GovernmentOfficialDA.GetDetails(info.OfficialId);
                info.Complaint = ComplaintDA.GetDetails(info.ComplaintId);
            }

            return list;
        }
    }
}
