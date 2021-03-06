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
    public class FriendListsController : ControllerBase
    {
        private readonly FbContext _context;

        public FriendListsController(FbContext context)
        {
            _context = context;
        }

        // GET: api/FriendLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FriendList>>> GetFriendList()
        {
            return await _context.FriendList.ToListAsync();
        }

        // GET: api/FriendLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FriendList>> GetFriendList(int id)
        {
            var friendList = await _context.FriendList.FindAsync(id);

            if (friendList == null)
            {
                return NotFound();
            }

            return friendList;
        }

        // PUT: api/FriendLists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFriendList(int id, FriendList friendList)
        {
            if (id != friendList.Id)
            {
                return BadRequest();
            }

            _context.Entry(friendList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FriendListExists(id))
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

        // POST: api/FriendLists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FriendList>> PostFriendList(FriendList friendList)
        {
            _context.FriendList.Add(friendList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFriendList", new { id = friendList.Id }, friendList);
        }

        // DELETE: api/FriendLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FriendList>> DeleteFriendList(int id)
        {
            var friendList = await _context.FriendList.FindAsync(id);
            if (friendList == null)
            {
                return NotFound();
            }

            _context.FriendList.Remove(friendList);
            await _context.SaveChangesAsync();

            return friendList;
        }

        private bool FriendListExists(int id)
        {
            return _context.FriendList.Any(e => e.Id == id);
        }
    }
}
