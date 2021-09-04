using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }
        public Category getbyid(int CategoryId)
        {
            categoryRepository.Getbyid(CategoryId);
            return new Category();
        }
        public Category Create(Category category)
        {
            categoryRepository.Create(category);
            return new Category();
        }
        public Category Update(Category category)
        {
            categoryRepository.Update(category);
            return new Category();
        }
        public Category Delete(int id)
        {
            categoryRepository.Delete(id);
            return new Category();
        }

        public async Task<List<Category>> GetAllCategoryProducts()
        {
            return await categoryRepository.GetAllCategoryProducts();       
        }

      
    }
}
