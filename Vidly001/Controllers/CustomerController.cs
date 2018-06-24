using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly001.Models;

namespace Vidly001.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _dbContext.Customers.Include(w => w.MembershipType).ToList();

            return View(customer);
        }

        public ActionResult Details(int? id)
        {
            var customer = _dbContext.Customers.Include(w => w.MembershipType).SingleOrDefault(w => w.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}