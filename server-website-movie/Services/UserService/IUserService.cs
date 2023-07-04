using server_website_movie.Models;

namespace server_website_movie.Services.UserService;

public interface IUserService
{
    Task<IEnumerable<UserAccount>> GetAllUserAsync();
    Task AddNewUser(UserAccount user);
    Task UpdateUser(UserAccount user);
    Task DeleteUser(UserAccount user);
}
