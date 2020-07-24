using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BearerTokenAuth.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}