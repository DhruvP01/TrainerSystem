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
        public void TestMethod2()
        {
            ClsStaff AnStaff = new ClsStaff();
            Boolean TestData = true;
            AnStaff.Active = TestData;
            Assert.AreEqual(AnStaff.Active, TestData);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ClsStaff AnStaff = new ClsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateAdded = TestData;
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void TestMethod4()
        {
            ClsStaff AnStaff = new ClsStaff();
            Int32 TestData = 1;
            AnStaff.StaffNo = TestData;
            Assert.AreEqual(AnStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void TestMethod5()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "LE3 4GH";
            AnStaff.PostCode = TestData;
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }
        
        [TestMethod]
        public void TestMethod6()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "123 Working Road";
            AnStaff.Address = TestData;
            Assert.AreEqual(AnStaff.Address, TestData);
        }
        
        [TestMethod]
        public void TestMethod7()
        {
            ClsStaff AnStaff = new ClsStaff();
            string TestData = "Leicester";
            AnStaff.Town = TestData;
            Assert.AreEqual(AnStaff.Town, TestData);
        }
    }


}
