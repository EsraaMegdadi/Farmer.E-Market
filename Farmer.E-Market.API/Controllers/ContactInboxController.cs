using Farmer.Core.Data;
using Farmer.Core.Service;
using Farmer.Infra.Service;
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
    public class ContactInboxController : Controller
    {
        private readonly IContactInboxService ContactInboxService;
        public ContactInboxController(IContactInboxService contactInboxService)
        {
            ContactInboxService = contactInboxService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ContactInbox>), StatusCodes.Status200OK)]
        public List<ContactInbox> GetAll()
        {
            return ContactInboxService.GetAll();
        }

        [Route("{InboxId}")]
        [HttpGet]
        public ContactInbox getbyid(int InboxId)
        {
            return ContactInboxService.getbyid(InboxId);
        }



        [HttpPost]
        [ProducesResponseType(typeof(ContactInbox), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ContactInbox Create([FromBody] ContactInbox contactInbox)
        {
            return ContactInboxService.Create(contactInbox);
        }



        [HttpPut]
        [ProducesResponseType(typeof(ContactInbox), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContactInbox), StatusCodes.Status400BadRequest)]

        public ContactInbox Update([FromBody] ContactInbox contactInbox)
        {
            return ContactInboxService.Update(contactInbox);
        }


        [HttpDelete("{id}")]
        public ContactInbox Delete(int id)
        {
            return ContactInboxService.Delete(id);
        }
    }
}
