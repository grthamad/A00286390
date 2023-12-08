using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagement.Controllers;
using TaskManagementApi.Controllers;

namespace TaskManagementUnitTest
{
    [TestClass]
    public class StaftUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StaffController staffController = new StaffController(null);
            staffController.Get();
        }
    }
}
