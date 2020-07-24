using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BearerTokenAuth.Models.Context
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DatabaseContext() : base("DatabaseContext")
        {
            Database.SetInitializer(new Initializer());
        }
    }
}