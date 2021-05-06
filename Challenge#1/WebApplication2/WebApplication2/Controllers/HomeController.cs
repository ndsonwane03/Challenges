using System.Web.Mvc;
using WebApplication2.DbRepo;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerRepository _customerRepository;
        public HomeController()
        {
            _customerRepository = new CustomerRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            var customers = _customerRepository.GetAll();
            return View(customers);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _customerRepository.Create(customer);
            return RedirectToAction("Index");
        }
    }
}
