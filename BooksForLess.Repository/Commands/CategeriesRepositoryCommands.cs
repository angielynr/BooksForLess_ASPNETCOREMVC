﻿using Azure;
using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Commands
{
    public partial class CategeriesRepositoryCommands : ICategoriesRepositoryCommands
    {
        private readonly AppDbContext appDbContext;

        public CategeriesRepositoryCommands(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        private async Task SaveChangesAsync()
        {
            await this.appDbContext.SaveChangesAsync();
        }
    }
}
