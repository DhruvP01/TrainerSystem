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
        AnStaff.StaffNo = int.Parse(txtStaffNo.Text);
        Session["AnStaff"] = AnStaff;
        Response.Redirect("StaffViewer.aspx");

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