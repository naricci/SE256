using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class OrderSearch : System.Web.UI.Page
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
        PizzaOrders temp = new PizzaOrders();

        DataSet ds = temp.SearchOrders(txtFirstName.Text, txtLastName.Text);

        gvOrders.DataSource = ds;
        gvOrders.DataMember = ds.Tables[0].TableName;
        gvOrders.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the TextBoxes
        txtFirstName.Text = "";
        txtLastName.Text = "";
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("/Controls/Default.aspx");
    }
}