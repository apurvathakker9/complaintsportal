using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageLocalities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnNewLocality_Click(object sender, EventArgs e)
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
        e.Values.Add("CityId", ddlCity.SelectedValue);
        e.Values.Add("VillageId", ddlVillage.SelectedValue);

        if (!e.Values.Contains("Latitude"))
            e.Values.Add("Latitude", "");
        else
            e.Values["Latitude"] = "";
        if (!e.Values.Contains("Longitude"))
            e.Values.Add("Longitude", "");
        else
            e.Values["Longitude"] = "";
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        DetailsView1.DataBind();
    }

    protected void ddlVillage_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;

        ListItem li = new ListItem();
        li.Text = "- Select -";
        li.Value = "0";

        ddl.Items.Insert(0, li);
    }

    protected void DetailsView1_ItemInserted1(object sender, DetailsViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void DetailsView1_ItemUpdated1(object sender, DetailsViewUpdatedEventArgs e)
    {
        GridView1.DataBind();

    }

    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {

        e.NewValues.Add("CityId", ddlCity.SelectedValue);
        e.NewValues.Add("VillageId", ddlVillage.SelectedValue);

        if (!e.NewValues.Contains("Latitude"))
            e.NewValues.Add("Latitude", "");
        else
            e.NewValues["Latitude"] = "";
        if (!e.NewValues.Contains("Longitude"))
            e.NewValues.Add("Longitude", "");
        else
            e.NewValues["Longitude"] = "";
    }
}