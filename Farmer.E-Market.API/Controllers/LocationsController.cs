using Farmer.Core.Data;
using Farmer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmer.E_Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : Controller
    {
        private readonly ILocationService LocationService;
        public LocationsController(ILocationService locationService)
        {
            LocationService = locationService;


        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Location>), StatusCodes.Status200OK)]
        public List<Location> GetAll()
        {
            return LocationService.GetAll();
        }

        [Route("{LocationId}")]
        [HttpGet]
        public Location getbyid(int LocationId)
        {
            return LocationService.getbyid(LocationId);
        }










        [HttpPost]
        [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Location Create([FromBody] Location location)
        {
            return LocationService.Create(location);
        }



        [HttpPut]
        [ProducesResponseType(typeof(Location), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Location), StatusCodes.Status400BadRequest)]

        public Location Update([FromBody] Location location)
        {
            return LocationService.Update(location);
        }


        [HttpDelete("{id}")]
        public Location Delete(int id)
        {
            return LocationService.Delete(id);
        }

    }
}
