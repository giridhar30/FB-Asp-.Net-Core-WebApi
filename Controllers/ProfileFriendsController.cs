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
    public class ProfileFriendsController : ControllerBase
    {
        private readonly FbContext _context;

        public ProfileFriendsController(FbContext context)
        {
            _context = context;
        }

        // GET: api/ProfileFriends
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfileFriend>>> GetProfileFriend()
        {
            return await _context.ProfileFriend.ToListAsync();
        }

        // GET: api/ProfileFriends/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfileFriend>> GetProfileFriend(int id)
        {
            var profileFriend = await _context.ProfileFriend.FindAsync(id);

            if (profileFriend == null)
            {
                return NotFound();
            }

            return profileFriend;
        }

        // PUT: api/ProfileFriends/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfileFriend(int id, ProfileFriend profileFriend)
        {
            if (id != profileFriend.Id)
            {
                return BadRequest();
            }

            _context.Entry(profileFriend).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfileFriendExists(id))
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

        // POST: api/ProfileFriends
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfileFriend>> PostProfileFriend(ProfileFriend profileFriend)
        {
            _context.ProfileFriend.Add(profileFriend);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfileFriend", new { id = profileFriend.Id }, profileFriend);
        }

        // DELETE: api/ProfileFriends/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfileFriend>> DeleteProfileFriend(int id)
        {
            var profileFriend = await _context.ProfileFriend.FindAsync(id);
            if (profileFriend == null)
            {
                return NotFound();
            }

            _context.ProfileFriend.Remove(profileFriend);
            await _context.SaveChangesAsync();

            return profileFriend;
        }

        private bool ProfileFriendExists(int id)
        {
            return _context.ProfileFriend.Any(e => e.Id == id);
        }
    }
}
