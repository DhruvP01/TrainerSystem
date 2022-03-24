using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    void DeleteStaff1()
    {
        clsStaffCollection TrainersSystem = new clsStaffCollection();
        TrainersSystem.ThisStaff.Find(StaffNo);
        TrainersSystem.Delete();
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteStaff1();
        Response.Redirect("StaffDefault.aspx");
    }
}