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
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService CreditCardService;
        public CreditCardController(ICreditCardService creditCardService)
        {
            CreditCardService = creditCardService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        public List<CreditCard> GetAll()
        {
            return CreditCardService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public CreditCard getbyid(int id)
        {
            return CreditCardService.GetById(id);
        }




        [HttpPost]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public CreditCard Create([FromBody] CreditCard creditCard)
        {
            return CreditCardService.Create(creditCard);
        }



        [HttpPut]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status400BadRequest)]

        public CreditCard Update([FromBody] CreditCard creditCard)
        {
            return CreditCardService.Update(creditCard);
        }


        [HttpDelete("{id}")]
        public CreditCard Delete(int id)
        {
            return CreditCardService.Delete(id);
        }
    }
}
