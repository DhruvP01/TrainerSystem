using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;

namespace Trainer_Testing
{
    [TestClass]
    public class tstCustomer
    {
        // good test data
        // create some test data to pass to the method
        string CustomerName = "Harry";
        string CustomerAddress = "12 London Way";
        string CustomerTown = "London";
        string CustomerPostCode = "LD2 1AS";
        string CustomerEmail = "Harry22@googlemail.com";
        string CustomerTelephone = "07112234567";
        string DateAdded = DateTime.Now.Date.ToString();
        
         [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            // test to see that it exists 
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerName = ""; // this should trigger an error
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerName = "a"; // this should be okay
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method 
            string CustomerName = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcd"; // this should be okay
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method 
            string CustomerName = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcde"; // this should be okay
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method 
            string CustomerName = "abcdeabcdeabcdeabcdeabcde"; // this should be okay
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method 
            string CustomerName = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdea"; // this should fail
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); // this should fail
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            // create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the data to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error messages
            String Error = "";
            // set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            // invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPostCode = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPostCode = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPostCode = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPostCode = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPostCode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPostCode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPostCode = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTownMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerTown = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTownMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTown = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTown = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTown = "";
            CustomerTown = CustomerTown.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTownMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTown = "";
            CustomerTown = CustomerTown.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerTown = "";
            CustomerTown = CustomerTown.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTownMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTown = "";
            CustomerTown = CustomerTown.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTelephoneMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephone = "";
            CustomerTelephone = CustomerTelephone.PadRight(11, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTelephoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephone = "";
            CustomerTelephone = CustomerTelephone.PadRight(12, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTelephoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephone = "";
            CustomerTelephone = CustomerTelephone.PadRight(500, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerTown, CustomerPostCode, CustomerEmail, CustomerTelephone, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }


        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Harry";
            //assign the data to the property
            ACustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Address";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerPostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE5 9AB";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void CustomerTelephonePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07231567894";
            //assign the data to the property
            ACustomer.Telephone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Telephone, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Harry22@googlemail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void CustomerDateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 CustomerNo = 1;
            // invoke the method
            Found = ACustomer.Find(CustomerNo);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Address != "8 Harrow Road")
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Active != true)
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.DateAdded != Convert.ToDateTime("02/02/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Name != "Aaron")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.PostCode != "HR1 0EE")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerTelephoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Telephone != "07125678965")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Email != "aaron@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.DateOfBirth != Convert.ToDateTime("12/02/1996"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





    }
}
