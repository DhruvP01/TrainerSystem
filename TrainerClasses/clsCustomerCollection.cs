using System;
using System.Collections.Generic;

namespace TrainerClasses
{
    public class clsCustomerCollection
    {
        // private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        // constructor for the class
        public clsCustomerCollection()
        {
            // object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // populate the array list with the data table
            PopulateArrary(DB);
            
        }

       
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
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            // deletes the record pointed by thisCustomer
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            // update an existing record based on the values of thisCustomer
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CustomerName", mThisCustomer.Name);
            DB.AddParameter("@CustomerAddress", mThisCustomer.Address);
            DB.AddParameter("@CustomerTown", mThisCustomer.Town);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.PostCode);
            DB.AddParameter("@CustomerEmail", mThisCustomer.Email);
            DB.AddParameter("@CustomerTelephone", mThisCustomer.Telephone);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");

        }

        public void ReportByPostCode(string PostCode)
        {
            // filters the records based on a full or partial post code
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the postcode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            // populate the array list with the data table
            PopulateArrary(DB);
        }

        void PopulateArrary(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mCustomerList = new List<clsCustomer>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                // read in the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTown"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCode"]);
                ACustomer.Telephone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelephone"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                // add the record to the private data member
                mCustomerList.Add(ACustomer);
                // point at the next record
                Index++;
            }
        }
    }
}