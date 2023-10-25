using System.ComponentModel.DataAnnotations;

namespace ArtGallery.Models
{
  public class Artwork
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [StringLength(20)]
    public string Description { get; set; }
    [Required]
    public string Artist { get; set; }
    [Required]
    [Range(1800, 2023, ErrorMessage = "Year must be between 1800 and 2023.")]
    public int Year { get; set; }
  }
}