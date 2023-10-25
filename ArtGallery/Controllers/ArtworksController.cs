using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArtGallery.Models;

namespace ArtGallery.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ArtworksController : ControllerBase
  {
    private readonly ArtGalleryContext _db;

    public ArtworksController(ArtGalleryContext db)
    {
      _db = db;
    }

    // GET api/artworks
    [HttpGet]
    public async Task<List<Artwork>> Get(string title, string artist, int year)
    {
      IQueryable<Artwork> query = _db.Artworks.AsQueryable();

      if (title != null)
      {
        query = query.Where(entry => entry.Title == title);
      }

      if (artist != null)
      {
        query = query.Where(entry => entry.Artist == artist);
      }

      if (year >= 1800)
      {
        query = query.Where(entry => entry.Year >= year);
      }

      return await query.ToListAsync();
    }

    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Artwork>> GetArtwork(int id)
    {
      Artwork artwork = await _db.Artworks.FindAsync(id);

      if (artwork == null)
      {
        return NotFound();
      }

      return artwork;
    }

    [HttpPost]
    public async Task<ActionResult<Artwork>> Post(Artwork artwork)
    {
      _db.Artworks.Add(artwork);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetArtwork), new { id = artwork.Id }, artwork);
    }

    // PUT: api/Animals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Artwork artwork)
    {
      if (id != artwork.Id)
      {
        return BadRequest();
      }

      _db.Artworks.Update(artwork);

      try
      {
        await _db.SaveChangesAsync();
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

    private bool ArtworkExists(int id)
    {
      return _db.Artworks.Any(e => e.Id == id);
    }
  }
}
