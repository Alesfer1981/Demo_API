using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_API.Business.Locations;
using Demo_API.Model;
using Demo_API.Model.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Demo_API.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IOptions<ConfigurationModel> _configurations;

        private LocationBusiness _locationBusiness = null;

        public LocationController(IOptions<ConfigurationModel> configuration)
        {
            _configurations = configuration;
            _locationBusiness = new LocationBusiness(_configurations.Value);
        }

        [HttpGet("{idChain}")]
        //[Route("location")]
        public ActionResult<List<LocationModel>> getLocationList(string idChain)
        {
            try
            {
                return _locationBusiness.getLocations(idChain);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("echoping")]
        public IActionResult EchoPingAgents()
        {
            return Ok(true);
        }
    }
}