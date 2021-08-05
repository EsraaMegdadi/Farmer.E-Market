using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Farmer.Core.Data
{
   public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public int RoleDescription { get; set; }
    }
}
