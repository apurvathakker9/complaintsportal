using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Citizens_NewComplaint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        

        BusinessObjects.Complaint complaint = new BusinessObjects.Complaint();
        complaint.StateId = Convert.ToInt32(ddlState.SelectedValue);
        complaint.CityId = Convert.ToInt32(ddlCity.SelectedValue);
        complaint.LocalityId = Convert.ToInt32(ddlLocality.SelectedValue);
        complaint.DepartmentTypeId = Convert.ToInt32(ddlDepartmentType.SelectedValue);
        complaint.ComplaintTypeId = Convert.ToInt32(ddlComplaintType.SelectedValue);
        complaint.ReportingPersonFirstName = txtFirstName.Text;
        complaint.ReportingPersonLastName = txtLastName.Text;
        complaint.ReportingPersonAdhaarId = txtAdharId.Text;
        complaint.Description = txtDescription.Text;


        if (FileUpload1.HasFile)
        {
            String RelativePath = "~/Uploads";
            string AbsolutePath = Server.MapPath(RelativePath);

            string Extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            Guid g = Guid.NewGuid();

            string PathToSave = String.Format("{0}/{1}{2}", AbsolutePath, g.ToString(), Extension);

            FileUpload1.SaveAs(PathToSave);

            //To save to DB
            string Db = string.Format("{0}/{1}{2}", RelativePath, g.ToString(), Extension);

            complaint.Image = Db;
        }

        BusinessObjects.AdhaarXContactNumber axcn = BusinessLogic.AdharXContactNumberBL.GetDetailsByAdhaar(complaint.ReportingPersonAdhaarId);

        complaint.ReportingPersonContactNumber = axcn.ContactNumber;
        complaint.OTP = "123456";
        complaint.CurrentEscalationNumber = 0;
        complaint.CurrentStatusId = 1;

        BusinessObjects.Department department = BusinessLogic.DepartmentBL.GetDetailsByLocationAndType(complaint.StateId, complaint.CityId, complaint.VillageId, complaint.LocalityId, complaint.DepartmentTypeId);
        complaint.DepartmentId = department.Id;

        int ComplaintId=BusinessLogic.ComplaintBL.Add(complaint);

        //Send SMS here

        string Message = String.Format("Your OTP for Complaint ID:{0} is {1}", ComplaintId, complaint.OTP);

        OutwardCommunication.SMSHelper.SendSMS(Message, complaint.ReportingPersonContactNumber);

        pnlStart.Visible = false;
        AfterOTPVerification.Visible = false;
        pnlVerifyOTP.Visible = true;
    }



    protected void btnVerifyOTP_Click(object sender, EventArgs e)
    {
        int ComplaintNumber = Convert.ToInt32(txtComplaintNumber.Text);

        BusinessObjects.Complaint complaint = BusinessLogic.ComplaintBL.GetDetails(ComplaintNumber);

        if (txtOTP.Text == complaint.OTP)
        {
            complaint.ComplaintVerifiedViaOTP = true;
            complaint.CurrentStatusId = 1;
            BusinessLogic.ComplaintBL.Update(complaint);
        }



        

        // Step 2

        BusinessObjects.ComplaintXStatus cxs = new BusinessObjects.ComplaintXStatus();
        cxs.ComplaintId = complaint.Id;
        cxs.StatusId = 1;
        cxs.StatusAssignTime = DateTime.Now;

        BusinessLogic.ComplaintXStatusBL.Add(cxs);

        // Step 3

        BusinessObjects.DepartmentXAreaOnDuty dxaod = BusinessLogic.DepartmentXAreaOnDutyBL.GetByTime(complaint.DepartmentId, DateTime.Now);

        BusinessObjects.OfficialXComplaintsAssigned oxca = new BusinessObjects.OfficialXComplaintsAssigned();
        oxca.ComplaintId = complaint.Id;
        oxca.OfficialId = dxaod.OnDutyPersonId;
        oxca.AssignedOn = DateTime.Now;
        oxca.IsEscalated = false;

        BusinessLogic.OfficialXComplaintsAssignedBL.Add(oxca);

        // Step 4

        // Send SMS to the per on duty
        // To send the SMS we will need the phone number of the official

        BusinessObjects.GovernmentOfficial go = BusinessLogic.GovernmentOfficialsBL.GetDetails(oxca.OfficialId);
        string phoneNumber = go.ContactNumber;
        string Message = String.Format("A new Complaint has been registered for your Department. Click the link to see the full Complaint. {0}", "http://www.google.com");

        OutwardCommunication.SMSHelper.SendSMS(Message, phoneNumber);

        AfterOTPVerification.Visible = true;
        pnlVerifyOTP.Visible = false;
        pnlStart.Visible = false;

        //Response.Redirect("~/Citizens/Default.aspx");
    }

    protected void ddlVillage_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;

        ListItem li = new ListItem();
        li.Text = "- Select -";
        li.Value = "0";

        ddl.Items.Insert(0, li);
    }
}