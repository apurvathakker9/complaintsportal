using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;


namespace OutwardCommunication
{
    public class EmailHelper
    {
    //SendAccountCreationEmail
        public static void SendAccountCreationEmail(string personName, string emailId, string username, string password)
        {
            MailMessage message = new MailMessage();
            message.Subject = System.Configuration.ConfigurationManager.AppSettings["AccountCreationEmailSubject"];
            string EmailTemplatesFilePath = System.Configuration.ConfigurationManager.AppSettings["EmailTemplateFolder"];
            string EmailFileName = System.Configuration.ConfigurationManager.AppSettings["AccountCreationEmail"];
            string BodyContent = System.IO.File.ReadAllText(String.Format("{0}/{1}", EmailTemplatesFilePath, EmailFileName));
            message.Body = BodyContent.Replace("$personName$", personName).Replace("$username$", username).Replace("$password$", password);
            message.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["MailFrom"]);
            message.To.Add(emailId);
            message.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
            smtpClient.Port = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"]);
            smtpClient.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EnableSSL"]);
            smtpClient.Credentials = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["MailFrom"], System.Configuration.ConfigurationManager.AppSettings["Password"]);
            smtpClient.Send(message);  
        }

        //SendComplaintEscalationEmail
        public static void SendComplaintEscalationEmail(string departmentHead, string emailId, string complaintId, string complaintDescription)
        {
            MailMessage message = new MailMessage();
            message.Subject = System.Configuration.ConfigurationManager.AppSettings["ComplaintEscalationEmailSubject"];
            string EmailTemplatesFilePath = System.Configuration.ConfigurationManager.AppSettings["EmailTemplateFolder"];// System.Web.HttpContext.Current.Server.MapPath("~/EmailTemplates");
            string EmailFileName = System.Configuration.ConfigurationManager.AppSettings["ComplaintEscalationEmail"];
            string BodyContent = System.IO.File.ReadAllText(String.Format("{0}/{1}", EmailTemplatesFilePath, EmailFileName));
            message.Body = BodyContent.Replace("$complaintId$", complaintId).Replace("$departmentHead$",departmentHead).Replace("$complaintDescription$", complaintDescription);
            message.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["MailFrom"]);
            message.To.Add(emailId);
            message.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
            smtpClient.Port = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"]);
            smtpClient.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EnableSSL"]);
            smtpClient.Credentials = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["MailFrom"], System.Configuration.ConfigurationManager.AppSettings["Password"]);
            smtpClient.Send(message);
        }
        //SendComplaintFixedEmail
        public static void SendComplaintFixedEmail(string personName, string emailId, string complaintId)
        {
            MailMessage message = new MailMessage();
            message.Subject = System.Configuration.ConfigurationManager.AppSettings["ComplaintFixedEmailSubject"];
            string EmailTemplatesFilePath = System.Configuration.ConfigurationManager.AppSettings["EmailTemplateFolder"];
            string EmailFileName = System.Configuration.ConfigurationManager.AppSettings["ComplaintFixedEmail"];
            string BodyContent = System.IO.File.ReadAllText(String.Format("{0}/{1}", EmailTemplatesFilePath, EmailFileName));
            message.Body = BodyContent.Replace("$personName$", personName).Replace("$complaintId$", complaintId);
            message.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["MailFrom"]);
            message.To.Add(emailId);
            message.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
            smtpClient.Port = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"]);
            smtpClient.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EnableSSL"]);
            smtpClient.Credentials = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["MailFrom"], System.Configuration.ConfigurationManager.AppSettings["Password"]);
            smtpClient.Send(message);
        }
        //ContactUs
        
        public static void GetContactUs(string personName, string emailId, string phoneNumber, string personEmail)
        {
            MailMessage message = new MailMessage();
            message.Subject = System.Configuration.ConfigurationManager.AppSettings["ContactUs"];
            string EmailTemplatesFilePath = System.Configuration.ConfigurationManager.AppSettings["EmailTemplateFolder"];
            string EmailFileName = System.Configuration.ConfigurationManager.AppSettings["ContactUsEmail"];
            string BodyContent = System.IO.File.ReadAllText(String.Format("{0}/{1}",EmailTemplatesFilePath,EmailFileName));
            message.Body = BodyContent.Replace("$personName$", personName).Replace("$phoneNumber$", phoneNumber).Replace("$personEmail$", personEmail);
            message.From = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["MailFrom"]);
            message.To.Add(emailId);
            message.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


            smtpClient.Host = System.Configuration.ConfigurationManager.AppSettings["SMTPServer"];
            smtpClient.Port = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"]);
            smtpClient.EnableSsl = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EnableSSL"]);
            smtpClient.Credentials = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["MailFrom"], System.Configuration.ConfigurationManager.AppSettings["Password"]);
            smtpClient.Send(message);
        }
    }
  }
