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
    public class AdminAdminsController : ControllerBase
    {
        private readonly EMIASContext _context;

        public AdminAdminsController(EMIASContext context)
        {
            _context = context;
        }

        // GET: api/AdminAdmins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminAdmin>>> GetAdminAdmins()
        {
          if (_context.AdminAdmins == null)
          {
              return NotFound();
          }
            return await _context.AdminAdmins.ToListAsync();
        }

        // GET: api/AdminAdmins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminAdmin>> GetAdminAdmin(int id)
        {
          if (_context.AdminAdmins == null)
          {
              return NotFound();
          }
            var adminAdmin = await _context.AdminAdmins.FindAsync(id);

            if (adminAdmin == null)
            {
                return NotFound();
            }

            return adminAdmin;
        }

        // PUT: api/AdminAdmins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminAdmin(int id, AdminAdmin adminAdmin)
        {
            if (id != adminAdmin.IdAdmin)
            {
                return BadRequest();
            }

            _context.Entry(adminAdmin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminAdminExists(id))
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

        // POST: api/AdminAdmins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdminAdmin>> PostAdminAdmin(AdminAdmin adminAdmin)
        {
          if (_context.AdminAdmins == null)
          {
              return Problem("Entity set 'EMIASContext.AdminAdmins'  is null.");
          }
            _context.AdminAdmins.Add(adminAdmin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminAdmin", new { id = adminAdmin.IdAdmin }, adminAdmin);
        }

        // DELETE: api/AdminAdmins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminAdmin(int id)
        {
            if (_context.AdminAdmins == null)
            {
                return NotFound();
            }
            var adminAdmin = await _context.AdminAdmins.FindAsync(id);
            if (adminAdmin == null)
            {
                return NotFound();
            }

            _context.AdminAdmins.Remove(adminAdmin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminAdminExists(int id)
        {
            return (_context.AdminAdmins?.Any(e => e.IdAdmin == id)).GetValueOrDefault();
        }
    }
}
