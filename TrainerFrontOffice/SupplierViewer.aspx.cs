using System;
using TrainerClasses;
public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object 
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the supplier id for this entry
        Response.Write(AnSupplier.SupplierID);
        //display the supplier name for this entry
        Response.Write(AnSupplier.SupplierName);
        //display the supplier no for this entry
        Response.Write(AnSupplier.SupplierNo);
        // display the supplier date added for this entry
        // Response.Write(AnSupplier.DateAdded);


    }
}


























 




