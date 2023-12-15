using TaskManagementApi.Models;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApp.Models
{
    public class HomeViewModel
    {
        public List<Task> Tasks = new List<Task>();
        public List<Staff> Staffs = new List<Staff>();
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
    }
}
