using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DepartmentOfficials_ComplaintsAvrageTimeReport : System.Web.UI.Page
{
    public string GraphReportData = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        HiddenField1.Value = User.Identity.Name;
    }

    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        List<BusinessObjects.Complaint> allComplaints = BusinessLogic.ComplaintBL.GetAllByDateRange(Convert.ToInt32(ddlDepartments.SelectedValue));

        int count = 1;

        foreach(BusinessObjects.Complaint complaint in allComplaints)
        {
            GraphReportData += string.Format("[{0}, {1}],", count, complaint.ClosingTime.Subtract(complaint.ReportingTime).Hours);
            count++;
        }
        

        pnlReport.Visible = true;
    }
}