using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AirBnB.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        [Display(Name ="Name")]
        public string customerName { get; set; }
        [Display(Name = "Phone Number")]
        public string customerPhNo { get; set; }
    }
}