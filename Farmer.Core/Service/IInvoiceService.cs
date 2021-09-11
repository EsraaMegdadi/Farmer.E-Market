using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
    public interface IInvoiceService
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        Invoice Create(Invoice Data);
        Invoice Update(Invoice Data);
        Invoice Delete(int Id);
    }
}
