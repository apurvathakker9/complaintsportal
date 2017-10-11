using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageDepartments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
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

    protected void btnAddDepartment_Click(object sender, EventArgs e)
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

    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        if (!e.Values.Contains("StateId"))
            e.Values.Add("StateId", ddlState.SelectedValue);
        else
            e.Values["StateId"] = ddlState.SelectedValue;
        if (!e.Values.Contains("CityId"))
            e.Values.Add("CityId", ddlCity.SelectedValue);
        else
            e.Values["CityId"] = ddlCity.SelectedValue;
        if (!e.Values.Contains("VillageId"))
            e.Values.Add("VillageId", ddlVillage.SelectedValue);
        else
            e.Values["VillageId"] = ddlVillage.SelectedValue;
        if (!e.Values.Contains("LocalityId"))
            e.Values.Add("LocalityId", ddlLocality.SelectedValue);
        else
            e.Values["LocalityId"] = ddlLocality.SelectedValue;
        if (!e.Values.Contains("DepartmentTypeId"))
            e.Values.Add("DepartmentTypeId", ddlDepartmentType.SelectedValue);
        else
            e.Values["DepartmentTypeId"] = ddlDepartmentType.SelectedValue;
    }

    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        if (!e.NewValues.Contains("StateId"))
            e.NewValues.Add("StateId", ddlState.SelectedValue);
        else
            e.NewValues["StateId"] = ddlState.SelectedValue;
        if (!e.NewValues.Contains("CityId"))
            e.NewValues.Add("CityId", ddlCity.SelectedValue);
        else
            e.NewValues["CityId"] = ddlCity.SelectedValue;
        if (!e.NewValues.Contains("VillageId"))
            e.NewValues.Add("VillageId", ddlVillage.SelectedValue);
 
        if (!e.NewValues.Contains("LocalityId"))
            e.NewValues.Add("LocalityId", ddlLocality.SelectedValue);
        else
            e.NewValues["LocalityId"] = ddlLocality.SelectedValue;
        if (!e.NewValues.Contains("DepartmentTypeId"))
            e.NewValues.Add("DepartmentTypeId", ddlDepartmentType.SelectedValue);
        else
            e.NewValues["DepartmentTypeId"] = ddlDepartmentType.SelectedValue;
    }
}