using server_website_movie.Models;
using server_website_movie.UnitOfWork;

namespace server_website_movie.Services.UserService;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unit;
    private readonly IUserRepository _repository;
    public UserService(IUnitOfWork unit, IUserRepository repository)
    {
        _unit = unit;
        _repository = repository;   
    }

    public async Task AddNewUser(UserAccount user)
    {
        await _repository.AddNewUser(user);
        _unit.SaveChange();
    }

    public Task DeleteUser(UserAccount user)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserAccount>> GetAllUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserAccount user)
    {
        throw new NotImplementedException();
    }
}
