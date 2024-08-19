using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models
{
    public class Fixture
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public DateTime Fecha { get; set; }
        public string LugarId { get; set; }
        public List<string> Eventos { get; set; }
    }
}
