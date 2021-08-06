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


    }
}
