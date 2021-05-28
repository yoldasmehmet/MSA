using Catalag.API.Data.Interfaces;
using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalag.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var dbsettings = configuration.GetSection("DtabaseSettings");
            var connstr = dbsettings.GetValue<string>("ConnectionString");
            var dbName = dbsettings.GetValue<string>("DatabaseName");
            var collectionName = dbsettings.GetValue<string>("CollectionName");
            var client = new MongoDB.Driver.MongoClient(connstr);
            var database = client.GetDatabase(dbName);
            Products = database.GetCollection<Product>(collectionName);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
