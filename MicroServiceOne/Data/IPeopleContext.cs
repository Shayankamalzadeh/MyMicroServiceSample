using MicroServiceOne.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceOne.Data
{
    public interface IMicroserviceOneContext
    {
        IMongoCollection<Person> People { get;  }
    }
}
