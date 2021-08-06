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

    }
}
