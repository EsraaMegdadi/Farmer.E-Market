using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
   public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double TotalInvoice { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }
    }
}
