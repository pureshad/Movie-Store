using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name"), StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime Uploaded { get; set; }

        public byte Count { get; set; }
    }
}