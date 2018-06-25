using System.ComponentModel.DataAnnotations;

namespace Vidly001.Models.Entity
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
    }
}