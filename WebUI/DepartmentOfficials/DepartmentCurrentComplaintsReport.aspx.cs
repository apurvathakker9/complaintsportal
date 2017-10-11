using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DepartmentOfficials_DepartmentCurrentComplaintsReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated)
        {
            hfUserName.Value = User.Identity.Name;
        }
    }

    protected void btnShowComplaintsStatus_Click(object sender, EventArgs e)
    {
        List<BusinessObjects.Complaint> allComplaints = BusinessLogic.ComplaintBL.GetAllOpenComplaints(Convert.ToInt16(ddlDepartment.SelectedValue));

        lblAllComplaints.Text = allComplaints.Count.ToString();
        lblFixedComplaints.Text = allComplaints.Where(c => c.CurrentStatusId == 3).Count().ToString();
        lblOpenComplaints.Text = allComplaints.Where(c => c.CurrentStatusId == 1 || c.CurrentStatusId == 2).Count().ToString();

        grdOpenComplaints.DataSource = allComplaints;
        grdOpenComplaints.DataBind();

    }
}