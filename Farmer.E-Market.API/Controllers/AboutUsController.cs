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
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService AboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            AboutUsService = aboutUsService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        public List<AboutUs> GetAll()
        {
            return AboutUsService.GetAll();
        }
        [HttpPost]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public AboutUs Create([FromBody] AboutUs aboutUs)
        {
            return AboutUsService.Create(aboutUs);
        }



        [HttpPut]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status400BadRequest)]

        public AboutUs Update([FromBody] AboutUs aboutUs)
        {
            return AboutUsService.Update(aboutUs);
        }


        [HttpDelete("{id}")]
        public AboutUs Delete(int id)
        {
            return AboutUsService.Delete(id);
        }






    }
}
