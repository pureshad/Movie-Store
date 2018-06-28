using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly001.Models.Entity;

namespace Vidly001.ViewModels
{
    public class MovieFormViewModel
    {

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movies)
        {
            Id = movies.Id;
            Name = movies.Name;
            ReleaseDate = movies.ReleaseDate;
            Count = movies.Count;
            GenreId = movies.GenreId;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Display(Name = "Movie Name"), StringLength(255), Required]
        public string Name { get; set; }


        [Required, Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required, Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public byte? Count { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}