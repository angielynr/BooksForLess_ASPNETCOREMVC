using BooksForLess.Repository.Entity;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Repository.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                   new Category
                   {
                       Id = 1,
                       Name = "Action",
                       DisplayOrder = "1",
                   },
                new Category
                {
                    Id = 2,
                    Name = "Philosophy",
                    DisplayOrder = "2",
                },
                new Category
                {
                    Id = 3,
                    Name = "Romance",
                    DisplayOrder = "3",
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Daily Stoic",
                    Author = "Ryan Holiday",
                    Description = "rem Ipsum has been the industry's standard dummy text ever since the 150",
                    ISBN = "F0100000",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                 new Product
                 {
                     Id = 2,
                     Title = "The Power of Now",
                     Author = "Echart Tolle",
                     Description = "rem Ipsum has been the industry's standard dummy text ever since the 150",
                     ISBN = "F0200000",
                     ListPrice = 35,
                     Price = 28,
                     Price50 = 25,
                     Price100 = 20
                 },
                  new Product
                  {
                      Id = 3,
                      Title = "Run",
                      Author = "Maggie The Beagle",
                      Description = "rem Ipsum has been the industry's standard dummy text ever since the 150",
                      ISBN = "F0300000",
                      ListPrice = 40,
                      Price = 38,
                      Price50 = 35,
                      Price100 = 23
                  },
                   new Product
                   {
                       Id = 4,
                       Title = "Lover",
                       Author = "Taylor Jewel",
                       Description = "rem Ipsum has been the industry's standard dummy text ever since the 150",
                       ISBN = "F0400000",
                       ListPrice = 56,
                       Price = 54,
                       Price50 = 53,
                       Price100 = 50
                   });
        }
    }
}
