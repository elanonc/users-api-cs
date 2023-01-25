using users.Models;

namespace users.Repository
{
  public interface IUserRepository
  {
		Task<IEnumerable<User>> GetAllUsers();
		Task<User> GetUser(int id);
		void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(User user);
    Task<bool> SaveChangesAsync();
  }
}