﻿using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryCommands
    {
        Task<CategoriesResponse> AddCategory(Categories categories);

        Task<CategoriesResponse> UpdateCategory(Categories categories);
        Task<CategoriesResponse> DeleteCategoryById(int id);

    }
}
