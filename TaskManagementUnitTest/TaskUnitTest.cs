using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagementApi.Controllers;

namespace TaskManagementUnitTest
{
    [TestClass]
    public class TaskUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskController taskController = new TaskController(null);
            taskController.Get();
        }
    }
}
