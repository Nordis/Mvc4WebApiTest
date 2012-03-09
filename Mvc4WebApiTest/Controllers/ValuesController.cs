using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Mvc4WebApiTest.Models;

namespace Mvc4WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        public List<User> Users = new List<User>
                                      {
                                        new User
                                            {
                                                UserId = "User1",
                                                FullName = "Daniel Nordmark",
                                                Age = 31
                                            },
                                        new User
                                            {
                                                UserId = "User2",
                                                FullName = "Some Dude",
                                                Age = 34
                                            }
                                      };
        // GET /api/values
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // GET /api/values/5
        public User Get(int id)
        {
            return Users.First();
        }

        // POST /api/values
        public void Post(string value)
        {
        }

        // PUT /api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/values/5
        public void Delete(int id)
        {
        }
    }
}