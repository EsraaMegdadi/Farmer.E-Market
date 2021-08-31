using Farmer.Core.Data;
using Farmer.Core.DTO;
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
                var fullPath = Path.Combine("C:\\Users\\user\\Desktop\\Day01Project\\Day01Project\\src\\assets\\" + "images\\Uploaded File", attachmentFileName);
                // C:\Users\user\Desktop\Day01Project>
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Products item = new Products();
                item.ProductImg = attachmentFileName;
                return item;
            }

            catch(Exception ex)
            {
                return null;

            }

        }
            
          





    }

    }

