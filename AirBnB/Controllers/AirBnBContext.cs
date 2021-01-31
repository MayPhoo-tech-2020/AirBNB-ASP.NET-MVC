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
        DbSet<Customer>Customers { get; set; }
        DbSet<Host> Hosts { get; set; }
    }
}