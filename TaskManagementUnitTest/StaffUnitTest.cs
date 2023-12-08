using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagement.Controllers;
using TaskManagementApi.Controllers;
using TaskManagementApi.Models;

namespace TaskManagementUnitTest
{
    [TestClass]
    public class StaftUnitTest
    {
        [TestMethod]
        public void GetMethod()
        {
            StaffController staffController = new StaffController(null);
            staffController.Get();
        }

        [TestMethod]
        public void PostMethod()
        {
            StaffController staffController = new StaffController(null);
            Staff staff = new Staff()
            {
                Name = "Test",
                Designation = "Office Assistant"
            };
            staffController.Post(staff);
        }

        [TestMethod]
        public void PutMethod()
        {
            StaffController staffController = new StaffController(null);
            Staff staff = new Staff()
            {
                Name = "Test",
                Designation = "Office Assistant"
            };
            staffController.Put(1, staff);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            StaffController staffController = new StaffController(null);
            staffController.Delete(1);
        }
    }
}
