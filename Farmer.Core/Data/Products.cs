using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "ProductName")]
        [Required(ErrorMessage = "Enter ProductName")]
        public string ProductName { get; set; }

        [Display(Name = "ProductPrice")]
        [Required(ErrorMessage = "Enter ProductPrice")]
        public float ProductPrice { get; set; }

        [Display(Name = "ProductImg")]
        [Required(ErrorMessage = "Enter ProductImg")]
        public string ProductImg { get; set; }

        [Display(Name = "ProductQuantity")]
        [Required(ErrorMessage = "Enter ProductQuantity")]
        public int ProductQuantity { get; set; }

        [ForeignKey("CategoryId ")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }


        [ForeignKey("UserID")]

        public int UserID { get; set; }
        public virtual Users Users { get; set; }

    }
}
