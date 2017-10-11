using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageEscalationLevels : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlVillage_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        ListItem list = new ListItem();
        list.Text = "--Select--";
        list.Value = "0";
        ddl.Items.Insert(0, list);
    }

    protected void btnAddDetails_Click(object sender, EventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.Insert);
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {

    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void DetailsView1_DataBinding(object sender, EventArgs e)
    {
        DropDownList DropDownList3 = (DropDownList)DetailsView1.FindControl("DropDownList4");
        List<BusinessObjects.DepartmentXOfficial> list = new List<BusinessObjects.DepartmentXOfficial>();
        list = BusinessLogic.DepartmentXOfficialsBL.GetAllByDepartment(Convert.ToInt32(ddlSelectDepartment.SelectedValue));

        int i1 = 0;
        foreach (BusinessObjects.DepartmentXOfficial i in list)
        {
            ListItem li = new ListItem();
            li.Value = i.GovernmentOfficialId.ToString();
            li.Text = i.GovernmentOfficial.Name;
            DropDownList3.Items.Insert(i1++, li);
            DropDownList3.DataBind();
        }
    }

    protected void DetailsView1_ModeChanged(object sender, EventArgs e)
    {
        DropDownList DropDownList3 = (DropDownList)DetailsView1.FindControl("DropDownList4");
        List<BusinessObjects.DepartmentEscalationLevel> list = BusinessLogic.DepartmentEscalationLevelBL.GetAllForDepartment(Convert.ToInt32(ddlSelectDepartment.SelectedValue));

        int i1 = 1;
        foreach (BusinessObjects.DepartmentEscalationLevel i in list)
        {
            ListItem li = new ListItem();
            li.Value = i.DepartmentId.ToString();
            li.Text = i.Department.Name;
            DropDownList3.Items.Insert(i1++, li);
            DropDownList3.DataBind();
        }
    }

    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        DropDownList DropDownList3 = (DropDownList)DetailsView1.FindControl("DropDownList4");
        List<BusinessObjects.DepartmentXOfficial> list = new List<BusinessObjects.DepartmentXOfficial>();
        list = BusinessLogic.DepartmentXOfficialsBL.GetAllByDepartment(Convert.ToInt32(ddlSelectDepartment.SelectedValue));

        int i1 = 0;
        foreach (BusinessObjects.DepartmentXOfficial i in list)
        {
            ListItem li = new ListItem();
            li.Value = i.GovernmentOfficialId.ToString();
            li.Text = i.GovernmentOfficial.Name;
            DropDownList3.Items.Insert(i1++, li);
            DropDownList3.DataBind();
        }
    }
}