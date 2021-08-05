using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface IJWTUserAuthService
    {
        string Authenticate(Users user);
    }
}
