using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TaskManagementApi.Models
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
        : base(options)
        {
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
