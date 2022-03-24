using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;
public partial class StaffDefault : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        StaffNo = Convert.ToInt32(Session["StaffNo"]);

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

    void DeleteStaff()
    {
        clsStaffCollection TrainersSystem = new clsStaffCollection();
        TrainersSystem.ThisStaff.Find(StaffNo);
        TrainersSystem.Delete();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffNo"] = -1;
        Response.Redirect("AnStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffNo;
        if(lstStaff.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("DeleteStaff.aspx");
        }
    
        else
        {
            lblError.Text = "Please Select a Record to delete from the list";
        }

    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffNo;
        if (lstStaff.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("AnStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
