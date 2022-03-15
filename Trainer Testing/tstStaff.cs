using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;

namespace Trainer_Testing
{
    [TestClass]
    public class TstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClsStaff AnStaff = new ClsStaff();
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void TestActive()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean TestData = true;
            AnStaff.Active = TestData;
            Assert.AreEqual(AnStaff.Active, TestData);
        }

        [TestMethod]
        public void TestDateAdded()
        {
            ClsStaff AnStaff = new ClsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateAdded = TestData;
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void TestStaffNo()
        {
            ClsStaff AnStaff = new ClsStaff();
            Int32 TestData = 1;
            AnStaff.StaffNo = TestData;
            Assert.AreEqual(AnStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void TestPostCode()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "LE3 4GH";
            AnStaff.PostCode = TestData;
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }

        [TestMethod]
        public void TestAddress()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "123 Working Road";
            AnStaff.Address = TestData;
            Assert.AreEqual(AnStaff.Address, TestData);
        }

        [TestMethod]
        public void TestTown()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "Leicester";
            AnStaff.Town = TestData;
            Assert.AreEqual(AnStaff.Town, TestData);
        }

        [TestMethod]
        public void TestMethod8()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            Assert.IsTrue(found);

        }

        [TestMethod]
        public void TestMethod9()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            if (AnStaff.StaffNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMethod10()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            if (AnStaff.Address != "Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestMethod11()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            if (AnStaff.Town != "Test Town")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestMethod12()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            if (AnStaff.PostCode != "abc 123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestMethod13()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            found = AnStaff.Find(StaffNo);
            if (AnStaff.DateAdded != Convert.ToDateTime("24/09/2019"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
