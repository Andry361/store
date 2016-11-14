using Store.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Store.UI.Controllers
{
  public class UserController : ApiController
  {
    User[] users = new User[] {
       new User() { Id = Guid.NewGuid(), Name = "name1"},
       new User() { Id = Guid.NewGuid(), Name = "name2"},
       new User() { Id = Guid.NewGuid(), Name = "name3"},
       new User() { Id = Guid.NewGuid(), Name = "name4"},
       new User() { Id = Guid.NewGuid(), Name = "name5"},
     };

    public IEnumerable<User> GetUsers()
    {
      return users;
    }
  }
}
