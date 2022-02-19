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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // caputure the customer name 
        string CustomerName = txtCustomerName.Text;
        // capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        // capture the customer town
        string CustomerTown = txtCustomerTown.Text;
        // capture the customer postcode
        string CustomerPostCode = txtPostcode.Text;
        // capture the customer telephone
        string CustomerTelephone = txtCustomerTelephone.Text;
        // capture the customer email 
        string CustomerEmail = txtCustomerEmail.Text;
        // capture the customer dob
        string DateOfBirth = txtDOB.Text;
        // capture the date added
        string DateAdded = txtDateAdded.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
        if (Error == "")
        {
            // capture the customer name 
            ACustomer.Name = CustomerName;
            // capture the customer address
            ACustomer.Address = CustomerAddress;
            // capture the customer town 
            ACustomer.Town = CustomerTown;
            // capture the customer postcode
            ACustomer.PostCode = CustomerPostCode;
            // capture the customer telephone
            ACustomer.Telephone = CustomerTelephone;
            // capture the customer email 
            ACustomer.Email = CustomerEmail;
            // capture the customer dob 
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            // capture the customer date added
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            // store the customer in the session object
            Session["ACustomer"] = ACustomer;
            // redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
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
            txtPostcode.Text = ACustomer.PostCode;
            txtCustomerTelephone.Text = ACustomer.Telephone;
            txtCustomerEmail.Text = ACustomer.Email;
            txtDOB.Text = ACustomer.DateOfBirth.ToString();
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
        }
    }
}