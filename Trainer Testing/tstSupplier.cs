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
            Int32 TestData = 1;
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

    }
}
