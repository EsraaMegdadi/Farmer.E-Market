using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface IContactInboxService
    {
        List<ContactInbox> GetAll();
        ContactInbox Create(ContactInbox contact);
        ContactInbox Update(ContactInbox contact);
        ContactInbox Delete(int id);
    }
}
