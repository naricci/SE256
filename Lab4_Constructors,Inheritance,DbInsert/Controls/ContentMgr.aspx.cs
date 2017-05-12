using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ContentMgr : Page
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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create instance of Employee class called temp
        Person temp = new Person();

        // CheckBox Text Logic
        if (chkCardWorthy.Checked)
        {
            chkCardWorthy.Text = "Card Worthy";
        }
        else
        {
            chkCardWorthy.Text = "Not Card Worthy";
        }

        string birthday = calBirthday.SelectedDate.ToLongDateString();
        string anniversary = calAnniversary.SelectedDate.ToLongDateString();
        
        // Fill in from Form Data
        temp.FirstName = txtFirstName.Text;
        temp.MiddleName = txtMiddleName.Text;
        temp.LastName = txtLastName.Text;
        temp.Street1 = txtStreet1.Text;
        temp.Street2 = txtStreet2.Text;
        temp.City = txtCity.Text;
        temp.State = txtState.Text;
        temp.ZipCode = txtZipCode.Text;
        temp.Birthday = DateTime.Parse(birthday);
        temp.Anniversary = DateTime.Parse(anniversary);
        temp.HomePhone = txtHomePhone.Text;
        temp.WorkPhone = txtWorkPhone.Text;
        temp.CellPhone = txtCellPhone.Text;
        temp.Email = txtEmail.Text;
        temp.CardWorthy = chkCardWorthy.Text.ToString();
        temp.Relationship = ddlRelationship.SelectedItem.ToString();
        temp.Notes = txtNotes.Text;

        // Display errors or results in Feedback Label
        if (temp.Feedback.Contains("ERROR:"))
        {
            lblFeedback.Text = temp.Feedback;
        }
        else
        {
            // FillLabel(temp);
            lblFeedback.Text = temp.AddPerson();

            // Add Contact Name to Feedback Label
            // lblFeedback.Text = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

            /*Add Form Data to ListBox
            lbxContact.Items.Add(txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text);
            lbxContact.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
            lbxContact.Items.Add(txtCity.Text + ", " + txtState.Text + ", " + txtZipCode.Text);
            lbxContact.Items.Add(calBirthday.SelectedDate.ToString());
            lbxContact.Items.Add(calAnniversary.SelectedDate.ToString());
            lbxContact.Items.Add(txtHomePhone.Text);
            lbxContact.Items.Add(txtWorkPhone.Text);
            lbxContact.Items.Add(txtCellPhone.Text);
            lbxContact.Items.Add(txtEmail.Text);
            lbxContact.Items.Add(chkCardWorthy.Text.ToString());
            lbxContact.Items.Add(ddlRelationship.SelectedItem.ToString());
            lbxContact.Items.Add(txtNotes.Text);
            */
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the TextBoxes
        txtFirstName.Text = "";
        txtMiddleName.Text = "";
        txtLastName.Text = "";
        txtStreet1.Text = "";
        txtStreet2.Text = "";
        txtCity.Text = "";
        txtZipCode.Text = "";
        txtHomePhone.Text = "";
        txtWorkPhone.Text = "";
        txtCellPhone.Text = "";
        txtNotes.Text = "";

        // Clear the Drop-Down Lists
        ddlRelationship.SelectedIndex = 0;

        // Clear the Calendars
        calBirthday.SelectedDates.Clear();
        calAnniversary.SelectedDates.Clear();

        // Clear the CheckBoxes
        chkCardWorthy.Checked = false;

        // Clear Feedback Label
        lblFeedback.Text = "";

        // Clear Feedback ListBox
        lbxContact.Items.Clear();
    }


    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // Kill Session Variable
        Session.Abandon();

        // Redirest back to LogIn Page
        Response.Redirect("/Controls/Default.aspx");
    }
}