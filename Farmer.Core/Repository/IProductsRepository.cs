using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface IProductsRepository
    {
        List<Products> GetAll();
        int Create(Products Data);
        int Update(Products Data);
        int Delete(int id);
    }
}
