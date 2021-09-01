using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmer.Core
{
   public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string phoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //[ForeignKey("LocationId")]
        //public int LocationId { get; set; }
        //public virtual Location location { get; set; }
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public virtual Role role { get; set; }
    }
}
