namespace TaskManagementApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Staff Staff { get; set; }
    }
}
