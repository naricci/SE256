using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class OrderForm : System.Web.UI.Page
{
    double pizzaPrice, toppingPrice;
    string pizzaSize, pizzaTopping;

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
        
        // Default Drop Down Lists to specific city/state
        ddlCity.SelectedIndex = 2;
        ddlState.SelectedIndex = 3;
        rbSmall.Checked = true;

        string strOrd_ID = "";
        int intOrd_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Ord_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strOrd_ID = Request.QueryString["Ord_ID"].ToString();
            lblOrder_ID.Text = strOrd_ID;

            intOrd_ID = Convert.ToInt32(strOrd_ID);

            //Fill the "temp" order's info based on ID
            PizzaOrders temp = new PizzaOrders();
            SqlDataReader dr = temp.FindOneOrder(intOrd_ID);
            
            while (dr.Read())
            {
                pizzaSize = dr["PizzaSize"].ToString();
                pizzaTopping = dr["Toppings"].ToString();
                txtFirstName.Text = dr["FirstName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                ddlCity.SelectedValue = dr["City"].ToString();
                ddlState.SelectedValue = dr["State"].ToString();
                txtZipCode.Text = dr["ZipCode"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtTotalCost.Text = dr["TotalCost"].ToString();
            }
            
        }
        else
        {
            //Do nothing....basic add page (empty)
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool isValid = true;

        // Check if First Name is filled in
        if (!ValidationLibrary.IsItFilledIn(txtFirstName.Text))
        {
            isValid = false;
            lbxOrder.Items.Add("Please enter a First Name.\n");
        }

        // Check if Last Name is filled in
        if (!ValidationLibrary.IsItFilledIn(txtLastName.Text))
        {
            isValid = false;
            lbxOrder.Items.Add("Please enter a Last Name.\n");
        }

        // Check if Email Address is Valid
        if (!ValidationLibrary.IsValidEmail(txtEmail.Text))
        {
            isValid = false;
            lbxOrder.Items.Add("Please enter a valid Email Address.\n");
        }

        // Check if Phone Number is Valid
        if (!ValidationLibrary.IsValidPhoneNumber(txtPhone.Text))
        {
            isValid = false;
            lbxOrder.Items.Add("Please enter a valid Phone Number.\n");
        }

        if (isValid) //Adds Everything together
        {
            // Clear Order Total Label
            lblOrder.Text = "";
            txtTotalCost.Text = "";

            //rblSize.SelectedValue = pizzaSize;

            PizzaOrders temp = new PizzaOrders();

            temp.PizzaSize = pizzaSize;
            temp.Toppings = pizzaTopping;
            temp.FirstName = txtFirstName.Text;
            temp.LastName = txtLastName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = ddlCity.SelectedValue;
            temp.State = ddlState.SelectedValue;
            temp.ZipCode = txtZipCode.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            temp.TotalCost = pizzaPrice + toppingPrice;

            // Display errors or results in Feedback Label
            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                // FillLabel(temp);
                lblFeedback.Text = temp.AddOrder();

                txtTotalCost.Text += (pizzaPrice + toppingPrice).ToString("c");

                // Add Total Price to Order Label
                lblOrder.Text += (pizzaPrice + toppingPrice).ToString("c");    // was ToString("c");

                // Add Order Data to ListBox
                // Display Order info in ListBox
                lbxOrder.Items.Add("Your Order:");
                lbxOrder.Items.Add(pizzaSize + " Pizza with" + pizzaTopping);
                lbxOrder.Items.Add("Delivery Info:");
                lbxOrder.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
                lbxOrder.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
                lbxOrder.Items.Add(ddlCity.Text + ", " + ddlState.Text + ", " + txtZipCode.Text);
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        PizzaOrders temp = new PizzaOrders();
        temp.PizzaSize = pizzaSize;
        temp.Toppings = pizzaTopping;
        temp.FirstName = txtFirstName.Text;
        temp.LastName = txtLastName.Text;
        temp.Street1 = txtStreet1.Text;
        temp.Street2 = txtStreet2.Text;
        temp.City = ddlCity.SelectedValue;
        temp.State = ddlState.Text;
        temp.ZipCode = txtZipCode.Text;
        temp.Phone = txtPhone.Text;
        temp.Email = txtEmail.Text;
        temp.TotalCost = double.Parse(txtTotalCost.Text);


        // store ID of the person being updated
        temp.Order_ID = Convert.ToInt32(lblOrder_ID.Text);

        lblFeedback.Text = temp.UpdateAnOrder().ToString() + " Order Updated.";
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        PizzaOrders temp = new PizzaOrders();

        temp.Order_ID = Convert.ToInt32(lblOrder_ID.Text);

        lblFeedback.Text = temp.DeleteOneOrder(temp.Order_ID) + " Order Deleted.";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Reset variable values
        pizzaPrice = 0;
        toppingPrice = 0;
        pizzaTopping = "";

        rbSmall.Checked = true;

        // Clear Checkboxes
        chkPepperoni.Checked = false;
        chkSausage.Checked = false;
        chkMeatball.Checked = false;
        chkHam.Checked = false;
        chkPeppers.Checked = false;
        chkOnions.Checked = false;
        chkOlives.Checked = false;
        chkSpinach.Checked = false;
        chkPineapple.Checked = false;
        chkBBQSauce.Checked = false;
        chkExtraCheese.Checked = false;

        // Clear City/State Drop Down Lists back to default
        ddlCity.SelectedIndex = 2;
        ddlState.SelectedIndex = 3;

        // Clear ListBox
        lbxOrder.Items.Clear();

        // Reset ALL Labels
        lblFeedback.Text = "";
        lblOrder.Text = "";
        lblOrder_ID.Text = "";
        lblTotalCost.Text = "";

        // Reset TextBoxes
        txtTotalCost.Text = "0";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtStreet1.Text = "";
        txtStreet2.Text = "";
        txtZipCode.Text = "";
        txtPhone.Text = "";
        txtEmail.Text = "";
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // Kill Session Variable
        Session.Abandon();

        // Redirect back to LogIn Page
        Response.Redirect("/Controls/Default.aspx");
    }
    
    protected void chkPepperoni_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Pepperoni";
        toppingPrice += 0.50;
    }

    protected void chkSausage_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Sausage";
        toppingPrice += 0.50;
    }

    protected void chkMeatball_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Meatball";
        toppingPrice += 0.50;
    }

    protected void chkHam_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Ham";
        toppingPrice += 0.50;
    }

    protected void chkPeppers_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Peppers";
        toppingPrice += 0.50;
    }

    protected void chkOnions_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Onions";
        toppingPrice += 0.50;
    }

    protected void chkOlives_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Olives";
        toppingPrice += 0.50;
    }

    protected void chkSpinach_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Spinach";
        toppingPrice += 0.50;
    }

    protected void chkBBQSauce_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " BBQ Sauce";
        toppingPrice += 0.50;
    }

    protected void chkPineapple_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Pineapple";
        toppingPrice += 0.50;
    }

    protected void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
    {
        pizzaTopping += " Extra Cheese";
        toppingPrice += 0.50;
    }

    protected void rbSmall_CheckedChanged(object sender, EventArgs e)
    {
        pizzaPrice = 7;
        pizzaSize = "Small";
    }

    protected void rbMedium_CheckedChanged(object sender, EventArgs e)
    {
        pizzaPrice = 10;
        pizzaSize = "Medium";
    }

    protected void rbLarge_CheckedChanged(object sender, EventArgs e)
    {
        pizzaPrice = 12;
        pizzaSize = "Large";
    }
}