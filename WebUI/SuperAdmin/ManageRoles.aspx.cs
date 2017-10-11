using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageRoles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddroles_Click(object sender, EventArgs e)
    {
        System.Web.Security.Roles.CreateRole(txtRoleName.Text);
        gridAllRoles.DataBind();
    }
}