using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
