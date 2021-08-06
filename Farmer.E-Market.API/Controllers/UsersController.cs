﻿using Farmer.Core;
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
    public class UsersController : ControllerBase
    {
        private readonly IUserService UserService;
        public UsersController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        public List<Users> GetAll()
        {
            return UserService.GetAll();
        }

        [HttpPost]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Users Create([FromBody] Users users)
        {
            return UserService.Create(users);
        }



        [HttpPut]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Users), StatusCodes.Status400BadRequest)]

        public Users Update([FromBody] Users users)
        {
            return UserService.Update(users);
        }


        [HttpDelete("{id}")]
        public Users Delete(int id)
        {
            return UserService.Delete(id);
        }

    }
}
