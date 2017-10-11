using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

/// <summary>
/// Data Access layer is used to provide connection between the Business logic layer and the database with the below function.
/// </summary>
namespace DataAccess
{
    public class AdharXContactNumberDA
    {
        public static bool Add(AdhaarXContactNumber info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into AdhaarXContactNumber(AdhaarNumber, ContactNumber) values('{0}', '{1}') ", info.AdhaarNumber, info.ContactNumber));
        }

        public static bool Update(AdhaarXContactNumber info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update AdhaarXContactNumber set AdhaarNumber='{0}', ContactNumber='{1}' where Id='{2}'  ", info.AdhaarNumber, info.ContactNumber, info.Id));
        }

        public static bool Delete(AdhaarXContactNumber info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from AdhaarXContacNumber where Id='{0}' ", info.Id));
        }

        public static AdhaarXContactNumber GetDetails(int id)
        {
            string sql = String.Format("select * from AdhaarXContactNumber where Id='{0}' ", id);
            AdhaarXContactNumber obj = null;
            obj = BaseDataAccess.GetRecords<AdhaarXContactNumber>(sql);
            return obj;
        }

        public static AdhaarXContactNumber GetDetailsByAdhaar(string Adhaar)
        {
            string sql = String.Format("select * from AdhaarXContactNumber where AdhaarNumber='{0}' ", Adhaar);
            AdhaarXContactNumber obj = null;
            obj = BaseDataAccess.GetRecords<AdhaarXContactNumber>(sql);
            return obj;
        }

        public static List<AdhaarXContactNumber> GetAll()
        {
            List<AdhaarXContactNumber> list = null;
            list = BaseDataAccess.GetRecordsList<AdhaarXContactNumber>(String.Format("select * from AdhaarXContactNumber"));
            return list;
        }
    }
}
