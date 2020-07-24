using BearerTokenAuth.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BearerTokenAuth.Models;

namespace BearerTokenAuth.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public IEnumerable<User> Gets()
        {
            return db.Users.ToList();
        }
    }
}
