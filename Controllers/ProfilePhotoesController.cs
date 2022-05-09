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
    public class ProfilePhotoesController : ControllerBase
    {
        private readonly FbContext _context;

        public ProfilePhotoesController(FbContext context)
        {
            _context = context;
        }

        // GET: api/ProfilePhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfilePhoto>>> GetProfilePhoto()
        {
            return await _context.ProfilePhoto.ToListAsync();
        }

        // GET: api/ProfilePhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfilePhoto>> GetProfilePhoto(int id)
        {
            var profilePhoto = await _context.ProfilePhoto.FindAsync(id);

            if (profilePhoto == null)
            {
                return NotFound();
            }

            return profilePhoto;
        }

        // PUT: api/ProfilePhotoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfilePhoto(int id, ProfilePhoto profilePhoto)
        {
            if (id != profilePhoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(profilePhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfilePhotoExists(id))
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

        // POST: api/ProfilePhotoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProfilePhoto>> PostProfilePhoto(ProfilePhoto profilePhoto)
        {
            _context.ProfilePhoto.Add(profilePhoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfilePhoto", new { id = profilePhoto.Id }, profilePhoto);
        }

        // DELETE: api/ProfilePhotoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfilePhoto>> DeleteProfilePhoto(int id)
        {
            var profilePhoto = await _context.ProfilePhoto.FindAsync(id);
            if (profilePhoto == null)
            {
                return NotFound();
            }

            _context.ProfilePhoto.Remove(profilePhoto);
            await _context.SaveChangesAsync();

            return profilePhoto;
        }

        private bool ProfilePhotoExists(int id)
        {
            return _context.ProfilePhoto.Any(e => e.Id == id);
        }
    }
}
