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

    protected void btn1_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn1.Text;
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn2.Text;
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn3.Text;
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn4.Text;
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn5.Text;
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn6.Text;
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn7.Text;
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn8.Text;
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn9.Text;
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn0.Text;
    }

    protected void btnPlus_Click(object sender, EventArgs e)
    {
        // Assign value to num1
        // lblNum1.Text = txtLCD.Text;  // Hidden Label Method
        Session["num1"] = txtLCD.Text;
        
        // Clear TextBox
        txtLCD.Text = "";

        // Store operator in label
        // lblOperator.Text = "+";  // Hidden Label Method
        Session["operator"] = "+";
    }

    protected void btnEquals_Click(object sender, EventArgs e)
    {
        // Store the num2
        // lblNum2.Text = txtLCD.Text; // Hidden Label Method
        Session["num2"] = txtLCD.Text;

        // Clear LCD again
        txtLCD.Text = "";

        // Calculate the sum of two numbers
        double num1, num2, answer = 0;

        // Convert numbs from string to double
        num1 = double.Parse(Session["num1"].ToString());
        num2 = double.Parse(Session["num2"].ToString());

        if (Session["operator"].ToString() == "+")    // lblOperator.Text == "+"
        {
            answer = num1 + num2;
        }
        else if (Session["operator"].ToString() == "-")  // lblOperator.Text == "-"
        {
            answer = num1 - num2;
        }
        else if (Session["operator"].ToString() == "*")   // lblOperator.Text == "*"
        {
            answer = num1 * num2;
        }
        else if (Session["operator"].ToString() == "/") // lblOperator.Text == "/"
        {
            answer = num1 / num2;
        }

        // Display answer in TextBox
        txtLCD.Text = answer.ToString();
    }

    protected void btnMinus_Click(object sender, EventArgs e)
    {
        // Assign value to num1
        // lblNum1.Text = txtLCD.Text;  // Hidden Label Method
        Session["num1"] = txtLCD.Text;

        // Clear TextBox
        txtLCD.Text = "";

        // Store operator in label
        // lblOperator.Text = "-";  // Hidden Label Method
        Session["operator"] = "-";
    }

    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        // Assign value to num1
        // lblNum1.Text = txtLCD.Text;  // Hidden Label Method
        Session["num1"] = txtLCD.Text;

        // Clear TextBox
        txtLCD.Text = "";

        // Store operator in label
        // lblOperator.Text = "*";  // Hidden Label Method
        Session["operator"] = "*";
    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        // Assign value to num1
        // lblNum1.Text = txtLCD.Text;  // Hidden Label Method
        Session["num1"] = txtLCD.Text;

        // Clear TextBox
        txtLCD.Text = "";

        // Store operator in label
        // lblOperator.Text = "/";  // Hidden Label Method
        Session["operator"] = "/";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {   
        // Clear TextBox
        txtLCD.Text = "";

        // Clear Labels
        // lblNum1.Text = "";
        // lblNum2.Text = "";
        // lblOperator.Text = "";
    }
}