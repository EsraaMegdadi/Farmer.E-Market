using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface ICartService
    {
        List<Cart> GetAll();
        Cart GetById(int id);
        Cart Create(Cart Data);
        Cart Update(Cart Data);
        Cart Delete(int Id);
        public Cart order1(Cart cart);
        List<Cart> payment();


    }
}
