using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ComplaintDA
    {
        public static int Add(Complaint  info)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                if(info.VillageId!=0)
                {
                    command.CommandText = String.Format("insert into Complaints( StateId, CityId, VillageId, LocalityId, DepartmentTypeId, ComplaintTypeId, ReportingPersonFirstName, ReportingPersonLastName, ReportingPersonAdhaarId, ReportingPersonContactNumber,ReportingTime,CurrentStatusId, CurrentEscalationNumber, OTP, complaintVerifiedViaOTP, IsEscalated, Description, DepartmentId,Image) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}'); select @@IDENTITY;", info.StateId, info.CityId, info.VillageId, info.LocalityId, info.DepartmentTypeId, info.ComplaintType, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, DateTime.Now, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.Description, info.DepartmentId,info.Image);
                }
                else
                {
                    command.CommandText = String.Format("insert into Complaints( StateId, CityId, LocalityId, DepartmentTypeId, ComplaintTypeId, ReportingPersonFirstName, ReportingPersonLastName, ReportingPersonAdhaarId, ReportingPersonContactNumber,ReportingTime,CurrentStatusId, CurrentEscalationNumber, OTP, complaintVerifiedViaOTP, IsEscalated, Description, DepartmentId,Image) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}'); select @@IDENTITY;", info.StateId, info.CityId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, DateTime.Now, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.Description, info.DepartmentId,info.Image);
                }

                int RowsAffected =Convert.ToInt32( command.ExecuteScalar());
                if (RowsAffected > 0)
                {
                    return RowsAffected;
                }
                else
                {
                    return 0;
                }

            }

            catch(Exception ex)
            {
                return 0;
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }


            
        }

        public static bool Update(Complaint info)
        {
            if(info.VillageId == 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("Update Complaints set StateId='{0}',CityId='{1}',LocalityId='{2}',DepartmentTypeId='{3}',ComplaintTypeId='{4}', ReportingPersonFirstName='{5}',ReportingPersonLastName='{6}',ReportingPersonAdhaarId='{7}',ReportingPersonContactNumber='{8}',ReportingTime='{9}', CurrentStatusId='{10}', CurrentEscalationNumber='{11}', OTP='{12}', ComplaintVerifiedViaOTP='{13}', IsEscalated='{14}', DepartmentId='{15}' where Id='{16}'", info.StateId, info.CityId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, info.ReportingTime, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.DepartmentId, info.Id));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("Update Complaints set StateId='{0}',CityId='{1}',VillageId='{2}',LocalityId='{3}',DepartmentTypeId='{4}',ComplaintTypeId='{5}', ReportingPersonFirstName='{6}',ReportingPersonLastName='{7}',ReportingPersonAdhaarId='{8}',ReportingPersonContactNumber='{9}',ReportingTime='{10}', CurrentStatusId='{11}', CurrentEscalationNumber='{12}', OTP='{13}', ComplaintVerifiedViaOTP='{14}', IsEscalated='{15}', DepartmentId='{16}' where Id='{17}'", info.StateId, info.CityId, info.VillageId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, info.ReportingTime, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.DepartmentId, info.Id));
            }
            
        }

        public static bool UpdateClosing(Complaint info)
        {
            // return BaseDataAccess.ExecuteSQL(String.Format("Update Complaints set StateId='{0}',CityId='{1}',VillageId='{2}',LocalityId='{3}',DepartmentTypeId='{4}',ComplaintTypeId='{5}', ReportingPersonFirstName='{6}',ReportingPersonLastName='{7}',ReportingPersonAdhaarId='{8}',ReportingPersonContactNumber='{9}',ReportingTime='{10}', CurrentStatusId='{11}', CurrentEscalationNumber='{12}', OTP='{13}', ComplaintVerifiedViaOTP='{14}', IsEscalated='{15}', DepartmentId='{16}', ClosingTime='{17}' where Id='{18}'", info.StateId, info.CityId, info.VillageId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, info.ReportingTime, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.DepartmentId, DateTime.Now ,info.Id));
            if (info.VillageId == 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("Update Complaints set StateId='{0}',CityId='{1}',LocalityId='{2}',DepartmentTypeId='{3}',ComplaintTypeId='{4}', ReportingPersonFirstName='{5}',ReportingPersonLastName='{6}',ReportingPersonAdhaarId='{7}',ReportingPersonContactNumber='{8}',ReportingTime='{9}', CurrentStatusId='{10}', CurrentEscalationNumber='{11}', OTP='{12}', ComplaintVerifiedViaOTP='{13}', IsEscalated='{14}', DepartmentId='{15}', ClosingTime='{16}' where Id='{17}'", info.StateId, info.CityId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, info.ReportingTime, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.DepartmentId, DateTime.Now ,info.Id));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("Update Complaints set StateId='{0}',CityId='{1}',VillageId='{2}',LocalityId='{3}',DepartmentTypeId='{4}',ComplaintTypeId='{5}', ReportingPersonFirstName='{6}',ReportingPersonLastName='{7}',ReportingPersonAdhaarId='{8}',ReportingPersonContactNumber='{9}',ReportingTime='{10}', CurrentStatusId='{11}', CurrentEscalationNumber='{12}', OTP='{13}', ComplaintVerifiedViaOTP='{14}', IsEscalated='{15}', DepartmentId='{16}', ClosingTime='{17}' where Id='{18}'", info.StateId, info.CityId, info.VillageId, info.LocalityId, info.DepartmentTypeId, info.ComplaintTypeId, info.ReportingPersonFirstName, info.ReportingPersonLastName, info.ReportingPersonAdhaarId, info.ReportingPersonContactNumber, info.ReportingTime, info.CurrentStatusId, info.CurrentEscalationNumber, info.OTP, info.ComplaintVerifiedViaOTP, info.IsEscalated, info.DepartmentId, DateTime.Now, info.Id));
            }
        }

        public static bool Delete(Complaint info)
        {
           return BaseDataAccess.ExecuteSQL(String.Format("Delete from Complaints where Id='{0}'",info.Id));
           
        }

        public static Complaint GetDetails(int id)
        {
            Complaint info = null;
            info= BaseDataAccess.GetRecords<Complaint>(String.Format("select * from Complaints where Id='{0}' ", id));
            if (info != null)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
                info.ComplaintType = ComplaintTypeDA.GetDetails(info.ComplaintTypeId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.CurrentStatusId);
                info.Department = DepartmentDA.GetDetails(info.DepartmentId);
            }
            return info;
        }

        

        public static List<Complaint> GetAll()
        {
            List<Complaint> list = null;
            list = BaseDataAccess.GetRecordsList<Complaint>(String.Format("select * from Complaints"));
            foreach(Complaint info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if(info.VillageId!=0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
                info.ComplaintType = ComplaintTypeDA.GetDetails(info.ComplaintTypeId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.CurrentStatusId);
            }
            return list;
        }

        public static List<Complaint> GetAllOpenComplaints(int departmentId)
        {
            List<Complaint> list = null;
            list = BaseDataAccess.GetRecordsList<Complaint>(String.Format("select * from Complaints where currentstatusid <> 4 and departmentid={0}", departmentId));
            foreach (Complaint info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
                info.ComplaintType = ComplaintTypeDA.GetDetails(info.ComplaintTypeId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.CurrentStatusId);
            }
            return list;
        }

        public static List<Complaint> GetAllByDateRange(int departmentId)
        {
            List<Complaint> list = null;
            list = BaseDataAccess.GetRecordsList<Complaint>(String.Format("select * from Complaints where departmentId={0}", departmentId));
            foreach (Complaint info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
                info.ComplaintType = ComplaintTypeDA.GetDetails(info.ComplaintTypeId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.CurrentStatusId);
            }
            return list;
        }

        public static List<Complaint> GetAllByAdhar(string Adhar)
        {
            List<Complaint> list = null;
            list = BaseDataAccess.GetRecordsList<Complaint>(String.Format("select * from Complaints where ReportingPersonAdhaarId='{0}' ", Adhar));
            foreach (Complaint info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
                info.ComplaintType = ComplaintTypeDA.GetDetails(info.ComplaintTypeId);
                info.ComplaintStatus = ComplaintStatusDA.GetDetails(info.CurrentStatusId);
            }
            return list;
        }
    }
}
