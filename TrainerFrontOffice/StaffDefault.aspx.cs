using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class StaffDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (IsPostBack == false)
        {
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        TrainerClasses.clsStaffCollection Staff = new TrainerClasses.clsStaffCollection();
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "StaffNo";
        lstStaff.DataTextField = "PostCode";
        lstStaff.DataBind();
    }

}
