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
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[0]["CustomerTown"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCode"]);
                ACustomer.Telephone = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelephone"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                // add the record to the private data member
                mCustomerList.Add(ACustomer);
                // point at the next record
                Index++;
            }
        }

        // private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
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
        
        public clsCustomer ThisCustomer { get; set; }
    }
}