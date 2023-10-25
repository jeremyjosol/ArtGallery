using Microsoft.EntityFrameworkCore;

namespace ArtGallery.Models
{
  public class ArtGalleryContext : DbContext
  {
    public DbSet<Artwork> Artworks { get; set; }

    public ArtGalleryContext(DbContextOptions<ArtGalleryContext> options) : base(options)
    {
    }
  }
}