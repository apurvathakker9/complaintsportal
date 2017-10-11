using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin_ManageGovernmentOfficials : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddNewOfficial_Click(object sender, EventArgs e)
    {
        dvOfficialDetails.ChangeMode(DetailsViewMode.Insert);
    }

    protected void dvOfficialDetails_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        grdAllOfficials.DataBind();

        string PhoneNumber = e.Values["ContactNumber"].ToString();
        string EmailId = e.Values["ContactEmail"].ToString();
        System.Web.Security.MembershipCreateStatus status;
        String name = e.Values["Name"].ToString();

        System.Web.Security.Membership.CreateUser(PhoneNumber, "Password123!", EmailId, "What is your Name?", "ABC", true, out status);

        OutwardCommunication.EmailHelper.SendAccountCreationEmail(name, EmailId, PhoneNumber, "Password123!");
    }

    protected void dvOfficialDetails_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        grdAllOfficials.DataBind();
    }

    protected void dvOfficialDetails_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        FileUpload FileUpload1 = (FileUpload)dvOfficialDetails.FindControl("FileUpload2");

        if (FileUpload1.HasFile)
        {
            String RelativePath = "~/Uploads/Officials";
            string AbsolutePath = Server.MapPath(RelativePath);

            string Extension = System.IO.Path.GetExtension(FileUpload1.FileName);
            Guid g = Guid.NewGuid();

            string PathToSave = String.Format("{0}/{1}{2}", AbsolutePath, g.ToString(), Extension);

            FileUpload1.SaveAs(PathToSave);

            //To save to DB
            string Db = string.Format("{0}/{1}{2}", RelativePath, g.ToString(), Extension);

            e.Values.Add("Picture", Db);
        }
    }

    protected void dvOfficialDetails_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        FileUpload FileUpload2 = (FileUpload)dvOfficialDetails.FindControl("FileUpload1");

        if (FileUpload2.HasFile)
        {
            String RelativePath = "~/Uploads/Officials";
            string AbsolutePath = Server.MapPath(RelativePath);

            string Extension = System.IO.Path.GetExtension(FileUpload2.FileName);
            Guid g = Guid.NewGuid();

            string PathToSave = String.Format("{0}/{1}{2}", AbsolutePath, g.ToString(), Extension);

            FileUpload2.SaveAs(PathToSave);

            //To save to DB
            string Db = string.Format("{0}/{1}{2}", RelativePath, g.ToString(), Extension);

            e.NewValues.Add("Picture", Db);
        }
    }

    protected void ddlDesignation_DataBound(object sender, EventArgs e)
    {
        DropDownList ddl = (DropDownList)sender;
        ListItem list = new ListItem();
        list.Text = "--Select--";
        list.Value = "0";
        ddl.Items.Insert(0, list);
    }
}