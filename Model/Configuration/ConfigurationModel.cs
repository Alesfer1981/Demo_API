using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_API.Model.Configuration
{
    public class ConfigurationModel
    {

        IConfiguration configuration;

        public ConfigurationModel()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            configuration = builder.Build();
        }

        public string EnvioRead
        {
            get;
            set;
        }



    }
}
