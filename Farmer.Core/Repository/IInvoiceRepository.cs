﻿using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAll();
        Invoice Getbyid(int InvoiceId);
        int Create(Invoice Data);
        int Update(Invoice Data);
        int Delete(int Id);
    }
}
