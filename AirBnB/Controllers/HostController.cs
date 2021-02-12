using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AirBnB.Models;

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
        [HttpPost]
        public ActionResult Create(Host host)
        {
            if(host.hostId==0)
                _context.Hosts.Add(host);
            else
            {
                var hostInDb = _context.Hosts.Single(c => c.hostId == host.hostId);
                hostInDb.hostName = host.hostName;
                hostInDb.hostRoomType = host.hostRoomType;
                hostInDb.price = host.price;
                hostInDb.available = host.available;
            }
            _context.SaveChanges();
            return RedirectToAction("GetHosts", "Host");
        }
        public ActionResult NewHost(int Id)
        {
            var host = _context.Hosts.SingleOrDefault(c => c.hostId == Id);
            return View(host);
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