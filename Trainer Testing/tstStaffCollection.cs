using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;
using System.Collections.Generic;

namespace Trainer_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.Town = "Some Town";
            TestItem.Address = "123 Some Address";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6EL";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
      
        [TestMethod]
        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestStaff = new ClsStaff();
            TestStaff.Active = true;
            TestStaff.StaffNo = 1;
            TestStaff.Town = "Some Town";
            TestStaff.Address = "123 Some Address";
            TestStaff.DateAdded = DateTime.Now.Date;
            TestStaff.PostCode = "LE3 6EL";
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.Town = "Some Town";
            TestItem.Address = "123 Some Address";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6EL";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
      
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6AI";
            TestItem.Address = "123 Some Road";
            TestItem.Town = "A Town";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6AI";
            TestItem.Address = "123 Some Road";
            TestItem.Town = "A Town";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            ClsStaff TestItem = new ClsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "LE3 6AI";
            TestItem.Address = "123 Some Road";
            TestItem.Town = "A Town";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            TestItem.Active = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PostCode = "WS7 2JB";
            TestItem.Address = "123 Some Other Road";
            TestItem.Town = "Another Town";
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }
}
