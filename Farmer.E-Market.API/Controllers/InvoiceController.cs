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
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService InvoiceService;
        public InvoiceController(IInvoiceService invoiceService)
        {
            InvoiceService = invoiceService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Invoice>), StatusCodes.Status200OK)]
        public List<Invoice> GetAll()
        {
            return InvoiceService.GetAll();
        }

        [Route("{id}")]
        [HttpGet]
        public Invoice getbyid(int id)
        {
            return InvoiceService.GetById(id);
        }


        [HttpPost]
        [ProducesResponseType(typeof(Invoice), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Invoice Create([FromBody] Invoice invoice)
        {
            return InvoiceService.Create(invoice);
        }



        [HttpPut]
        [ProducesResponseType(typeof(Invoice), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Invoice), StatusCodes.Status400BadRequest)]

        public Invoice Update([FromBody] Invoice invoice)
        {
            return InvoiceService.Update(invoice);
        }


        [HttpDelete("{id}")]
        public Invoice Delete(int id)
        {
            return InvoiceService.Delete(id);
        }
    }
}
