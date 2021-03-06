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
    public class UserTransactionController : Controller
    {
        private readonly IUserTransactionService UserTransactionService;
        public UserTransactionController(IUserTransactionService userTransactionService)
        {
            UserTransactionService = userTransactionService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserTransaction>), StatusCodes.Status200OK)]
        public List<UserTransaction> GetAll()
        {
            return UserTransactionService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public UserTransaction getbyid(int id)
        {
            return UserTransactionService.GetById(id);
        }




        [HttpPost]
        [ProducesResponseType(typeof(UserTransaction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public UserTransaction Create([FromBody] UserTransaction userTransaction)
        {
            return UserTransactionService.Create(userTransaction);
        }



        [HttpPut]
        [ProducesResponseType(typeof(UserTransaction), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(UserTransaction), StatusCodes.Status400BadRequest)]

        public UserTransaction Update([FromBody] UserTransaction userTransaction)
        {
            return UserTransactionService.Update(userTransaction);
        }


        [HttpDelete("{id}")]
        public UserTransaction Delete(int id)
        {
            return UserTransactionService.Delete(id);
        }
    }
}
