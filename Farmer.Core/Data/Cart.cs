using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
    public class Cart
    {
        [Key]

        public int CartId { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Enter Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Enter Amount")]
        public double Amount { get; set; }

        [Display(Name = "ProuductId")]
        [Required(ErrorMessage = "Enter ProuductId")]
        [ForeignKey("ProuductId")]
        public int ProuductId { get; set; }

        //public virtual Prouduct product {get; set; }
      

        public string username { get; set; }
    }
}
