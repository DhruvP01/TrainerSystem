using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainerClasses;

public partial class AnStaff : System.Web.UI.Page
{ Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            DisplayStaff();
            if (StaffNo != -1)
            {
                DisplayStaff();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffNo == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
        Add();
        Response.Redirect("StaffDefault.aspx");
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

     void Update()
    {
        TrainerClasses.clsStaffCollection TrainersSystem = new TrainerClasses.clsStaffCollection();
        String Error = TrainersSystem.ThisStaff.Valid(txtAddress.Text, txtDateAdded.Text, txtPostCode.Text, txtTown.Text);
        if (Error == "")
        {
            TrainersSystem.ThisStaff.Find(StaffNo);
            TrainersSystem.ThisStaff.Address = txtAddress.Text;
            TrainersSystem.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            TrainersSystem.ThisStaff.PostCode = txtPostCode.Text;
            TrainersSystem.ThisStaff.Town = txtTown.Text;
            TrainersSystem.ThisStaff.Active = chkActive.Checked;
            TrainersSystem.Update();
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }



    void Add()
    {
        TrainerClasses.clsStaffCollection TrainersSystem = new TrainerClasses.clsStaffCollection();
        String Error = TrainersSystem.ThisStaff.Valid(txtAddress.Text, txtDateAdded.Text, txtPostCode.Text, txtTown.Text);
        if (Error == "")
        {
            TrainersSystem.ThisStaff.Address = txtAddress.Text;
            TrainersSystem.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            TrainersSystem.ThisStaff.PostCode = txtPostCode.Text;
            TrainersSystem.ThisStaff.Town = txtTown.Text;
            TrainersSystem.Add();
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection TrainersSystem = new clsStaffCollection();
        TrainersSystem.ThisStaff.Find(StaffNo);
        txtAddress.Text = TrainersSystem.ThisStaff.Address;
        txtDateAdded.Text = TrainersSystem.ThisStaff.DateAdded.ToString();
        txtPostCode.Text = TrainersSystem.ThisStaff.PostCode;
        txtTown.Text = TrainersSystem.ThisStaff.PostCode;
        chkActive.Checked = TrainersSystem.ThisStaff.Active;
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        Int32 StaffNo;
        Boolean Found = false;
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        Found = AnStaff.Find(StaffNo);
        if (Found == true)
        {
            txtAddress.Text = AnStaff.Address;
            txtDateAdded.Text = AnStaff.DateAdded.ToString();
            txtPostCode.Text = AnStaff.PostCode;
            txtTown.Text = AnStaff.Town;
        }
    }
}