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
        // ACustomer.DateOfBirth = txtDateOfBirth.Text = ACustomer.ToString("dd/mm/yyyy");
        // capture the data added
        //ACustomer.DateAdded = txtDateAdded.Text;
        // store the customer name in the session object
        Session["ACustomer"] = ACustomer;
        // redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}