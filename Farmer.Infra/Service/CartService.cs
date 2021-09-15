using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository CartRepository;
        public CartService(ICartRepository cartRepository)
        {
            CartRepository = cartRepository;

        }
        public List<Cart> GetAll()
        {
            return CartRepository.GetAll();
        }

        public Cart GetById(int id)
        {
            return CartRepository.GetById(id);
        }
        public Cart Create(Cart cart)
        {
            CartRepository.Create(cart);
            return new Cart();
        }
        public Cart order1(Cart cart)
        {
            CartRepository.order1(cart);
            return new Cart();
        }

        public List<Cart> payment()
        {
            return CartRepository.payment();
        }

        public Cart Update(Cart cart)
        {
            CartRepository.Update(cart);
            return new Cart();
        }

        public Cart Delete(int id)
        {
            CartRepository.Delete(id);
            return new Cart();
        }
    }
}
