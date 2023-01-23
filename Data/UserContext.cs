using users.Models;
using Microsoft.EntityFrameworkCore;

namespace users.Data
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
  }
}