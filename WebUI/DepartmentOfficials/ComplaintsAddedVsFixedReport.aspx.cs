using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DepartmentOfficials_ComplaintsAddedVsFixedReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated)
        {
            HiddenField1.Value = User.Identity.Name;
            //string un = User.Identity.Name;
            //BusinessObjects.GovernmentOfficial info = null;
            //info = BusinessLogic.GovernmentOfficialsBL.GetDetailsByContactNumber(un);

            //List<BusinessObjects.DepartmentXOfficial> list = BusinessLogic.DepartmentXOfficialsBL.GetAllForOfficial(info.Id);
            //int i1 = 0;
            //foreach (BusinessObjects.DepartmentXOfficial i in list)
            //{
            //    ListItem li = new ListItem();
            //    li.Value = i.DepartmentId.ToString();
            //    li.Text = i.Department.Name;
            //    ddlDepartments.Items.Insert(i1++, li);
            //}
        }
    }

    protected void btnViewReport_Click(object sender, EventArgs e)
    {
        pnlReport.Visible = true;
    }
}