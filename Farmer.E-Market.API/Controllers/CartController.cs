using Farmer.Core.Data;
using Farmer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmer.E_Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService CartService;
        public CartController(ICartService cartService)
        {
            CartService = cartService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Cart>), StatusCodes.Status200OK)]
        public List<Cart> GetAll()
        {
            return CartService.GetAll();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Cart Create([FromBody] Cart cart)
        {
            return CartService.Create(cart);
        }



        [HttpPut]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status400BadRequest)]

        public Cart Update([FromBody] Cart cart)
        {
            return CartService.Update(cart);
        }


        [HttpDelete("{id}")]
        public Cart Delete(int id)
        {
            return CartService.Delete(id);
        }

    }
}
