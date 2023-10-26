using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtGallery.Models
{
  public class ArtGalleryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Artwork> Artworks { get; set; }

    public ArtGalleryContext(DbContextOptions<ArtGalleryContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Artwork>()
        .HasData(
          new Artwork { Id = 1, Title = "The Physical Impossibility of Death in the Mind of Someone Living", Description = "A shark in formaldehyde", Artist = "Damien Hirst", Year = 1991 },
          new Artwork { Id = 2, Title = "Flowers", Description = "Colorful flower artwork", Artist = "Takashi Murakami", Year = 2010 },
          new Artwork { Id = 4, Title = "Tilted Arc", Description = "Large-scale steel sculpture", Artist = "Richard Serra", Year = 1981 },
          new Artwork { Id = 5, Title = "No. 14", Description = "Abstract expressionist painting", Artist = "Mark Rothko", Year = 1960 }
        );
    }
  }
}