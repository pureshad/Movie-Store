using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name"), StringLength(255), Required]
        public string Name { get; set; }

        [Required, Display(Name = "Genre")]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Upload Date")]
        public DateTime? Uploaded { get; set; }

        [Required, Range(1, 250)]
        [Display(Name = "Number in Stock")]
        public byte Count { get; set; }

        [Display(Name = "Available In Stock")]
        public byte NumberAvailable { get; set; }
    }
}