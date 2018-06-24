using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Movie
    {
        public byte Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        //[Required]
        //public Genre Genre { get; set; }
        //public int GenreId { get; set; }

        //public DateTime ReleaseDate { get; set; }
        //public DateTime Uploaded { get; set; }
        //public int Count { get; set; }
    }
}