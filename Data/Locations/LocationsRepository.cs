using Dapper;
using Demo_API.Helper;
using Demo_API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_API.Data.Locations
{
    public class LocationsRepository
    {
        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connection"></param>
        public LocationsRepository(string connection)
        {
            _connectionString = connection;
        }

        public ActionResult<List<LocationModel>> getLocations([FromQuery] string idChain)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IdChain", idChain);

                var query = dbConnection.Query<LocationModel>(Constants.spGetCrmSisterAgencies,
                                                              p,
                                                              commandType: CommandType.StoredProcedure);
                return query.AsList();

            }

        }

    }
}
