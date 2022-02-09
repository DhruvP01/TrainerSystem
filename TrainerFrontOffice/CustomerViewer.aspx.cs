using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        // display the customer name for this entry
        Response.Write(ACustomer.Name);
        // display the customer address for this entry
        Response.Write(ACustomer.Address);
        // display the customer postcode for this entry
        Response.Write(ACustomer.PostCode);
        // display the customer telephone for this entry
        Response.Write(ACustomer.Telephone);
        // display the customer email for this entry
        Response.Write(ACustomer.Email);
        // display the customer dob for this entry
       // Response.Write(ACustomer.DateOfBirth);
        // display the customer date added for this entry
       // Response.Write(ACustomer.DateAdded);
        

    }
}