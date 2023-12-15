using TaskManagementApi.Controllers;
using TaskManagementApi.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagementLibrary
{
    public class StaffLibrary
    {
        public List<Staff> GetAll()
        {
            StaffController staffController = new StaffController();
            List<Staff> staffs = staffController.Get().ToList();

            return staffs;
        }

        public async Task Add(Staff staff)
        {
            StaffController staffController = new StaffController();
            var result = await staffController.Post(staff);
        }

        public async Task Update(int staffId, Staff staff)
        {
            staff.Id = staffId;
            StaffController staffController = new StaffController();
            var result = await staffController.Put(staffId, staff);
        }

        public async Task Delete(int staffId)
        {
            StaffController staffController = new StaffController();
            var result = await staffController.Delete(staffId);
        }
    }
}
