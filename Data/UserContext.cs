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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var user = modelBuilder.Entity<User>();
      user.HasKey(x => x.Id);
      user.ToTable("tb_user");
      user.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
      user.Property(x => x.Name).HasColumnName("name").IsRequired();
      user.Property(x => x.BirthDate).HasColumnName("birth_date");
    } 
  }
}