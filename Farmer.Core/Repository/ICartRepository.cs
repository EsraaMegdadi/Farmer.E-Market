using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
  public interface ICartRepository
    {
        List<Cart> GetAll();
        Cart GetById(int id);
        int Create(Cart Data);
        int Update(Cart Data);
        int Delete(int Id);
        public int order1(Cart Data);
        public List<Cart> userCart(Cart Data);

    }
}
