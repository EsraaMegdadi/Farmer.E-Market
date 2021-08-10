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
        [Display(Name = "InvoiceNumber")]
        [Required(ErrorMessage = "Enter InvoiceNumber")]
        public int InvoiceNumber { get; set; }

        [Display(Name = "InvoiceDate")]
        [Required(ErrorMessage = "Enter InvoiceDate")]
        public DateTime InvoiceDate { get; set; }

        [Display(Name = "TotalInvoice")]
        [Required(ErrorMessage = "Enter TotalInvoice")]
        public double TotalInvoice { get; set; }

        [Display(Name = "UserId")]
        [Required(ErrorMessage = "Enter UserId")]

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }
    }
}
