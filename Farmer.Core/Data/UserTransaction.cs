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

        [Display(Name = "TransactionDate")]
        [Required(ErrorMessage = "Enter TransactionDate")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Enter Amount")]
        public double Amount { get; set; }

        [Display(Name = "UserId")]
        [Required(ErrorMessage = "Enter UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }

        [Display(Name = "CartId")]
        [Required(ErrorMessage = "Enter CartId")]
        [ForeignKey("CartId")]
        public int CartId { get; set; }

        public virtual Cart cart{ get; set; }
    }
}
