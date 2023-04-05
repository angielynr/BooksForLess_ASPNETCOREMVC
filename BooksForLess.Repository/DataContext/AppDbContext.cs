using BooksForLess.Repository.Entity;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }

        public DbSet<Categories> categories { get; set; }
    }
}
