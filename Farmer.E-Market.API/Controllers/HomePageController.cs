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

        [Route("{HomePageId}")]
        [HttpGet]
        public HomePage getbyid(int HomePageId)
        {
            return HomePageService.getbyid(HomePageId);
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

    }
}

