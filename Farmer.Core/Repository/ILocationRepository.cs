using Farmer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Core.Repository
{
   public interface ILocationRepository
    {
        List<Location> GetAll();
        Location GetById(int id);
        int Create(Location Data);
        int Update(Location Data);
        int Delete(int id);
    }
}
