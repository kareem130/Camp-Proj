using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Models
{
    public class Customers
    {
        public int Cust_ID { get; set; }
        public String Cust_name { get; set; }
        public String Password { get; set; }
        public int Phone { get; set; }
        public String E_mail { get; set; }
        public int Visa_no { get; set; }
        public ICollection<Orders> OrdersList { get; set; }
        public ICollection<Products> productsList { get; set; }


    }
}
