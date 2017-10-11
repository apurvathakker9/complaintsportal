using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

public partial class OnDutyOfficial_ComplaintsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Request.QueryString["ComplaintId"] != null)
        {
            txtSearchComplaint.Text = Request.QueryString["ComplaintId"];
        }
        if (Request.IsAuthenticated)
        {
            pnlFixed.Visible = true;
        }
        else
        {
            pnlEscalationbtn.Visible = true;
            pnlClosed.Visible = true;
        }
    }


    protected void btnSearchComplaint_Click(object sender, EventArgs e)
    {
        if(!string.IsNullOrEmpty(txtSearchComplaint.Text))
        {
        
        Response.Redirect(string.Format("ComplaintsDetails.aspx?ComplaintId={0}", txtSearchComplaint.Text));
        }
        
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        BusinessObjects.Complaint info = new BusinessObjects.Complaint();
        info.Id = Convert.ToInt32(Request.QueryString["ComplaintId"]);
        info =  BusinessLogic.ComplaintBL.GetDetails(info.Id);
        if(info.CurrentStatusId != 4)
        {
            info.CurrentStatusId = 4;
            BusinessLogic.ComplaintBL.UpdateClosing(info);

            BusinessObjects.ComplaintXStatus obj = new BusinessObjects.ComplaintXStatus();
            obj.ComplaintId = Convert.ToInt32(Request.QueryString["ComplaintId"]);
            obj.StatusId = 4;
            BusinessLogic.ComplaintXStatusBL.Add(obj);

            ddComplaintDetails.DataBind();
        }
        else
        {
            Response.Write("<script>alert('Complaint is already Closed!')</script>");
        }
        
        
        
        
    }
    protected void btnFixed_Click(object sender, EventArgs e)
    {
        BusinessObjects.Complaint info = new BusinessObjects.Complaint();
        info.Id = Convert.ToInt32(Request.QueryString["ComplaintId"]);
        info = BusinessLogic.ComplaintBL.GetDetails(info.Id);
        if(info.CurrentStatusId != 3 && info.CurrentStatusId != 4)
        {
            info.CurrentStatusId = 3;
            BusinessLogic.ComplaintBL.Update(info);

            BusinessObjects.ComplaintXStatus obj = new BusinessObjects.ComplaintXStatus();
            obj.ComplaintId = Convert.ToInt32(Request.QueryString["ComplaintId"]);
            obj.StatusId = 3;
            BusinessLogic.ComplaintXStatusBL.Add(obj);

            ddComplaintDetails.DataBind();
        }
        else
        {
            Response.Write("<script>alert('Complaint is Already Fixed!')</script>");

        }
        
    }
    protected void btnEscalate_Click(object sender, EventArgs e)
    {
        pnlEscalation.Visible = true;
        pnlEscalationbtn.Visible = false;
        pnlClosed.Visible = false;
    }

        
    protected void btnEscalateReason_Click(object sender, EventArgs e)
    {
        BusinessObjects.Complaint info = new BusinessObjects.Complaint();
        info.Id = Convert.ToInt32(Request.QueryString["ComplaintId"]);
        info = BusinessLogic.ComplaintBL.GetDetails(info.Id);
        info.IsEscalated = true;
        info.CurrentEscalationNumber = info.CurrentEscalationNumber + 1;

        BusinessLogic.ComplaintBL.Update(info);

        BusinessObjects.DepartmentEscalationLevel obj = new BusinessObjects.DepartmentEscalationLevel();
        obj = BusinessLogic.DepartmentEscalationLevelBL.GetDetailsByDepartmentId(info.DepartmentId,info.CurrentEscalationNumber);

        BusinessObjects.GovernmentOfficial go = new BusinessObjects.GovernmentOfficial();
        go = BusinessLogic.GovernmentOfficialsBL.GetDetails(obj.DesignatedOfficialId);

        OutwardCommunication.EmailHelper.SendComplaintEscalationEmail(go.Name, go.ContactEmail, Request.QueryString["ComplaintId"], info.Description);

        BusinessObjects.ComplaintXEscalationLevel cxe = new BusinessObjects.ComplaintXEscalationLevel();
        //cxe = BusinessLogic.ComplaintXEscalationLevelBL.GetDetails(Convert.ToInt32(Request.QueryString["ComplaintId"]));
        cxe.ComplaintId = Convert.ToInt32(Request.QueryString["ComplaintId"]);
        //cxe.EscalationLevelNumber = cxe.EscalationLevelNumber + 1;
        cxe.EscalationLevelNumber = info.CurrentEscalationNumber;
        cxe.EscalationTime = DateTime.Now;
        cxe.EscalationReason = txtEscalationReason.Text;
        BusinessLogic.ComplaintXEscalationLevelBL.Add(cxe);

        ddComplaintDetails.DataBind();
        
    }

    
}