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
    public partial class CategeriesRepositoryQueries : ICategoriesRepositoryQueries
    {
        public async Task<List<Categories>> GetAllCategories()
        {
            return await appDbContext.categories.ToListAsync();
        }
    }
}
