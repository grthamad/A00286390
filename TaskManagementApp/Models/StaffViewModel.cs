using TaskManagementApi.Models;

namespace TaskManagementApp.Models
{
    public class StaffViewModel
    {
        public List<Staff> Staffs = new List<Staff>();
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
    }
}
