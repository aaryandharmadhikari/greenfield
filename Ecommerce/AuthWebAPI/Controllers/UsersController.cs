using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Membership;
using Pokolib;

namespace AuthWebAPI.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            IAuthService svc = new AuthService();
            AuthService authService = new AuthService();
            authService.SeedingUser();
            List<User> users = svc.GetAll();
            return users;


        }

        // GET api/products/5
        public User Get(int id)
        {
            IAuthService svc = new AuthService();
            AuthService user = svc.Get(id);
            return user;

        }

        // POST api/products
        public void Post([FromBody] User user)
        {
            IAuthService svc = new AuthService();
            svc.Insert(user);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] User value)
        {
            IAuthService svc = new AuthService();
            svc.Get(id);
            svc.Update(value);


        }

        // DELETE api/products/5
        public void Delete(int id)
        {
            IAuthService svc = new AuthService();
            svc.Delete(id);
        }
    }
}
