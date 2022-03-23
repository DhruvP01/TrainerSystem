using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class AnSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier 
        clsSupplier AnSupplier = new clsSupplier();
        //capture the supplier id 
        AnSupplier.SupplierID = txtSupplierID.Text;
        //store the supplier in the session object
        Session["AnSupplier"] = AnSupplier;
        //redirect to the viewer page 
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class 
        clsSupplier AnSupplier = new clsSupplier();
        //variable to store the primary key
        Int32 SupplierNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record 
        Found = AnSupplier.Find(SupplierNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtSupplierNo.Text = AnSupplier.SupplierNo.ToString();
            txtSupplierName.Text = AnSupplier.SupplierName.ToString();
            txtSupplierID.Text = AnSupplier.SupplierID.ToString();
            txtDateAdded.Text = AnSupplier.DateAdded.ToString();

        }
    }
}
