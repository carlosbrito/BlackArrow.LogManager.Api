using BlackArrow.LogManager.SharedKernell;
using Microsoft.Extensions.Configuration;
using System;

namespace BlackArrow.LogManager.SharedKernell
{

    public abstract class MongoContextConfig
    {
        private readonly IConfiguration _configuration;

        public string Client { get; set; }
        public string Database { get; set; }
        public MongoContextConfig()
        {
            this.Client = _configuration.GetConnectionString("mongoDbconnectionString");
            this.Database = _configuration.GetConnectionString("mongoDbdatabasename");
        }
        public MongoContextConfig(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Client = _configuration.GetConnectionString("mongoDbconnectionString");
            this.Database = _configuration.GetConnectionString("mongoDbdatabasename");

        }


    }

}
