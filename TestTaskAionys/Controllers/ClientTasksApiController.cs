using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTaskAionys.Model;

namespace TestTaskAionys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientTasksApiController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ClientTasksApiController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ClientTasksApi
        [HttpGet]
        public IEnumerable<ClientTask> GetClientTasks()
        {
            return _context.ClientTasks;
        }

        // GET: api/ClientTasksApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientTask([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientTask = await _context.ClientTasks.FindAsync(id);

            if (clientTask == null)
            {
                return NotFound();
            }

            return Ok(clientTask);
        }

        // PUT: api/ClientTasksApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientTask([FromRoute] int id, [FromBody] ClientTask clientTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientTaskExists(id))
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

        // POST: api/ClientTasksApi
        [HttpPost]
        public async Task<IActionResult> PostClientTask([FromBody] ClientTask clientTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClientTasks.Add(clientTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientTask", new { id = clientTask.Id }, clientTask);
        }

        // DELETE: api/ClientTasksApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientTask([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clientTask = await _context.ClientTasks.FindAsync(id);
            if (clientTask == null)
            {
                return NotFound();
            }

            _context.ClientTasks.Remove(clientTask);
            await _context.SaveChangesAsync();

            return Ok(clientTask);
        }

        private bool ClientTaskExists(int id)
        {
            return _context.ClientTasks.Any(e => e.Id == id);
        }
    }
}