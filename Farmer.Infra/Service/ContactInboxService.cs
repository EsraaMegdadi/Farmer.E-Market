using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
  public  class ContactInboxService: IContactInboxService
    {
        private readonly IContactInboxRepository ContactInboxRepository;
        public ContactInboxService(IContactInboxRepository contactInboxRepository)
        {
            ContactInboxRepository = contactInboxRepository;

        }
        public List<ContactInbox> GetAll()
        {
            return ContactInboxRepository.GetAll();
        }
        public ContactInbox getbyid(int InboxId)
        {
            ContactInboxRepository.Getbyid(InboxId);
            return new ContactInbox();
        }
        public ContactInbox Create(ContactInbox contactInbox)
        {
            ContactInboxRepository.Create(contactInbox);
            return new ContactInbox();
        }

        public ContactInbox Update(ContactInbox contactInbox)
        {
            ContactInboxRepository.Update(contactInbox);
            return new ContactInbox();
        }

        public ContactInbox Delete(int id)
        {
            ContactInboxRepository.Delete(id);
            return new ContactInbox();
        }
    }
}
