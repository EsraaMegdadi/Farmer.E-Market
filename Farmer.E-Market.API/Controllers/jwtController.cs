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
    public class jwtController : Controller
    {
        private readonly IJwtservice jwtservice;
        public jwtController(IJwtservice jwtservice)
        {
            this.jwtservice = jwtservice;
        }


        [Route("Auth")]
        [HttpPost]
        public IActionResult auth([FromBody] login login)
        {
            var token = jwtservice.Authencate(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }

        }


    }
}
