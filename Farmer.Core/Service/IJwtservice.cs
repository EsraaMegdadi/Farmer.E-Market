using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface IJwtservice
    {
        string Authencate(login login);

    }
}
