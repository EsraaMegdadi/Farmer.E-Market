using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Core.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        int Create(Category Data);
        int Update(Category Data);
        int Delete(int Id);
        Task<List<Category>> GetAllCategoryProducts();

    }
}
