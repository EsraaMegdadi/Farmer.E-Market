using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Data
{
  public  class ContactUs
    {
        public int ContactUsId { get; set; }
        public string Paragraph1 { get; set; }
        public string Paragraph2{ get; set; }
        public string BackgraoundImage { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public int LocationId { get; set; }

        public int HomePageId { get; set; }
    }
}
