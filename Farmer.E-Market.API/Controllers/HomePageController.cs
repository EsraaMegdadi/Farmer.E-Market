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
    public class HomePageController : Controller
    {
        private readonly IHomePageService HomePageService;
        public HomePageController(IHomePageService homePageService)
        {
            HomePageService = homePageService;

        }
        [HttpGet]
        [ProducesResponseType(typeof(List<HomePage>), StatusCodes.Status200OK)]
        public List<HomePage> GetAll()
        {
            return HomePageService.GetAll();
        }

        [HttpPost]
        [ProducesResponseType(typeof(HomePage), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public HomePage Create([FromBody] HomePage homePage)
        {
            return HomePageService.Create(homePage);
        }



        [HttpPut]
        [ProducesResponseType(typeof(HomePage), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HomePage), StatusCodes.Status400BadRequest)]

        public HomePage Update([FromBody] HomePage homePage)
        {
            return HomePageService.Update(homePage);
        }


        [HttpDelete("{id}")]
        public HomePage Delete(int id)
        {
            return HomePageService.Delete(id);
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

