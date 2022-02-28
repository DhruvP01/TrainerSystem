using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // event handler for the ok button
    protected void btnOk_Click(object sender, EventArgs e)
    {
        // add the new record
        Add();
        // all done so redirect to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        // create a variable to store the primary key
        Int32 CustomerNo;
        // variable to store the result of the find operation 
        Boolean Found = false;
        // get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        // find the record 
        Found = ACustomer.Find(CustomerNo);
        // if found
        if (Found == true)
        {
            // display the values of the properties in the form 
            txtCustomerName.Text = ACustomer.Name;
            txtCustomerAddress.Text = ACustomer.Address;
            txtCustomerTown.Text = ACustomer.Town;
            txtPostcode.Text = ACustomer.PostCode;
            txtCustomerTelephone.Text = ACustomer.Telephone;
            txtCustomerEmail.Text = ACustomer.Email;
            txtDOB.Text = ACustomer.DateOfBirth.ToString();
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
        }
    }

    // function for adding new records
    void Add()
    {
        // create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        // validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtCustomerName.Text, txtCustomerAddress.Text, txtCustomerTown.Text, txtPostcode.Text, txtCustomerTelephone.Text, txtCustomerEmail.Text, txtDateAdded.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            // get the data entered by the user
            CustomerBook.ThisCustomer.Name = txtCustomerName.Text;
            CustomerBook.ThisCustomer.Address = txtCustomerAddress.Text;
            CustomerBook.ThisCustomer.Town = txtCustomerTown.Text;
            CustomerBook.ThisCustomer.PostCode = txtPostcode.Text;
            CustomerBook.ThisCustomer.Telephone = txtCustomerTelephone.Text;
            CustomerBook.ThisCustomer.Email = txtCustomerEmail.Text;
            CustomerBook.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            CustomerBook.ThisCustomer.Active = CheckBoxActive.Checked;
            // add the record
            CustomerBook.Add();
        }
        else
        {
            // report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
}