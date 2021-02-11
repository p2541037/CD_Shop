﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the FullName
        aStaff.StaffFullName = txtFullName.Text;
        // Store the name in the session object
        Session["aStaff"] = aStaff;
        // navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
        // comment random
    }
}