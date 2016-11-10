using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
  public class User
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
  }
  public class UserContext : DbContext
  {
    public DbSet<User> Users { get; set; }
  }
  public class UsersDbInitializer : DropCreateDatabaseAlways<UserContext>
  {
    protected override void Seed(UserContext db)
    {
      db.Users.Add(new User { Name = "Война и мир" });
      db.Users.Add(new User { Name = "Отцы и дети" });
      db.Users.Add(new User { Name = "Чайка" });
      base.Seed(db);
    }
  }
}