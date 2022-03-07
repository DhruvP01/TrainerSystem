    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;

namespace Trainer_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnSupplier.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Active, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSupplier.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.DateAdded, TestData);

        }
        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnSupplier.SupplierNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierNo, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            string TestData = "SomeSupplierName";
            //assign the data to the property 
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            string TestData = "1234a";
            //assign the data to the property 
            AnSupplier.SupplierID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //Bollean variable to store the results of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //test to see if the result is true
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean vairable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the supplier no
            if (AnSupplier.SupplierNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.DateAdded != Convert.ToDateTime("28/06/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierName != ("Nike"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.SupplierID != "1234a")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierNo);
            //check the property
            if (AnSupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
