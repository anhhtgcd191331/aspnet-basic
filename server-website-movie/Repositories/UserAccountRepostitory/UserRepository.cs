namespace server_website_movie.Repositories.UserAccount;

using Microsoft.EntityFrameworkCore;
using server_website_movie.DbContext;
using server_website_movie.Models;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    private DbSet<UserAccount> _dbSet;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet= _context.Set<UserAccount>();
    }

    public async Task AddNewUser(UserAccount user)
    {
        await _dbSet.AddAsync(user);
        //_context.SaveChanges(); 
    }

    public async Task DeleteUser(UserAccount user)
    {
        if (GetUserById(user.Id)==null)
        {
            throw new Exception("User Not Found");
        }
        _dbSet.Remove(user);
    }

    public async Task<IEnumerable<UserAccount>> GetAllUserAsync()
    {
        var list = await _dbSet.ToListAsync();
        return list;
    }

    public async Task<UserAccount> GetUserById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task UpdateUser(UserAccount user)
    { 
        _context.Users.Update(user);
    }
}
