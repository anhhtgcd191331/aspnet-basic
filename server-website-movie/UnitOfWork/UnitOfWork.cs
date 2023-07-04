using server_website_movie.DbContext;

namespace server_website_movie.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public UnitOfWork(ApplicationDbContext context)
    {
        this._context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }

    public void SaveChange()
    {
        _context.SaveChanges(); 
    }
}
