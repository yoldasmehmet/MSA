using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalag.API.Data.Interfaces

{
    public class ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
