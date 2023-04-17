using BooksForLess.Repository.Entity;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.DataAccess.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
    }
}
