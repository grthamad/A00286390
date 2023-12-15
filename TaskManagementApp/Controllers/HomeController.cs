using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManagementApi.Models;
using TaskManagementApp.Models;
using TaskManagementLibrary;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";

            TaskLibrary taskLibrary = new TaskLibrary();
            StaffLibrary staffLibrary = new StaffLibrary();
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Tasks = taskLibrary.GetAll().ToList(),
                Staffs = staffLibrary.GetAll().ToList()
            };

            return View(homeViewModel);
        }

        public async Task<IActionResult> Add(HomeViewModel homeViewModel)
        {
            TaskLibrary taskLibrary = new TaskLibrary();
            Task task = new Task()
            {
                StaffId = homeViewModel.StaffId,
                Title = homeViewModel.Title,
                Description = homeViewModel.Description,
                Status = homeViewModel.Status
            };
            await taskLibrary.Add(task);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(HomeViewModel homeViewModel)
        {
            TaskLibrary taskLibrary = new TaskLibrary();

            Task task = new Task()
            {
                StaffId = homeViewModel.StaffId,
                Title = homeViewModel.Title,
                Description = homeViewModel.Description,
                Status = homeViewModel.Status
            };

            await taskLibrary.Update(homeViewModel.Id, task);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(HomeViewModel homeViewModel)
        {
            TaskLibrary taskLibrary = new TaskLibrary();

            await taskLibrary.Delete(homeViewModel.Id);

            return RedirectToAction("Index");
        }
    }
}
