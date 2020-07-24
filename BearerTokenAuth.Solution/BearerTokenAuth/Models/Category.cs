using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BearerTokenAuth.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Decription { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}