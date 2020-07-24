using Bogus;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BearerTokenAuth.Models.Context
{
    public class Initializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var faker = new Faker("tr");
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                context.Users.Add(new User()
                {
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    UserName = faker.Name.LastName(),
                    Password = "123456",
                    Role = "user"
                });
            }

            for (int i = 0; i < 10; i++)
            {
                Category category = new Category();
                category.Name = faker.Commerce.Categories(1).ToString();
                category.Decription = faker.Lorem.Text();

                context.Categories.Add(category);
                context.SaveChanges();

                for (int j = 0; j < 50; j++)
                {
                    context.Products.Add(new Product()
                    {
                        Name = faker.Commerce.ProductName(),
                        Stock = random.Next(100, 1000),
                        UnitPrice = 1M,
                        CategoryId = category.Id,
                        Category = category
                    });
                }
            }

            context.SaveChanges();
        }
    }
}