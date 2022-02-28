using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsCustomerCollection
    {
        // constructor for the class
        public clsCustomerCollection()
        {
            // var for the index 
            Int32 Index = 0;
            // var to store the recrod count
            Int32 RecordCount = 0;
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                // read the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTown"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCode"]);
                ACustomer.Telephone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelephone"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                // add the record to the private data member
                mCustomerList.Add(ACustomer);
                // point at the next record
                Index++;
            }
        }

        // private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        // public property for the address list
        public List<clsCustomer> CustomerList
        {
            get
            {
                // return the private data
                return mCustomerList;
            }
            set
            {
                // set the private data
                mCustomerList = value;
            }
        }
        // public property for count
        public int Count
        {
            get
            {
                // return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                // 
            }
        }
        
        // public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                // return the private data
                return mThisCustomer;
            }
            set
            {
                // set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            // adds a new record to the database based on the values of thisCustomer
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.Name);
            DB.AddParameter("@CustomerAddress", mThisCustomer.Address);
            DB.AddParameter("@CustomerTown", mThisCustomer.Town);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.PostCode);
            DB.AddParameter("@CustomerEmail", mThisCustomer.Email);
            DB.AddParameter("@CustomerTelephone", mThisCustomer.Telephone);
            DB.AddParameter("@CustomerDOB", mThisCustomer.DateOfBirth);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}