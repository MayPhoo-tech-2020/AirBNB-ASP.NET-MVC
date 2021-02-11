using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirBnB.Models;

namespace AirBnB.Controllers
{
    public class CustomerController : Controller
    {
        private AirBnBContext _context;
        public CustomerController()
        {
            _context = new AirBnBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult NewCustomer()
        {
            return View();
        }
        // GET: Customer
        public ActionResult GetCustomers()
        {
            var customers = _context.Customers;
            return View("Customers",customers);
        }

        public ActionResult GetDetails(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.customerId == id);
            if (customer == null)
                return HttpNotFound();
            return View("Details",customer);
        }
    }
}