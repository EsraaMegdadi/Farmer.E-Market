using Farmer.Core.Data;
using Farmer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IProductsRepository
    {
        List<Products> GetAll();
        Products GetById(int id);
        int Create(Products Data);
        int Update(Products Data);
        int Delete(int id);
        List<Products> Search(ProductsDTO productsDTO);

        List<Products> GetAllProductSoldOut();
    }
}
