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
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService TestimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            this.TestimonialService = testimonialService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Testimonial> GetAll()
        {
            return TestimonialService.GetAll();
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Testimonial Create([FromBody] Testimonial testimonial)
        {
            return TestimonialService.Create(testimonial);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Testimonial Update([FromBody] Testimonial testimonial)
        {
            return TestimonialService.Update(testimonial);
        }

        [HttpDelete("{id}")]
        public Testimonial Delete(int id)
        {
            return TestimonialService.Delete(id);
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
