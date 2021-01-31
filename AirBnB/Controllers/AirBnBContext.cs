using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AirBnB.Models;

namespace AirBnB.Controllers
{
    public class AirBnBContext:DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Host> Hosts { get; set; }
    }
}