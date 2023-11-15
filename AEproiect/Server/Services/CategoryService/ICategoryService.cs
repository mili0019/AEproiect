using AEproiect.Shared;
using Microsoft.AspNetCore.Mvc;

namespace AEproiect.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
