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
    public class WatchesController : ControllerBase
    {
        private readonly FbContext _context;

        public WatchesController(FbContext context)
        {
            _context = context;
        }

        // GET: api/Watches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Watch>>> GetWatch()
        {
            return await _context.Watch.ToListAsync();
        }

        // GET: api/Watches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Watch>> GetWatch(int id)
        {
            var watch = await _context.Watch.FindAsync(id);

            if (watch == null)
            {
                return NotFound();
            }

            return watch;
        }

        // PUT: api/Watches/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWatch(int id, Watch watch)
        {
            if (id != watch.Id)
            {
                return BadRequest();
            }

            _context.Entry(watch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WatchExists(id))
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

        // POST: api/Watches
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Watch>> PostWatch(Watch watch)
        {
            _context.Watch.Add(watch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWatch", new { id = watch.Id }, watch);
        }

        // DELETE: api/Watches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Watch>> DeleteWatch(int id)
        {
            var watch = await _context.Watch.FindAsync(id);
            if (watch == null)
            {
                return NotFound();
            }

            _context.Watch.Remove(watch);
            await _context.SaveChangesAsync();

            return watch;
        }

        private bool WatchExists(int id)
        {
            return _context.Watch.Any(e => e.Id == id);
        }
    }
}
