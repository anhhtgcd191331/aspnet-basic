using Microsoft.EntityFrameworkCore;
using server_website_movie.Models;

namespace server_website_movie.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<UserAccount> Users { get; set; }
}
