using BioticApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioticApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BioticUsersController : ControllerBase
    {
        private readonly BioticDbContext _context;
        public BioticUsersController(BioticDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BioticUser>>> GetBioticUsers()
        {
            return await _context.BioticUsers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BioticUser>> GetBioticUser(int id)
        {
            var BioticUser = await _context.BioticUsers.FindAsync(id);

            if(BioticUser == null) return NotFound();

            return Ok(BioticUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBioticUser(int id, BioticUser user)
        {
            user.Id = id;

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!TheUserExists(id))
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

        [HttpPost]
        public async Task<ActionResult<BioticUser>> PostBioticUser(BioticUser user)
        {
            _context.BioticUsers.Add(user);
            await _context.SaveChangesAsync();  

            return CreatedAtAction("GetBioticUser", new { id = user.Id }, user); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BioticUser>> DeleteUser(int id)
        {
            var user = await _context.BioticUsers.FindAsync(id);
            if (user == null) return NotFound();

            _context.BioticUsers.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }


        private bool TheUserExists(int id)
        {
            return _context.BioticUsers.Any(e => e.Id == id);
        }

    }
}
