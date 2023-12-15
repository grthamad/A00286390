using System.Threading.Tasks;
using TaskManagementApi.Controllers;
using TaskManagementApi.Models;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementLibrary
{
    public class TaskLibrary
    {
        public List<Task> GetAll()
        {
            TaskController taskController = new TaskController();
            List<Task> tasks = taskController.Get().ToList();

            return tasks;
        }

        public async System.Threading.Tasks.Task Add(Task task)
        {
            TaskController taskController = new TaskController();
            var result = await taskController.Post(task);
        }

        public async System.Threading.Tasks.Task Update(int taskId, Task task)
        {
            task.Id = taskId;
            TaskController taskController = new TaskController();
            var result = await taskController.Put(taskId, task);
        }

        public async System.Threading.Tasks.Task Delete(int taskId)
        {
            TaskController taskController = new TaskController();
            var result = await taskController.Delete(taskId);
        }
    }
}
