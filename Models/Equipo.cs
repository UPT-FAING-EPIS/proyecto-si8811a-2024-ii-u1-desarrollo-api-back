﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models
{
    public class Equipo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public List<string> Participantes { get; set; }
    }
}