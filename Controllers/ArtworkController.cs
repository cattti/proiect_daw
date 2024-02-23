using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiect_daw.Data;
using proiect_daw.Models;
using proiect_daw.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect_daw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtworkController : ControllerBase
    {
        private readonly clasaContext _context;

        public ArtworkController(clasaContext context)
        {
            _context = context;
        }

        // GET: api/Artwork
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artwork>>> GetArtworks()
        {
            return await _context.Artworks.ToListAsync();
        }

        // GET: api/Artwork/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artwork>> GetArtwork(Guid id)
        {
            var artwork = await _context.Artworks.FindAsync(id);

            if (artwork == null)
            {
                return NotFound();
            }

            return artwork;
        }

        // POST: api/Artwork
        [HttpPost]
        public async Task<ActionResult<Artwork>> PostArtwork(ArtworkDto artworkDto)
        {
            var artwork = new Artwork
            {
                Id = Guid.NewGuid(),
                Title = artworkDto.Title,
                Description = artworkDto.Description,
                ArtType = artworkDto.ArtType,
                ProjectId = artworkDto.ProjectId
            };

            _context.Artworks.Add(artwork);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArtwork), new { id = artwork.Id }, artwork);
        }

        // PUT: api/Artwork/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtwork(Guid id, ArtworkDto artworkDto)
        {
            if (id != artworkDto.Id)
            {
                return BadRequest();
            }

            var artwork = await _context.Artworks.FindAsync(id);
            if (artwork == null)
            {
                return NotFound();
            }

            artwork.Title = artworkDto.Title;
            artwork.Description = artworkDto.Description;
            artwork.ArtType = artworkDto.ArtType;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtworkExists(id))
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

        // DELETE: api/Artwork/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtwork(Guid id)
        {
            var artwork = await _context.Artworks.FindAsync(id);
            if (artwork == null)
            {
                return NotFound();
            }

            _context.Artworks.Remove(artwork);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtworkExists(Guid id)
        {
            return _context.Artworks.Any(e => e.Id == id);
        }
    }
}


