using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }

    class ClsStaff
    {
    }
}
