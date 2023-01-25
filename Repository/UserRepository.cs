using users.Models;
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
    public void AddUser(User user)
    {
      _context.Add(user);
    }

    public void DeleteUser(User user)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllUsers()
    {
      throw new NotImplementedException();
    }

    public Task<User> GetUser(int id)
    {
      throw new NotImplementedException();
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