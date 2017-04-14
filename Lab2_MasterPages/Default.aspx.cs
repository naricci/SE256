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

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clear the TextBoxes
        txtFName.Text = "";
        txtLName.Text = "";
        txtStreet1.Text = "";
        txtStreet2.Text = "";
        txtCity.Text = "";
        txtZipCode.Text = "";
        txtHomePhone.Text = "";
        txtWorkPhone.Text = "";
        txtCellPhone.Text = "";
        txtNotes.Text = "";

        // Clear the Drop-Down Lists
        ddlState.SelectedIndex = 0;
        ddlRelationship.SelectedIndex = 0;

        // Clear the Calendars
        calBirthday.SelectedDates.Clear();
        calAnniversary.SelectedDates.Clear();

        // Clear the CheckBoxes
        chkCardWorthy.Checked = false;

        // Clear Feedback Label
        lblFeedback.Text = "Feedback";

        // Clear Feedback ListBox
        lbxFeedback.Items.Clear();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Add Contact Name to Feedback Label
        lblFeedback.Text = txtFName.Text + " " + txtLName.Text;

        // Add Form Data to ListBox
        lbxFeedback.Items.Add(txtFName.Text + " " + txtLName.Text);
        lbxFeedback.Items.Add(txtStreet1.Text + " " + txtStreet2.Text);
        lbxFeedback.Items.Add(txtCity.Text + ", " + ddlState.SelectedItem.ToString() + ", " + txtZipCode.Text);
        lbxFeedback.Items.Add(calBirthday.SelectedDate.ToString());
        lbxFeedback.Items.Add(calAnniversary.SelectedDate.ToString());
        lbxFeedback.Items.Add(txtHomePhone.Text);
        lbxFeedback.Items.Add(txtWorkPhone.Text);
        lbxFeedback.Items.Add(txtCellPhone.Text);
        lbxFeedback.Items.Add(chkCardWorthy.Text.ToString());
        lbxFeedback.Items.Add(ddlRelationship.SelectedItem.ToString());
        lbxFeedback.Items.Add(txtNotes.Text);
    }
}