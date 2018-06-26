using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly001.Models;
using Vidly001.Models.Entity;
using Vidly001.ViewModels;

namespace Vidly001.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MovieController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movies = _dbContext.Movies.Include(w => w.Genre).ToList();

            return View(movies);
        }

        public ActionResult Create()
        {
            var genres = _dbContext.Genres.ToList();

            var movieVM = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("CreateForm", movieVM);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            var movies = _dbContext.Movies.SingleOrDefault(w => w.Id == movie.Id);

            if (movie.Id == 0)
            {
                movie.Uploaded = DateTime.Now;
                _dbContext.Movies.Add(movie);
            }
            else
            {
                var movieFromDb = _dbContext.Movies.Single(w => w.Id == movie.Id);
                movieFromDb.Name = movie.Name;
                movieFromDb.ReleaseDate = movie.ReleaseDate;
                movieFromDb.GenreId = movie.GenreId;
                movieFromDb.Count = movie.Count;
            }

            movie.Genre = _dbContext.Genres.SingleOrDefault(w => w.Id == movie.GenreId);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Edit(int? id)
        {
            var movies = _dbContext.Movies.SingleOrDefault(w => w.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            var movieVM = new MovieFormViewModel
            {
                Movie = movies,
                Genres = _dbContext.Genres.ToList()
            };

            return View("CreateForm", movieVM);
        }

        public ActionResult Details(int? id)
        {
            var movie = _dbContext.Movies.Include(w => w.Genre).SingleOrDefault(w => w.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }
    }
}