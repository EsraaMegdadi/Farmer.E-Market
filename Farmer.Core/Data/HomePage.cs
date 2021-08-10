using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core.Data
{
  public class HomePage
    {
        public int HomePageId { get; set; }
        public string Logo { get; set; }
        public string Background { get; set; }
        [ForeignKey("AboutUsId")]
        public int AboutUsId { get; set; }
        public virtual AboutUs aboutUs { get; set; }
        [ForeignKey("TestimonialId")]

        public int TestimonialId { get; set; }
        public virtual Testimonial testimonial { get; set; }
        [ForeignKey("ReviewId")]

        public int ReviewId { get; set; }
        public virtual Review review { get; set; }

    }
}
