using System.Collections.Generic;

namespace TaskManagementApi.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
