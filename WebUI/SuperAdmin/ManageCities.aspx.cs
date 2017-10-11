﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageCities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddCity_Click(object sender, EventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.Insert);
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        DetailsView1.DataBind();
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
        e.Values.Add("StateId",ddlStates.SelectedValue);
    }

    protected void ddlStates_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        ListItem list = new ListItem();
        list.Text = "--Select--";
        list.Value = "0";
        ddl.Items.Insert(0, list);
    }
}