using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace AirBnB.Controllers
{
    public class HostController : Controller
    {
        private AirBnBContext _context;
        public HostController()
        {
            _context = new AirBnBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult GetHosts()
        {
            var host = _context.Hosts;
            return View("Hosts", host);
        }

        public ActionResult GetHostDetails(int id)
        {
            var host = _context.Hosts.SingleOrDefault(c => c.hostId == id);
            if (host == null)
                return HttpNotFound();
            return View("Details", host);
        }
    }
}