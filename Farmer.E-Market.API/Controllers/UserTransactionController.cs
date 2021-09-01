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

        [Route("{ TransactionsId}")]
        [HttpGet]
        public UserTransaction getbyid(int TransactionsId)
        {
            return UserTransactionService.getbyid(TransactionsId);
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
