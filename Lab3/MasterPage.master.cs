﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // Kill Session Variable
        Session.Abandon();

        // Redirect back to Log In Page
        Response.Redirect("/Controls/Default.aspx");
    }
}
