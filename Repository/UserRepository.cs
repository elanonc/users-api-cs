using users.Models;
using Microsoft.EntityFrameworkCore;
using users.Data;

namespace users.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
      return await _context.Users.ToListAsync();
    }

    public void AddUser(User user)
    {
      _context.Add(user);
    }

    public void DeleteUser(User user)
    {
      throw new NotImplementedException();
    }

    public async Task<User> GetUser(int id)
    {
      return await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
    }

    public void UpdateUser(User user)
    {
      throw new NotImplementedException();
    }

    public async Task<bool> SaveChangesAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}