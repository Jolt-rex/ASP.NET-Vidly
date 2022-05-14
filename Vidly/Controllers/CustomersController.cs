using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Kevin Barrel" },
                new Customer { Id = 2, Name = "Hannah Banana" }
            };


            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = new Customer { Id = id, Name = "Kevin Barrel" };

            return View(customer);
        }
    }
}
