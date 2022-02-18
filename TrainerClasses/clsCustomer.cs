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

        public string Valid(string customerName, string customerAddress, string customerTown, string customerPostCode, string customerEmail, string customerTelephone, string dateAdded)
        {
            // create a string variable to store the error
            String Error = "";
            // create a temporary variable to store date values
            DateTime DateTemp;
            // if CustomerName is blank
            if (customerName.Length == 0)
            {
                // record the error
                Error = Error + "The customer name may not be blank : ";
            }
            // if the customer name is greater than 50 characters
            if (customerName.Length > 50)
            {
                // record the error
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            try
            {
                // copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";

                }
            }
            catch
            {
                // record the error
                Error = Error + "The date was not a valid date : ";
            }
            // if CustomerPostCode is blank
            if (customerPostCode.Length == 0)
            {
                // record the error
                Error = Error + "The customer PostCode may not be blank : ";
            }
            // if the customer Postcode is greater than 9 characters
            if (customerPostCode.Length > 9)
            {
                // record the error
                Error = Error + "The customer PostCode must be less than 9 characters : ";
            }
            // if CustomerAddress is blank
            if (customerAddress.Length == 0)
            {
                // record the error
                Error = Error + "The customer address may not be blank : ";
            }
            // if the customer address is greater than 50 characters
            if (customerAddress.Length > 50)
            {
                // record the error
                Error = Error + "The customer address must be less than 50 characters : ";
            }
            //is the town blank
            if (customerTown.Length == 0)
            {
                //record the error
                Error = Error + "The customer town may not be blank : ";
            }
            //if the town is too long
            if (customerTown.Length > 50)
            {
                //record the error
                Error = Error + "The customer town must be less than 50 characters : ";
            }
            //is the customer email  blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The customer email may not be blank : ";
            }
            //if the customer email is too long
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The customer email must be less than 50 characters : ";
            }
           // is the customer telephone blank 
           if (customerTelephone.Length == 0)
            {
                // record the error 
                Error = Error + "The customer telephone may not be blank : ";
            }
           // if the customer telephone is too long
           if(customerTelephone.Length > 11)
            {
                // record the error
                Error = Error + "The customer telephone must be 11 characters : ";
            }



            // return any error messages
            return Error;
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