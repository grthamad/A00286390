using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementApi.Models;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private TaskManagementDbContext DbContext;
        public StaffController(TaskManagementDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return DbContext.Staffs.ToArray();
        }

        [HttpPost]
        public async Task<ActionResult<Staff>> Post(Staff staff)
        {
            DbContext.Staffs.Add(staff);
            await DbContext.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = staff.Id }, staff);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }

            DbContext.Entry(staff).State = EntityState.Modified;

            try
            {
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DbContext.Staffs.Any(s => s.Id == id))
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
            var staff = await DbContext.Staffs.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }

            DbContext.Staffs.Remove(staff);
            await DbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
