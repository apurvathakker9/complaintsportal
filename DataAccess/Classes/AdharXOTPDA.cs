using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class AdharXOTPDA
    {
        public static bool Add(AdhaarXOTP info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("insert into AdhaarXOTP(AdhaarNumber, OTP) values('{0}', '{1}') ", info.AdhaarNumber, info.OTP));
        }

        public static bool Update(AdhaarXOTP info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("update AdhaarXOTP set AdhaarNumber='{0}', OTP='{1}' where Id='{2}' ", info.AdhaarNumber,info.OTP, info.Id));
        }

        public static bool Delete(AdhaarXOTP info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from AdhaarXOTP where Id='{0}' ", info.Id));
        }

        public static AdhaarXOTP GetDetails(int id)
        {
            AdhaarXOTP info = null;
            info= BaseDataAccess.GetRecords<AdhaarXOTP>(String.Format("select * from AdhaarXOTP where Id='{0}' ", id));
            return info;
        }

        public static List<AdhaarXOTP> GetAll()
        {
            List<AdhaarXOTP> list = null;
            list= BaseDataAccess.GetRecordsList<AdhaarXOTP>(String.Format("select * from AdhaarXOTP"));
            return list;
        }
    }
}
