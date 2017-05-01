using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "Scott" && txtPassword.Text == "NEIT")
        {
            //Give them a key first
            Session["LoggedIn"] = "TRUE";

            //Shoot off to control panel
            Response.Redirect("/Controls/ContentMgr.aspx");
        }
        else
        {
            lblFeedback.Text = "Sorry...Login Failed!";
            Session.Abandon();
        }
    }
}