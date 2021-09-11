using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
   public class InvoiceService: IInvoiceService
    {
        private readonly IInvoiceRepository InvoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            InvoiceRepository = invoiceRepository;

        }
        public List<Invoice> GetAll()
        {
            return InvoiceRepository.GetAll();
        }
        public Invoice GetById(int id)
        {
            return InvoiceRepository.GetById(id);
        }
        public Invoice Create(Invoice invoice)
        {
            InvoiceRepository.Create(invoice);
            return new Invoice();
        }

        public Invoice Update(Invoice invoice)
        {
            InvoiceRepository.Update(invoice);
            return new Invoice();
        }

        public Invoice Delete(int id)
        {
            InvoiceRepository.Delete(id);
            return new Invoice();
        }

    }
}
