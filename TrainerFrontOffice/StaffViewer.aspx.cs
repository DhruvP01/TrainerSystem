using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        AnStaff = (ClsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffNo);
    }
}