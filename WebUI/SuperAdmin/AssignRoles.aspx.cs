using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_AssignRoles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAssignRoles_Click(object sender, EventArgs e)
    {
        System.Web.Security.Roles.AddUserToRole(ddAllUsers.SelectedValue, ddAllRoles.SelectedValue);
        pnlAfterAssign.Visible = true;
    }

    protected void ddAllUsers_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        ListItem list = new ListItem();
        list.Text = "--Select--";
        list.Value = "0";
        ddl.Items.Insert(0, list);
    }
}