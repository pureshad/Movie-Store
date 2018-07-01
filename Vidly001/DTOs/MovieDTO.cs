using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly001.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Required, Range(1, 20)]
        public byte Count { get; set; }

        public GenreDTO Genre { get; set; }
    }
}