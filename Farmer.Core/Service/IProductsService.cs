using Farmer.Core.Data;
using Farmer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface IProductsService
    {
        List<Products> GetAll();
        Products getbyid(int ProductsID);
        Products Create(Products products);
        Products Update(Products products);
        Products Delete(int id);
        List<Products> Search(ProductsDTO productsDTO);
        List<Products> GetAllProductSoldOut();
    }
}
