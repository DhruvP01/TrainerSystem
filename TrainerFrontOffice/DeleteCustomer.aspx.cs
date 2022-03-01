using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;


public partial class DeleteCustomer : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted
    Int32 CustomerNo;
    // event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the customers to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    void DeleteCustomers()
    {
        // function to delete the selected record
        // create a new instance of the customer
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        // find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerNo);
        // delete the record
        CustomerBook.Delete();
    }

    // event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        // delete the record
        DeleteCustomers();
        // redirect back to the main page
        Response.Redirect("Default.aspx");
    }
}