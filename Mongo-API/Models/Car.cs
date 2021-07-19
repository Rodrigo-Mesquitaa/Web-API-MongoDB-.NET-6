using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Mongo_API.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]

        public string CarName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
