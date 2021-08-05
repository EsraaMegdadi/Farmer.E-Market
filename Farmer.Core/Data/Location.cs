using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Core.Data
{
   public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }
        public ICollection<Users> users { get; set; }

    }
}
