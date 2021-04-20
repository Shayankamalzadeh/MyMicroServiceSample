using MicroServiceOne.Config;
using MicroServiceOne.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceOne.Data
{
    public class MicroserviceOneContext : IMicroserviceOneContext
    {
        public MicroserviceOneContext(IMicroserviceOneDatabaseSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            People = database.GetCollection<Person>(settings.CollectionName);
        }
        public IMongoCollection<Person> People { get; }

        public IMicroserviceOneDatabaseSetting Settings { get; }
    }
}
