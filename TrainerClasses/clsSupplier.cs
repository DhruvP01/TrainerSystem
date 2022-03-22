using System;

namespace TrainerClasses
{
    public class clsSupplier
    {
        //private data member for active
        private Boolean mActive;
        //public property for active
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
        //dateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property 
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
        //supplierNo private member variable 
        private Int32 mSupplierNo;
        //SupplierNo public property
        public Int32 SupplierNo
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierNo;
            }
            set
            {
                //this line of code allows data into the property 
                mSupplierNo = value;
            }
        }
        //private data member for suppliername
        private string mSupplierName;
        //public data member for suppliername
        public string SupplierName
        {
            get
            {
                //return the private data
                return mSupplierName;
            }
            set
            {
                //set the private data
                mSupplierName = value;
            }
        }
        //private data member for supplierid
        private string mSupplierID;
        //public data member for supplierid
        public string SupplierID
        {
            get
            {
                //return the private data
                return mSupplierID;
            }
            set
            {
                //set the private data
                mSupplierID = value;
            }
        }

        public bool Find(int SupplierNo)
        {
            //create am instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier no to search for 
            DB.AddParameter("@SupplierNo", SupplierNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierID = Convert.ToString(DB.DataTable.Rows[0]["SupplierID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            }
    }
}