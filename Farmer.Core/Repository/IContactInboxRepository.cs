﻿using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
    public interface IContactInboxRepository
    {
        List<ContactInbox> GetAll();
        int Create(ContactInbox Data);
        int Update(ContactInbox Data);
        int Delete(int id);
    }
}
