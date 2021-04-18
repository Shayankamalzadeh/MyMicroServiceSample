using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceOne.Entity

{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
    }
}
