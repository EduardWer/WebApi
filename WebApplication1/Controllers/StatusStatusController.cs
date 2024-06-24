using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusStatusController : ControllerBase
    {
        private readonly EMIASContext _context;

        public StatusStatusController(EMIASContext context)
        {
            _context = context;
        }

        // GET: api/StatusStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusStatus>>> GetStatusStatuses()
        {
          if (_context.StatusStatuses == null)
          {
              return NotFound();
          }
            return await _context.StatusStatuses.ToListAsync();
        }

        // GET: api/StatusStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusStatus>> GetStatusStatus(int id)
        {
          if (_context.StatusStatuses == null)
          {
              return NotFound();
          }
            var statusStatus = await _context.StatusStatuses.FindAsync(id);

            if (statusStatus == null)
            {
                return NotFound();
            }

            return statusStatus;
        }

        // PUT: api/StatusStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusStatus(int id, StatusStatus statusStatus)
        {
            if (id != statusStatus.IdStatus)
            {
                return BadRequest();
            }

            _context.Entry(statusStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusStatusExists(id))
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

        // POST: api/StatusStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StatusStatus>> PostStatusStatus(StatusStatus statusStatus)
        {
          if (_context.StatusStatuses == null)
          {
              return Problem("Entity set 'EMIASContext.StatusStatuses'  is null.");
          }
            _context.StatusStatuses.Add(statusStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatusStatus", new { id = statusStatus.IdStatus }, statusStatus);
        }

        // DELETE: api/StatusStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusStatus(int id)
        {
            if (_context.StatusStatuses == null)
            {
                return NotFound();
            }
            var statusStatus = await _context.StatusStatuses.FindAsync(id);
            if (statusStatus == null)
            {
                return NotFound();
            }

            _context.StatusStatuses.Remove(statusStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatusStatusExists(int id)
        {
            return (_context.StatusStatuses?.Any(e => e.IdStatus == id)).GetValueOrDefault();
        }
    }
}
