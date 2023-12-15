using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManagementApi.Models;
using TaskManagementApp.Models;
using TaskManagementLibrary;

namespace TaskManagementApp.Controllers
{
    public class StaffsController : Controller
    {
        public StaffsController()
        {
            
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Staff";

            StaffLibrary staffLibrary = new StaffLibrary();
            StaffViewModel staffViewModel = new StaffViewModel()
            {
                Staffs = staffLibrary.GetAll().ToList()
            };

            return View(staffViewModel);
        }

        public async Task<IActionResult> Add(StaffViewModel staffViewModel)
        {
            StaffLibrary staffLibrary = new StaffLibrary();
            Staff staff = new Staff()
            {
                Name = staffViewModel.Name,
                Designation = staffViewModel.Designation
            };
            await staffLibrary.Add(staff);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(StaffViewModel staffViewModel)
        {
            StaffLibrary staffLibrary = new StaffLibrary();

            Staff staff = new Staff()
            {
                Name = staffViewModel.Name,
                Designation = staffViewModel.Designation
            };

            await staffLibrary.Update(staffViewModel.Id, staff);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(StaffViewModel staffViewModel)
        {
            StaffLibrary staffLibrary = new StaffLibrary();

            await staffLibrary.Delete(staffViewModel.Id);

            return RedirectToAction("Index");
        }
    }
}
