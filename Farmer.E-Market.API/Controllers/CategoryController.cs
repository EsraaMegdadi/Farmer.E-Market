using Farmer.Core.Data;
using Farmer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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

        [Route("{id}")]
        [HttpGet]
        public Category getbyid(int id)
        {
            return CategoryService.GetById(id);
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
        [Route("GetAllFruitCat")]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Products> GetAllFruitCat()
        {
            return CategoryService.GetAllFruitCat();
        }

        [HttpGet]
        [Route("GetAllVegetableCat")]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Products> GetAllVegetableCat()
        {
            return CategoryService.GetAllVegetableCat();
        }

        [HttpGet]
        [Route("GetAllCategoryProduct")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public async Task<List<Category>> GetAllCategoryProducts()
        {
            return await CategoryService.GetAllCategoryProducts();
        }


        [HttpPost]
        [Route("upload")]
        public Products Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string attachmentFileName = $"{Guid.NewGuid().ToString("N")}_{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                var fullPath = Path.Combine("C:\\Users\\user\\Desktop\\Day01Project\\Day01Project\\src\\assets\\" + "DBimages\\Uploaded File", attachmentFileName);
                // C:\Users\user\Desktop\Day01Project>
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Products item = new Products();
                item.ProductImg = attachmentFileName;
                return item;
            }

            catch (Exception ex)
            {
                return null;

            }

        }









    }
}
