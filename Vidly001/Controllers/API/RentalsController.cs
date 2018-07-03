using System;
using System.Linq;
using System.Web.Http;
using Vidly001.DTOs;
using Vidly001.Models;
using Vidly001.Models.Entity;

namespace Vidly001.Controllers.API
{
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public RentalsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        //POST /api/Rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalsDTO rentalsDTO)
        {
            var customer = _dbContext.Customers.Single(
                w => w.Id == rentalsDTO.CustomerId);

            var movies = _dbContext.Movies.Where(
                w => rentalsDTO.MovieIds.Contains(w.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _dbContext.Rentals.Add(rental);
            }

            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
