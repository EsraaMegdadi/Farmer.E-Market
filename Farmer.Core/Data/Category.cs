using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Core.Data
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name = "CategoryName")]
        [Required(ErrorMessage = "Enter CategoryName")]
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }



        public ICollection<Products> products { get; set; }
    }
}
