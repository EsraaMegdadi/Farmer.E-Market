using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Core.Data
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Enter UserName")]
        public string UserName { get; set; }


        [Display(Name = "Descriptiontext")]
        [Required(ErrorMessage = "Enter Descriptiontext")]
        public string Descriptiontext { get; set; }


        [Display(Name = "img")]
        [Required(ErrorMessage = "Enter  img")]
        public string img { get; set; }

        [Display(Name = "Rate")]
        [Required(ErrorMessage = "Enter  Rate")]
        public int Rate { get; set; }

    }
}

