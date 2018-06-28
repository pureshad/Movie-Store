using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly001.Models;
using Vidly001.Models.Entity;
using Vidly001.ViewModels;

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

        public ActionResult New()
        {
            var membershipType = _dbContext.MembershipTypes.ToList();

            var newVM = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipType
            };

            return View("CustomerForm", newVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var customerVM = new CustomerFormViewModel
                {
                    Customer = customer,
                    Genre = new Genre(),
                    MembershipTypes = _dbContext.MembershipTypes.ToList()
                };

                return View("CustomerForm", customerVM);
            }

            if (customer.Id == 0)
            {
                _dbContext.Customers.Add(customer);
            }
            else
            {
                var customerIndDb = _dbContext.Customers.Single(w => w.Id == customer.Id);
                customerIndDb.Name = customer.Name;
                customerIndDb.BirthDate = customer.BirthDate;
                customerIndDb.MembershipType = customer.MembershipType;
                customerIndDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }

            customer.MembershipType = _dbContext.MembershipTypes.SingleOrDefault(w => w.Id == customer.MembershipTypeId);

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(w => w.Id == id);

            if (customer == null)
                return HttpNotFound();

            var newVM = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _dbContext.MembershipTypes.ToList()
            };

            return View("CustomerForm", newVM);
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