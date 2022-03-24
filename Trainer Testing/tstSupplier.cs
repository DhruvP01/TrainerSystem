    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;

namespace Trainer_Testing
{
    [TestClass]
    public class tstSupplier
    {
        //good test data
        //create some test data to pass to the method
        string SupplierName = "Nike";
        string SupplierID = "1";
        String DateAdded = DateTime.Now.Date.ToString();
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
            if (AnSupplier.SupplierID != "5")
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
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SuppplierNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string SupplierName = "";//this should trigger an error
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string SupplierName = "Jd";//this should be ok
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void SupplierNameMinPlusOne()
        {

            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string SupplierName = "Jds";//this should be ok
            //invoke the method 
            Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        public void SupplierNameMaxLessOne()
       (

           //create an instance of the class we want to create
           //clsSupplier AnSupplier = new clsSupplier();
           //string variable to store any error message
           String Error = "";
           //create some test data to pass the method 
           string SupplierName = "Nikes";//this should be ok
                                         //invoke the method 
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
           //test to see that the result is correct
            Assert.AreEqual(Error,"");
     }
    [TestMethod]
    public void SupplierNameMax()
    {
        //create an instance of the class we want to create 
        clsSupplier AnSupplier = new clsSupplier();
        //string  variable to store any error message
        string Error = "";
        //create some test data to pass the method
        string SupplierName = "Jordans";//this should be ok
        //invoke the methd
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct
        Assert.AreEqual(Error, "");
    }
    [TestMethod]
    public void SupplierNameMid()
    {
        //create an instance of the class we want to create 
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        string Error = "";
        //creaate some test data to pass the method
        string SupplierName = "puma";//this should be ok
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct
        Assert.Equals(Error);

    }

    [TestMethod]
    public void SupplierNameExtremeMax()
    {
        //create an instance of the class we want to create 
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        string Error = "";
        //create some test data to pass the method
        string SupplierName = ";
        SupplierName = SupplierName.PadRight(100, 'Jd');//this should fail
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct 
        Assert.AreNotEqual(Error, ");



    }
    [TestMethod]
    public void DateAddedExtremeMin()
    {
        //create an instance of the class weant to create 
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message 
        String Error = "";
        //create a variable to store test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is less than 6 years
        TestDate = TestDate.AddYears(-6);
        //convert the date variable to a string variable 
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct 
        Assert.AreNotEqual(Error, "");



    }
    [TestMethod]
    public void DateAddedMinLessOne()
    {

        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is less 1 day
        TestDate = TestDate.AddDays(-1);
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }
    [TestMethod]
    public void DateAddedMin()
    {
        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct
        Assert.AreEqual(Error, "");
    }
    [TestMethod]
    public void DateAddedMinPlusOne()
    {
        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is plus 1 day
        TestDate = TestDate.AddDays(1);
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID DateAdded);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");


    }
    [TestMethod]
    public void DateAddedxtremeMax()
    {
        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is plus 100 years
        TestDate = TestDate.AddYears(6);
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnSupplier.Valid(SupplierName, SupplierID, DateAdded);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }
    [TestMethod]
    public void SupplierIDMinLessOne()
    {

        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //this should fail
        string SupplierID = "";
        //invoke the method
        Error = AnSupplier.Valid(SupplierName,SupplierID DateAdded);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

  }
    [TestMethod]
    public void SupplierIDMax()
    {
        //create an instance of the class we want to create
        clsSupplier AnSupplier = new clsSupplier();
        //string variable to store any error message
        String Error = "";
        //this should pass
        string PostCode = "2";
        //invoke the method
        Error = AnSupplier.Valid(SupplierName,SupplierID DateAdded);
        //test to see that the result is correct
        Assert.AreEqual(Error, "");
    }