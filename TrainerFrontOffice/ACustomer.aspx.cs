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
        // create an instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // capture the customer name
        ACustomer.Name = txtCustomerName.Text;
        // capture the customer address
        ACustomer.Address = txtCustomerAddress.Text;
        // capture the customer postcode
        ACustomer.PostCode = txtPostcode.Text;
        // capture the customer telephone
        ACustomer.Telephone = txtCustomerTelephone.Text;
        // capture the customer email address
        ACustomer.Email = txtCustomerEmail.Text;
        // capture customer dob
        txtDOB.Text = ACustomer.DateOfBirth.ToString();
        // capture the date added
        txtDateAdded.Text = ACustomer.DateAdded.ToString();
        // store the customer name in the session object
        Session["ACustomer"] = ACustomer;
        // redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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