using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PersonSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            //do nothing...they are good
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Person temp = new Person();

        DataSet ds = temp.SearchContacts(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text);

        gvPersons.DataSource = ds;
        gvPersons.DataMember = ds.Tables[0].TableName;
        gvPersons.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the TextBoxes
        txtFirstName.Text = "";
        txtMiddleName.Text = "";
        txtLastName.Text = "";
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // Kill Session Variable
        Session.Abandon();

        // Redirest back to LogIn Page
        Response.Redirect("/Controls/Default.aspx");
    }
}