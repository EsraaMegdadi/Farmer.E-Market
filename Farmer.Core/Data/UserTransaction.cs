using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
  public  class UserTransaction
    {
        [Key]
        public int TransactionsId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }

        [ForeignKey("CartId")]
        public int CartId { get; set; }

        public virtual Cart cart{ get; set; }
    }
}
