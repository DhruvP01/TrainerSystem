using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class _Default : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayCustomers();
            lblError.Text = DisplayCustomers("") + "records in the database";
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

    // event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted
        Int32 CustomerNo;
        // if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            // store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            // redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else // if no record has been selected
        {
            // display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 CustomerNo;
        // if a record has been selected from the list
        if(lstCustomers.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            // store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            // redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        else // if no record has been selected
        {
            // display and error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    // function use to populate the list box
    Int32 DisplayCustomers(string PostCodeFilter)
    {
        //declare the varibales 
        Int32 CustomerNo;
        string CustomerName;
        string CustomerAddress;
        string CustomerPostCode;

        //create a new instance of the clsAddress
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ReportByPostCode(PostCodeFilter);
        //var to store the count of records
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = CustomerBook.Count; //get the count of records from the tblcustomer table
        lstCustomers.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            CustomerNo = CustomerBook.CustomerList[Index].CustomerNo; // get the customer no
            CustomerName = CustomerBook.CustomerList[Index].Name; //get the customer name
            CustomerAddress = CustomerBook.CustomerList[Index].Address; //get the address
            CustomerPostCode = CustomerBook.CustomerList[Index].PostCode; //get the postcode

            //create the new enetry for the list box
            ListItem NewEntry = new ListItem(CustomerName + " " + CustomerAddress + " " + CustomerPostCode, CustomerNo.ToString());
            lstCustomers.Items.Add(NewEntry); //add customer to the list
            Index++; //move the index to the next record
        }
        return RecordCount; //return the count of records found 
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count 
        Int32 RecordCount;
        //assign the results of the DisplayCustomerss function to the record count var
        RecordCount = DisplayCustomers(txtEnterPostcode.Text);
        //display the number of record found 
        lblError.Text = RecordCount + "records found";

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtEnterPostcode.Text = "";

    }
}