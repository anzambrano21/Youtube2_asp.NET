using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_APIS.Contex;
using web_APIS.Dto;
using web_APIS.Models;

namespace web_APIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LIkesController : ControllerBase
    {
        private readonly Contexto _context;

        public LIkesController(Contexto context)
        {
            _context = context; 
        }

        // GET: api/LIkes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LikeDto>>> GetLikes()
        {
            return await _context.Likes.Select(
                v=> new LikeDto
                {
                    ID= v.ID,
                    UsuarioID= v.UsuarioID,
                    VideoID= v.VideoID
                    
                }
                ).ToListAsync();
        }

        // GET: api/LIkes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LIkes>> GetLIkes(int id)
        {
            var lIkes = await _context.Likes.FindAsync(id);

            if (lIkes == null)
            {
                return NotFound();
            }

            return lIkes;
        }

        // PUT: api/LIkes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLIkes(int id, LIkes lIkes)
        {
            if (id != lIkes.ID)
            {
                return BadRequest();
            }

            _context.Entry(lIkes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LIkesExists(id))
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

        // POST: api/LIkes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LIkes>> PostLIkes(LIkes lIkes)
        {
            _context.Likes.Add(lIkes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLIkes", new { id = lIkes.ID }, lIkes);
        }

        // DELETE: api/LIkes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLIkes(int id)
        {
            var lIkes = await _context.Likes.FindAsync(id);
            if (lIkes == null)
            {
                return NotFound();
            }

            _context.Likes.Remove(lIkes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LIkesExists(int id)
        {
            return _context.Likes.Any(e => e.ID == id);
        }
    }
}
