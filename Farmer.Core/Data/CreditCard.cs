using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
   public class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }
        public int CreditCardNumber { get; set; }
        public int CVC { get; set; }
        public DateTime ExpMonth { get; set; }
        public DateTime ExpYear { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }

    }
}
