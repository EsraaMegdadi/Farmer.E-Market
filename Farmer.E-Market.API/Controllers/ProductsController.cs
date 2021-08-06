﻿using Farmer.Core.Data;
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
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Products Create([FromBody] Products products)
        {
            return ProductsService.Create(products);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Products Update([FromBody] Products product)
        {
            return ProductsService.Update(product);
        }

        [HttpDelete("{id}")]
        public Products Delete(int id)
        {
            return ProductsService.Delete(id);
        }
    }
}