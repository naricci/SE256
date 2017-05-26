using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderForm : System.Web.UI.Page
{
    double pizzaPrice, toppingPrice;
    string pizzaTopping;
    //string pizzaSize;
    RadioButton pizzaSize = new RadioButton();

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

        string strOrd_ID = "";
        int intOrd_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Ord_ID"] != null)
        {
            // if this is an update, hide submit button
            btnSubmit.Visible = false;

            //If so...Gather Person's ID and Fill Form
            strOrd_ID = Request.QueryString["Ord_ID"].ToString();
            lblOrder_ID.Text = strOrd_ID;

            intOrd_ID = Convert.ToInt32(strOrd_ID);

            //Fill the "temp" order's info based on ID
            PizzaOrders temp = new PizzaOrders();
            SqlDataReader dr = temp.FindOneOrder(intOrd_ID);
            
            while (dr.Read())
            {
                string pSize = dr["PizzaSize"].ToString();
                if (pSize == "Small")
                {
                    rbSmall.Checked = true;
                }
                else if (pSize == "Medium")
                {
                    rbMedium.Checked = true;
                }
                else if (pSize == "Large")
                {
                    rbLarge.Checked = true;
                }
                pizzaSize.Text = dr["PizzaSize"].ToString();

                string pTopping = dr["Toppings"].ToString();
                if (pTopping.Contains("Pepperoni"))
                {
                    chkPepperoni.Checked = true;
                }
                if (pTopping.Contains("Sausage"))
                {
                    chkSausage.Checked = true;
                }
                if (pTopping.Contains("Meatball"))
                {
                    chkMeatball.Checked = true;
                }
                if (pTopping.Contains("Ham"))
                {
                    chkHam.Checked = true;
                }
                if (pTopping.Contains("Peppers"))
                {
                    chkPeppers.Checked = true;
                }
                if (pTopping.Contains("Onions"))
                {
                    chkOnions.Checked = true;
                }
                if (pTopping.Contains("Olives"))
                {
                    chkOlives.Checked = true;
                }
                if (pTopping.Contains("Spinach"))
                {
                    chkSpinach.Checked = true;
                }
                if (pTopping.Contains("Pineapple"))
                {
                    chkPineapple.Checked = true;
                }
                if (pTopping.Contains("BBQ Sauce"))
                {
                    chkBBQSauce.Checked = true;
                }
                if (pTopping.Contains("Extra Cheese"))
                {
                    chkExtraCheese.Checked = true;
                }
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
                lblOrder.Text = dr["TotalCost"].ToString();
            }         
        }
        else
        {
            //Do nothing....basic add page (empty)
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Clear Order Total Label
        lblOrder.Text = "";

        bool isValid = true;

        // Check if First Name is filled in
        if (!ValidationLibrary.IsItFilledIn(txtFirstName.Text))
        {
            isValid = false;
        }

        // Check if Last Name is filled in
        if (!ValidationLibrary.IsItFilledIn(txtLastName.Text))
        {
            isValid = false;
        }

        // Check if Email Address is Valid
        if (!ValidationLibrary.IsValidEmail(txtEmail.Text))
        {
            isValid = false;
        }

        // Check if Phone Number is Valid
        if (!ValidationLibrary.IsValidPhoneNumber(txtPhone.Text))
        {
            isValid = false;
        }

        if (isValid == true && Page.IsValid)
        {
            PizzaOrders temp = new PizzaOrders();

            temp.PizzaSize = pizzaSize.Text;
            temp.Toppings = pizzaTopping;
            temp.FirstName = txtFirstName.Text;
            temp.LastName = txtLastName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = ddlCity.SelectedItem.ToString();
            temp.State = ddlState.SelectedItem.ToString();
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

                // Add Total Price to Order Label
                lblOrder.Text += (pizzaPrice + toppingPrice).ToString("c");

                // Display Order info in ListBox
                lbxOrder.Items.Add("Your Order:");
                lbxOrder.Items.Add(pizzaSize.Text + " Pizza with" + pizzaTopping);
                lbxOrder.Items.Add("Delivery Info:");
                lbxOrder.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
                lbxOrder.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
                lbxOrder.Items.Add(ddlCity.SelectedItem.Text + ", " + ddlState.SelectedItem.Text + ", " + txtZipCode.Text);
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        lblOrder.Text = "";
        pizzaPrice = 0;
        toppingPrice = 0;
        pizzaTopping = "";

        PizzaOrders temp = new PizzaOrders();

        if (rbSmall.Checked == true)
        {
            pizzaSize.Text = "Small";
            pizzaPrice = 7;
        }
        else if (rbMedium.Checked == true)
        {
            pizzaSize.Text = "Medium";
            pizzaPrice = 10;
        }
        else
        {
            pizzaSize.Text = "Large";
            pizzaPrice = 12;
        }

        if (chkPepperoni.Checked)
        {
            pizzaTopping += "Pepperoni";
            toppingPrice += .50;
        }
        if (chkSausage.Checked)
        {
            pizzaTopping += " Sausage";
            toppingPrice += .50;
        }
        if (chkMeatball.Checked)
        {
            pizzaTopping += " Meatball";
            toppingPrice += .50;
        }
        if (chkHam.Checked)
        {
            pizzaTopping += " Ham";
            toppingPrice += .50;
        }
        if (chkPeppers.Checked)
        {
            pizzaTopping += " Peppers";
            toppingPrice += .50;
        }
        if (chkOnions.Checked)
        {
            pizzaTopping += " Onions";
            toppingPrice += .50;
        }
        if (chkOlives.Checked)
        {
            pizzaTopping += " Olives";
            toppingPrice += .50;
        }
        if (chkSpinach.Checked)
        {
            pizzaTopping += " Spinach";
            toppingPrice += .50;
        }
        if (chkPineapple.Checked)
        {
            pizzaTopping += " Pineapple";
            toppingPrice += .50;
        }
        if (chkBBQSauce.Checked)
        {
            pizzaTopping += " BBQ Sauce";
            toppingPrice += .50;
        }
        if (chkExtraCheese.Checked)
        {
            pizzaTopping += " Extra Cheese";
            toppingPrice += .50;
        }
        temp.PizzaSize = pizzaSize.Text;
        temp.Toppings = pizzaTopping;
        temp.FirstName = txtFirstName.Text;
        temp.LastName = txtLastName.Text;
        temp.Street1 = txtStreet1.Text;
        temp.Street2 = txtStreet2.Text;
        temp.City = ddlCity.SelectedItem.ToString();
        temp.State = ddlState.SelectedItem.ToString();
        temp.ZipCode = txtZipCode.Text;
        temp.Phone = txtPhone.Text;
        temp.Email = txtEmail.Text;
        temp.TotalCost = pizzaPrice + toppingPrice;

        // Add Total Price to Order Label
        lblOrder.Text += (pizzaPrice + toppingPrice).ToString("c");

        // Display Order info in ListBox
        lbxOrder.Items.Add("Your Order:");
        lbxOrder.Items.Add(pizzaSize.Text + " Pizza with" + pizzaTopping);
        lbxOrder.Items.Add("Delivery Info:");
        lbxOrder.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
        lbxOrder.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
        lbxOrder.Items.Add(ddlCity.SelectedItem.Text + ", " + ddlState.SelectedItem.Text + ", " + txtZipCode.Text);

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
        //pizzaSize = "";
        pizzaTopping = "";

        // Reset Radio Buttons to first btn
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

        // Reset TextBoxes
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
        pizzaSize.Text = "Small";
    }

    protected void rbMedium_CheckedChanged(object sender, EventArgs e)
    {
        pizzaPrice = 10;
        pizzaSize.Text = "Medium";
    }

    protected void rbLarge_CheckedChanged(object sender, EventArgs e)
    {
        pizzaPrice = 12;
        pizzaSize.Text = "Large";
    }
}