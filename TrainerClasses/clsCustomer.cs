using System;

namespace TrainerClasses
{
    public class clsCustomer
    {
        // private data member for active
        private Boolean mActive;
        // public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }

        }
        // private date added data member 
        private DateTime mDateAdded;
        // public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }

        }
        // private data member for the customer no property
        private Int32 mCustomerNo;
        // customerNo public property
        public Int32 CustomerNo
        {
            get
            {
                // this line of code sends data out the property
                return mCustomerNo;
            }
            set
            {
                // this line of code allows data into the property
                mCustomerNo = value;
            }
        }
        // private data member for the customer name property
        private string mName;
        // public property for the customer name 
        public string Name
        {
            get
            {
                // this line of code sends data out the property
                return mName;
            }
            set
            {
                // this line of code allows data into the property
                mName = value;
            }
        }
        // private data member for the customer address
        private string mAddress;
        // public property for the customer address
        public string Address
        {
            get
            {
                // this line of code sends data out the property
                return mAddress;
            }
            set
            {
                // this line of code allows data into the property
                mAddress = value;
            }
        }
        // private data member for the customer postcode
        private string mPostCode;
        // public property for the customer postcode
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }

        }
        // private data member for the customer telephone
        private string mTelephone;
        // public property for the customer telephone
        public string Telephone
        {
            get
            {
                //return the private data
                return mTelephone;
            }
            set
            {
                //set the private data
                mTelephone = value;
            }
        }
        // private data member for the customer email
        private string mEmail;
        // public property for the customer email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }
        // private data member for the customer dob
        private DateTime mDateOfBirth;
        // public property for the customer dob
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }

        public bool Find(int CustomerNo)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCode"]);
                mTelephone = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelephone"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                // return that everything worked okay
                return true;
            } 
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
            
        }
    }
}