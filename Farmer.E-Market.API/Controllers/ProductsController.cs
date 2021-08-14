using Farmer.Core.Data;
using Farmer.Core.DTO;
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
    public class ProductsController : Controller
    {
        private readonly IProductsService ProductsService;
        public ProductsController(IProductsService productService)
        {
            this.ProductsService = productService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Products> GetAll()
        {
            return ProductsService.GetAll();
        }
        [HttpPost]
        [ProducesResponseType(typeof(Products), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Products Create([FromBody] Products products)
        {
            return ProductsService.Create(products);
        }
        [HttpPut]
        [ProducesResponseType(typeof(Products), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Products Update([FromBody] Products products)
        {
            return ProductsService.Update(products);
        }

        [HttpDelete("{id}")]
        public Products Delete(int id)
        {
            return ProductsService.Delete(id);
        }

        [HttpPost]
        [Route("ProductSearch")]
        [HttpPost]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Products> Search([FromBody] ProductsDTO productsDTO)
        {
            return ProductsService.Search(productsDTO);
        }
    }
}
