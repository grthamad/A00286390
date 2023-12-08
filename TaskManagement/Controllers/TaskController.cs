using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementApi.Models;
using Task = TaskManagementApi.Models.Task;

namespace TaskManagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private TaskManagementDbContext DbContext;
        public TaskController(TaskManagementDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return DbContext.Tasks.ToArray();
        }

        [HttpPost]
        public async Task<ActionResult<Task>> Post(Task task)
        {
            DbContext.Tasks.Add(task);
            await DbContext.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Task task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            DbContext.Entry(task).State = EntityState.Modified;

            try
            {
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DbContext.Tasks.Any(s => s.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await DbContext.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            DbContext.Tasks.Remove(task);
            await DbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
