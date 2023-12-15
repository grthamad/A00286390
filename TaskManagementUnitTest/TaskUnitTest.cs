using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManagement.Controllers;
using TaskManagementApi.Controllers;
using TaskManagementApi.Models;

namespace TaskManagementUnitTest
{
    [TestClass]
    public class TaskUnitTest
    {
        [TestMethod]
        public void GetMethod()
        {
            TaskController taskController = new TaskController();
            TaskController.Get();
        }

        [TestMethod]
        public void PostMethod()
        {
            TaskController taskController = new TaskController();
            Task task = new Task()
            {
                Title = "Test Task",
                Description = "This is the test task",
                StaffId = 1
            };
            taskController.Post(task);
        }

        [TestMethod]
        public void PutMethod()
        {
            TaskController taskController = new TaskController();
            Task task = new Task()
            {
                Title = "Test Task",
                Description = "This is the test task"
            };
            taskController.Put(1, task);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            TaskController taskController = new TaskController();
            taskController.Delete(1);
        }
    }
}
