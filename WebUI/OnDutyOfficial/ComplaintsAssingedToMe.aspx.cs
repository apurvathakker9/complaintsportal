using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OnDutyOfficial_ComplaintsAssingedToMe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Request.IsAuthenticated)
        {
            Response.Redirect("~/Login.aspx");
        }
        BusinessObjects.GovernmentOfficial obj = new BusinessObjects.GovernmentOfficial();
        obj =  BusinessLogic.GovernmentOfficialsBL.GetDetailsByContactNumber( System.Threading.Thread.CurrentPrincipal.Identity.Name);

        if(obj!=null)
        {
            HiddenField1.Value = Convert.ToString(obj.Id);
        }
    }


}