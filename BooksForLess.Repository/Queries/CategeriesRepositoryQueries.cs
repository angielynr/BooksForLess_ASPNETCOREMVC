using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BooksForLess.Repository.Queries
{
    public class CategeriesRepositoryQueries : ICategoriesRepositoryQueries
    {
        private readonly AppDbContext appDbContext;

        public CategeriesRepositoryQueries(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }
        public async Task<List<Categories>> GetAllCategories()
        {
            return await appDbContext.categories.ToListAsync();
        }
    }
}
