using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Citizens_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddComplaint_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Citizens/NewComplaint.aspx");
    }
    protected void btnMyComplaints_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Citizens/MyComplaints.aspx");
    }
}