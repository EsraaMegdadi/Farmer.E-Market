using Farmer.Core;
using Farmer.Core.DTO;
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
    public class UsersController : Controller
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

        [Route("allfarmers")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        public List<Users> GetAllFarmers()
        {
            return UserService.GetAllFarmers();
        }

        [Route("alltraders")]

        [HttpGet]

        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        public List<Users> GetAllTraders()
        {
            return UserService.GetAllTraders();
        }


        [Route("{id}")]
        [HttpGet]
        public Users getbyid(int id)
        {
            return UserService.GetById(id);
        }
        [HttpPost]
        [Route("register")]
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
        //[HttpGet]
        //[Route("GetAllCategoryProduct")]
        //[ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        //public async Task<List<Category>> GetAllCategoryProducts()
        //{
        //    return await CategoryService.GetAllCategoryProducts();
        //}

        //[HttpGet]
        //[Route("Login")]
        //[ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        //public async Task<bool> CheckUserValidity(UsersLoginDTO customer)
        //{
        //    return await UserService.CheckUserValidity(customer);
        //}

    }
}
