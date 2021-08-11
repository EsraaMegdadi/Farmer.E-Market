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

        [Display(Name = "CreditCardNumber")]
        [Required(ErrorMessage = "Enter CreditCardNumber")]
        public int CreditCardNumber { get; set; }

        [Display(Name = "CVC")]
        [Required(ErrorMessage = "Enter CVC")]
        public int CVC { get; set; }

        [Display(Name = "ExpMonth")]
        [Required(ErrorMessage = "Enter ExpMonth")]
        public DateTime ExpMonth { get; set; }

        [Display(Name = "ExpYear")]
        [Required(ErrorMessage = "Enter ExpYear")]
        public DateTime ExpYear { get; set; }

        [Display(Name = "UserId")]
        [Required(ErrorMessage = "Enter UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user { get; set; }

    }
}
