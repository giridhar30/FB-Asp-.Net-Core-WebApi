using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FbBackend.Data;
using FbBackend.Models;

namespace FbBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpostsController : ControllerBase
    {
        private readonly FbContext _context;

        public GpostsController(FbContext context)
        {
            _context = context;
        }

        // GET: api/Gposts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gpost>>> GetGpost()
        {
            return await _context.Gpost.ToListAsync();
        }

        // GET: api/Gposts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gpost>> GetGpost(int id)
        {
            var gpost = await _context.Gpost.FindAsync(id);

            if (gpost == null)
            {
                return NotFound();
            }

            return gpost;
        }

        // PUT: api/Gposts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGpost(int id, Gpost gpost)
        {
            if (id != gpost.Id)
            {
                return BadRequest();
            }

            _context.Entry(gpost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GpostExists(id))
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

        // POST: api/Gposts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Gpost>> PostGpost(Gpost gpost)
        {
            _context.Gpost.Add(gpost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGpost", new { id = gpost.Id }, gpost);
        }

        // DELETE: api/Gposts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gpost>> DeleteGpost(int id)
        {
            var gpost = await _context.Gpost.FindAsync(id);
            if (gpost == null)
            {
                return NotFound();
            }

            _context.Gpost.Remove(gpost);
            await _context.SaveChangesAsync();

            return gpost;
        }

        private bool GpostExists(int id)
        {
            return _context.Gpost.Any(e => e.Id == id);
        }
    }
}
