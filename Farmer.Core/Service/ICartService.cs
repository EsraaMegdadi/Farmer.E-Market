using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface ICartService
    {
        List<Cart> GetAll();
        Cart Create(Cart Data);
        Cart Update(Cart Data);
        Cart Delete(int Id);
    }
}
