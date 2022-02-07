using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrainerClasses;

namespace Trainer_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            // test to see that is exists
            Assert.IsNotNull(ACustomer);
        }
    }

    class clsCustomer
    {
    }
}


