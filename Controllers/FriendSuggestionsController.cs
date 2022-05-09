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
    public class FriendSuggestionsController : ControllerBase
    {
        private readonly FbContext _context;

        public FriendSuggestionsController(FbContext context)
        {
            _context = context;
        }

        // GET: api/FriendSuggestions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FriendSuggestion>>> GetFriendSuggestion()
        {
            return await _context.FriendSuggestion.ToListAsync();
        }

        // GET: api/FriendSuggestions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FriendSuggestion>> GetFriendSuggestion(int id)
        {
            var friendSuggestion = await _context.FriendSuggestion.FindAsync(id);

            if (friendSuggestion == null)
            {
                return NotFound();
            }

            return friendSuggestion;
        }

        // PUT: api/FriendSuggestions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFriendSuggestion(int id, FriendSuggestion friendSuggestion)
        {
            if (id != friendSuggestion.Id)
            {
                return BadRequest();
            }

            _context.Entry(friendSuggestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FriendSuggestionExists(id))
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

        // POST: api/FriendSuggestions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FriendSuggestion>> PostFriendSuggestion(FriendSuggestion friendSuggestion)
        {
            _context.FriendSuggestion.Add(friendSuggestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFriendSuggestion", new { id = friendSuggestion.Id }, friendSuggestion);
        }

        // DELETE: api/FriendSuggestions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FriendSuggestion>> DeleteFriendSuggestion(int id)
        {
            var friendSuggestion = await _context.FriendSuggestion.FindAsync(id);
            if (friendSuggestion == null)
            {
                return NotFound();
            }

            _context.FriendSuggestion.Remove(friendSuggestion);
            await _context.SaveChangesAsync();

            return friendSuggestion;
        }

        private bool FriendSuggestionExists(int id)
        {
            return _context.FriendSuggestion.Any(e => e.Id == id);
        }
    }
}
