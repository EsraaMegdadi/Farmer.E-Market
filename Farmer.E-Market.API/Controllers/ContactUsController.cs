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
    public class ContactUsController : Controller
    {
       
            private readonly IContactUsService ContactUsService;
            public ContactUsController(IContactUsService contactUsService)
            {
                ContactUsService = contactUsService;
            }
            [HttpGet]
            [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
            public List<ContactUs> GetAll()
            {
                return ContactUsService.GetAll();
            }

        [Route("{ContactUsId}")]
        [HttpGet]
        public ContactUs getbyid(int ContactUsId)
        {
            return ContactUsService.getbyid(ContactUsId);
        }






        [HttpPost]
            [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]

            public ContactUs Create([FromBody] ContactUs contactUs)
            {
                return ContactUsService.Create(contactUs);
            }



            [HttpPut]
            [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
            [ProducesResponseType(typeof(ContactUs), StatusCodes.Status400BadRequest)]

            public ContactUs Update([FromBody] ContactUs contactUs)
            {
                return ContactUsService.Update(contactUs);
            }


            [HttpDelete("{id}")]
            public ContactUs Delete(int id)
            {
                return ContactUsService.Delete(id);
            }

        }
    }
