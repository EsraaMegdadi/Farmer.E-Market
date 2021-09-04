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
   

        public string SliderImage1 { get; set; }
        public string SliderImage2{ get; set; }
        public string SliderImage3{ get; set; }

    }
}
