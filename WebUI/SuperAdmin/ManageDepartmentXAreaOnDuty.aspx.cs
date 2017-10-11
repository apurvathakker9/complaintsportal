using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageDepartmentXAreaOnDuty : System.Web.UI.Page
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

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        DetailsView1.DataBind();
    }

    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        TextBox txtNewCode = (TextBox)DetailsView1.FindControl("txtNewCode");
        BusinessObjects.GovernmentOfficial info = BusinessLogic.GovernmentOfficialsBL.GetDetails(txtNewCode.Text);

        e.Values.Add("OnDutyPersonId", info.Id);
        e.Values.Add("CityId", ddlCity.SelectedValue);
        e.Values.Add("StateId", ddlState.SelectedValue);
        e.Values.Add("LocalityId", ddlLocality.SelectedValue);
        if(e.Values.Contains("VillageId"))
            e.Values.Add("VillageId", ddlVillage.SelectedValue);
        e.Values.Add("DepartmentId", ddlSelectDepartment.SelectedValue);        
    }

    protected void DetailsView1_DataBinding(object sender, EventArgs e)
    {

    }

    protected void GridView1_DataBinding(object sender, EventArgs e)
    {
        
    }
}