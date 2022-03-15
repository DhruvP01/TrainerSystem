using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TrainerClasses
{
    public class ClsStaff
    {
        private Int32 mStaffNo;
        public Int32 StaffNo 
        { get
               {
                return mStaffNo;
            } 
          set
            {
                mStaffNo = value;
            }
        
        
        }
        private Boolean mActive;
        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }


        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }


        }
        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }


        }
        private string mStaffAddress;
        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }


        }
        private string mTown;
        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }


        }
        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }


        }

        public bool Find(int staffNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", StaffNo);
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            if (DB.Count == 1)
            {
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
        
            else
            {
                return false;
            }

        }
    }
}