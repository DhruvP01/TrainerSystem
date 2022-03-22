using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class AnStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        string Town = txtTown.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = AnStaff.Valid(Town, Address, PostCode, DateAdded);
        if (Error == "")
        {
            AnStaff.Town = Town;
            AnStaff.Address = Address;
            AnStaff.PostCode = PostCode;
            AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }




    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        Int32 StaffNo;
        Boolean found = false;
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        found = AnStaff.Find(StaffNo);
        if (found == true)
        {
            txtAddress.Text = AnStaff.Address;
            txtDateAdded.Text = AnStaff.DateAdded.ToString();
            txtPostCode.Text = AnStaff.PostCode;       
        }
    }
}