using BlackArrow.LogManager.SharedKernell;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace BlackArrow.LogManager.Repository
{
    public class MongoContext : MongoContextConfig
    {
        public MongoContext()
        {
            MongoDefaults.GuidRepresentation = GuidRepresentation.Standard;
            var client = new MongoClient(this.Client);
            var database = client.GetDatabase(this.Database);
        }

    }
}
