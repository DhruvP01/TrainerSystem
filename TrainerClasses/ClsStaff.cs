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
            mStaffNo = 21;
            mAddress = "Test Street";
            mTown = "Test Town";
            mPostCode = "abc 123";
            mDateAdded = Convert.ToDateTime("24/09/2019");
            mActive = true;
            return true;
        }
    }
}