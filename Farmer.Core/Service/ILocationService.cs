using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Service
{
   public interface ILocationService
    {
        List<Location> GetAll();
        Location GetById(int id);
        Location Create(Location location);
        Location Update(Location location);
        Location Delete(int id);

    }
}
