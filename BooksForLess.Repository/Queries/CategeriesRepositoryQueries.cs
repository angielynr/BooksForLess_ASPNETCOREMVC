﻿using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Queries
{
    public partial class CategeriesRepositoryQueries : ICategoriesRepositoryQueries
    {
        private readonly AppDbContext appDbContext;

        public CategeriesRepositoryQueries(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }

        private async Task SaveChangesAsync()
        {
            await this.appDbContext.SaveChangesAsync();
        }
    }
}
