using System.Collections.Generic;

namespace Vidly001.DTOs
{
    public class RentalsDTO
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}