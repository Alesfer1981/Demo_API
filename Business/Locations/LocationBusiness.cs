using Demo_API.Data.Locations;
using Demo_API.Model;
using Demo_API.Model.Configuration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_API.Business.Locations
{
    public class LocationBusiness
    {
        LocationsRepository _envioReadRepository;

        public LocationBusiness(ConfigurationModel configuration)
        {
            _envioReadRepository = new LocationsRepository(configuration.EnvioRead);
        }

        public ActionResult<List<LocationModel>> getLocations([FromQuery] string idChain)
        {
            return _envioReadRepository.getLocations(idChain);
        }

    }
}
