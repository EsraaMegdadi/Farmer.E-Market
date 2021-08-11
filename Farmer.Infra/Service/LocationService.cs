using Farmer.Core.Data;
using Farmer.Core.Repository;
using Farmer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Farmer.Infra.Service
{
  public  class LocationService:ILocationService
    {
        private readonly ILocationRepository LocationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            LocationRepository = locationRepository;

        }
        public List<Location> GetAll()
        {
            return LocationRepository.GetAll();
        }

        public Location Create(Location location)
        {
            LocationRepository.Create(location);
            return new Location();
        }

        public Location Update(Location location)
        {
            LocationRepository.Update(location);
            return new Location();
        }

        public Location Delete(int id)
        {
            LocationRepository.Delete(id);
            return new Location();
        }
    }
}
