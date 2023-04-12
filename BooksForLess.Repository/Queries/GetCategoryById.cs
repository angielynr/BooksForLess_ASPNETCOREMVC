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
       public async Task<AllCategoriesResponse> GetCategoryById(int id)
        {
            var response = new AllCategoriesResponse();
            var result = await this.appDbContext.categories.Where(c => c.Id == id).FirstOrDefaultAsync();

            response = new AllCategoriesResponse()
            {
                Name= result.Name,
                DisplayOrder = result.DisplayOrder,
                ResultMessage = "Success!"
            };

            return response;
        }
    }
}
