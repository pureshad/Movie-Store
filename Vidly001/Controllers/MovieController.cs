using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly001.Models;

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