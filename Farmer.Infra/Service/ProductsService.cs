using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        public List<Products> GetAll()
        {
            return productsRepository.GetAll();
        }
        public Products Create(Products products)
        {
            productsRepository.Create(products);
            return new Products();
        }
        public Products Update(Products products)
        {
            productsRepository.Update(products);
            return new Products();
        }
        public Products Delete(int id)
        {
            productsRepository.Delete(id);
            return new Products();
        }
    }
}
