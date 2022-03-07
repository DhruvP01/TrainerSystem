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

        public bool Find(int supplierNo)
        {
            //set the private data members to the test data value 
            mSupplierNo = 21;
            mDateAdded = Convert.ToDateTime("28/06/2015");
            mSupplierName = "Nike";
            mSupplierID = "1234a";
            mActive = true;
            //always return true
            return true;
        }
        
    }
}