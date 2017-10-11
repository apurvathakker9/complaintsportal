using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OutwardCommunication
{
    public class SMSHelper
    {
        public static void SendSMS( string Message, string phoneNo)
        {
            string smsUrl = string.Format("http://msg.msgclub.net/rest/services/sendSMS/sendGroupSms?AUTH_KEY=e8d5a4346bdad8f4a18a7b4779efeec5&message={0}&senderId=OpenES&routeId=1&mobileNos={1}&smsContentType=english", Message, phoneNo);

            System.Net.HttpWebRequest request = System.Net.HttpWebRequest.CreateHttp(smsUrl);
            request.Method = "GET";

            System.Net.WebResponse response = request.GetResponse();

            TextReader tr = new StreamReader(response.GetResponseStream());

            string html = tr.ReadToEnd();
        }
        
    }
}
