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
        public int Quantity { get; set; }
        public double Amount { get; set; }

        [ForeignKey("ProuductId")]
        public int ProuductId { get; set; }

        //public virtual Prouduct product {get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual Users user {get; set; }

    }
}
