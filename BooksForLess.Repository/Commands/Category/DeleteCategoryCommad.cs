﻿using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        public async Task<CustomResponse> DeleteCategoryById(int id)
        {
            var response = new CustomResponse();

            var result = await this.appDbContext.categories.FirstOrDefaultAsync(c => c.Id == id);

            if (result == null)
            {
                return null;
            }

            response.ResultMessage = "Sucess!";

            appDbContext.Remove(result);
            await SaveChangesAsync();

            return response;
        }
    }
}
