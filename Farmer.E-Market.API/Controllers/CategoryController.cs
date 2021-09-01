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

    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.CategoryService = categoryService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Category> GetAll()
        {
            return CategoryService.GetAll();
        }

        [HttpGet]
        [Route("{CategoryId}")]
        public Category getbyid(int CategoryId)
        {
            return CategoryService.getbyid(CategoryId);
        }
        


        [HttpPost]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Category Create([FromBody] Category category)
        {
            return CategoryService.Create(category);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Category Update([FromBody] Category category)
        {
            return CategoryService.Update(category);
        }

        [HttpDelete("{id}")]
        public Category Delete(int id)
        {
            return CategoryService.Delete(id);
        }
        [HttpGet]
        [Route("GetAllCategoryProduct")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public async Task<List<Category>> GetAllCategoryProducts()
        {
            return await CategoryService.GetAllCategoryProducts();
        }



    }
}
