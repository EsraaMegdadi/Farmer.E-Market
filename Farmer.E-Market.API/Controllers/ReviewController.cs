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
    public class ReviewController : Controller
    {
        private readonly IReviewService ReviewService;
        public ReviewController(IReviewService reviewService)
        {
            this.ReviewService = reviewService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Review> GetAll()
        {
            return ReviewService.GetAll();
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Review Create([FromBody] Review review)
        {
            return ReviewService.Create(review);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Review Update([FromBody] Review review)
        {
            return ReviewService.Update(review);
        }

        [HttpDelete("{id}")]
        public Review Delete(int id)
        {
            return ReviewService.Delete(id);
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
