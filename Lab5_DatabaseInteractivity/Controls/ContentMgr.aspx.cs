using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Controls_ContentMgr : Page
{
    // Variables
    string cardstatus;

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

        string strPer_ID = "";
        int intPer_ID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lblPerson_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            //Fill the "temp" person's info based on ID
            Person temp = new Person();
            SqlDataReader dr = temp.FindOnePerson(intPer_ID);

            while (dr.Read())
            {
                txtFirstName.Text = dr["FirstName"].ToString();
                txtMiddleName.Text = dr["MiddleName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZipCode.Text = dr["ZipCode"].ToString();
                calBirthday.SelectedDate = DateTime.Parse(dr["Birthday"].ToString());
                calAnniversary.SelectedDate = DateTime.Parse(dr["Anniversary"].ToString());
                txtHomePhone.Text = dr["HomePhone"].ToString();
                txtWorkPhone.Text = dr["WorkPhone"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                chkCardWorthy.Text = dr["CardWorthy"].ToString();
                ddlRelationship.SelectedValue = dr["Relationship"].ToString();
                txtNotes.Text = dr["Notes"].ToString();
            }

        }
        else
        {
            //Do nothing....basic add page (empty)
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Create instance of Employee class called temp
        Person temp = new Person();

        // CheckBox Text Logic
        if (chkCardWorthy.Checked)
        {
            //chkCardWorthy.Text = "Card Worthy";
            cardstatus = "YES";
        }
        else
        {
            //chkCardWorthy.Text = "Not Card Worthy";
            cardstatus = "NO";
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
        temp.CardWorthy = cardstatus;
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
        txtState.Text = "";
        txtZipCode.Text = "";
        txtHomePhone.Text = "";
        txtWorkPhone.Text = "";
        txtCellPhone.Text = "";
        txtEmail.Text = "";
        txtNotes.Text = "";

        // Clear the Drop-Down Lists
        ddlRelationship.SelectedIndex = 0;

        // Clear the Calendars
        calBirthday.SelectedDates.Clear();
        calAnniversary.SelectedDates.Clear();

        // Clear the CheckBoxes
        chkCardWorthy.Checked = false;

        // Clear All Labels
        lblFeedback.Text = "";
        lblPerson_ID.Text = "";

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

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // CheckBox Text Logic
        if (chkCardWorthy.Checked)
        {
            //chkCardWorthy.Text = "Card Worthy";
            cardstatus = "YES";
        }
        else
        {
            //chkCardWorthy.Text = "Not Card Worthy";
            cardstatus = "NO";
        }

        string birthday = calBirthday.SelectedDate.ToLongDateString();
        string anniversary = calAnniversary.SelectedDate.ToLongDateString();

        Person temp = new Person();
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
        temp.CardWorthy = cardstatus;
        temp.Relationship = ddlRelationship.SelectedItem.ToString();
        temp.Notes = txtNotes.Text;

        // store ID of the person being updated
        temp.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

        lblFeedback.Text = temp.UpdateAContact().ToString() + " Records Updated.";
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Person temp = new Person();

        temp.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

        lblFeedback.Text = temp.DeleteOnePerson(temp.Person_ID) + " Record Deleted.";
    }
}