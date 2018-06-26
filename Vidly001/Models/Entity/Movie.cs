using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name"), StringLength(255)]
        public string Name { get; set; }

        [Required, Display(Name ="Genre")]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Upload Date")]
        public DateTime? Uploaded { get; set; }

        [Display(Name = "Number in Stock")]
        public byte Count { get; set; }
    }
}