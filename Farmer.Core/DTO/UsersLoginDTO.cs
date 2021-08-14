using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.DTO
{
    public class UsersLoginDTO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
