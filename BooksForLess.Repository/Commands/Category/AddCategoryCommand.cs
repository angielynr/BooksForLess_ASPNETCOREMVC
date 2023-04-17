﻿using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        public async Task<CategoriesResponse> AddCategory(Category categories)
        {
            var categoriesList = await this.appDbContext.categories.ToListAsync();
            var response = new CategoriesResponse();

            await this.appDbContext.AddAsync(categories);
            await SaveChangesAsync();

            response.ResultMessage = "Success!";

            return response;
        }
    }
}