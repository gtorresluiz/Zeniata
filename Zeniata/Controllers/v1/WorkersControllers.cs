using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using   Zeniata.Data;
using Zeniata.Models;

namespace Zeniata.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WorkersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/workers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Worker>>> GetAll()
        {
            var workers = await _context.Workers.ToListAsync();
            return Ok(workers);
        }

        // GET: api/v1/workers/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Worker>> GetById(int id)
        {
            var worker = await _context.Workers.FindAsync(id);
            if (worker == null)
                return NotFound(new { message = "Funcionário não encontrado." });

            return Ok(worker);
        }

        // POST: api/v1/workers
        [HttpPost]
        public async Task<ActionResult<Worker>> Create(Worker worker)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Workers.Add(worker);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = worker.Id }, worker);
        }

        // PUT: api/v1/workers/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Worker worker)
        {
            if (id != worker.Id)
                return BadRequest(new { message = "ID inconsistente." });

            _context.Entry(worker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Workers.Any(w => w.Id == id))
                    return NotFound(new { message = "Funcionário não encontrado." });

                throw;
            }
        }

        // DELETE: api/v1/workers/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var worker = await _context.Workers.FindAsync(id);
            if (worker == null)
                return NotFound(new { message = "Funcionário não encontrado." });

            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
