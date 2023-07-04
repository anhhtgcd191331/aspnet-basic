using server_website_movie.Models;

public interface IUserRepository
{
    Task<IEnumerable<UserAccount>> GetAllUserAsync();
    Task AddNewUser(UserAccount user);
    Task UpdateUser(UserAccount user);
    Task DeleteUser(UserAccount user);
    Task<UserAccount> GetUserById(int id);
}
