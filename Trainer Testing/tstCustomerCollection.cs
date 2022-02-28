using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;
using System.Collections.Generic;

namespace Trainer_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create some test data to assign to the property
            // test data will need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            // add an item to the list
            // create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "Harry";
            TestItem.Address = "12 New Street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE4 1RE";
            TestItem.Email = "Harry2@mail.com";
            TestItem.Telephone = "02358543784";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateAdded = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            // set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.Name = "Harry";
            TestCustomer.Address = "12 New Street";
            TestCustomer.Town = "Leicester";
            TestCustomer.PostCode = "LE4 1RE";
            TestCustomer.Email = "Harry2@mail.com";
            TestCustomer.Telephone = "02358543784";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.DateAdded = DateTime.Now.Date;
            // assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            // test to see that the values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            // add an iten to the list
            // create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            // set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "Harry";
            TestItem.Address = "12 New Street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "LE4 1RE";
            TestItem.Email = "Harry2@mail.com";
            TestItem.Telephone = "02358543784";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateAdded = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // create the item of test data
            clsCustomer TestItem = new clsCustomer();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "Harry";
            TestItem.Address = "12 Harrod Street";
            TestItem.Town = "Birmingham";
            TestItem.PostCode = "BR1 1EW";
            TestItem.Email = "Harry2@mail.com";
            TestItem.Telephone = "02358543784";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateAdded = DateTime.Now.Date;
            // set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            // add the record
            PrimaryKey = AllCustomers.Add();
            // set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            // find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

      

    }
}
