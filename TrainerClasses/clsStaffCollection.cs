
using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsStaffCollection
    {
        List<ClsStaff> mStaffList = new List<ClsStaff>();
        public List<ClsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {

            }
        }
       
        public ClsStaff ThisStaff { get; set; }

       
        public clsStaffCollection()
        {
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.Town = "Some Town";
            TestItem.Address = "123 Some Address";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6EL";
            mStaffList.Add(TestItem);
            TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffNo = 2;
            TestItem.Town = "Some other Town";
            TestItem.Address = "123 Some other Address";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6IL";
            mStaffList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsStaff AnStaff = new ClsStaff();
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnStaff.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        
        
        }

      
    }

}