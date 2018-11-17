using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Models
{
    public class Products
    {
        [Key]
        public int prod_ID { get; set; }
        public String Prod_name { get; set; }
        public String Prod_price { get; set; }
        public String Prod_desc { get; set; }
        public String Prod_image { get; set; }
        public double Discount { get; set; }
        public double Stock { get; set; }
        public int Cat_ID { get; set; }

        public Categories Categories { get; set; }
        public ICollection<Customers> CustomersList { get; set; }

    }
}
