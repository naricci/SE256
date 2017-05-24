using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Default : System.Web.UI.Page
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
            Session["UserName"] = "Scott";
            //Shoot off to control panel
            Response.Redirect("OrderForm.aspx");
        }
        else
        {
            lblFeedback.Text = "Sorry...Login Failed!";
            Session.Abandon();
        }
    }
}