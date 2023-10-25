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
  }
}