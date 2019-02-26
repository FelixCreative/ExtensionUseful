using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpplusCoreMVC.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCountry { get; set; }
    }
}
