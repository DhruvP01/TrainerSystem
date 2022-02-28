using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        // create an instance of the customer collection 
        TrainerClasses.clsCustomerCollection Customers = new TrainerClasses.clsCustomerCollection();
        // set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        // set the name of the primary key
        lstCustomers.DataValueField = "CustomerNo";
        // set the data field to display 
        lstCustomers.DataTextField = "PostCode";
        // bind the data to the list
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["CustomerNo"] = -1;
        // redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }
}