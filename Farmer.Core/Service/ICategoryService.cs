using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Service
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Create(Category category);
        Category Update(Category category);
        Category Delete(int id);
        Task<List<Category>> GetAllCategoryProducts();
    }
}
