using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface IProductsService
    {
        List<Products> GetAll();
        Products Create(Products products);
        Products Update(Products products);
        Products Delete(int id);
    }
}
