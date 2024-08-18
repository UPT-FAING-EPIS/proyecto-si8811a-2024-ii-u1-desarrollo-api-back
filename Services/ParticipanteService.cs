using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class ParticipanteService
    {
        private readonly IMongoCollection<Equipo> _equipos;
        private readonly IMongoCollection<Participante> _participantes;

        public ParticipanteService(IMongoClient client, IOptions<MongoDBSettings> settings)
        {
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _participantes = database.GetCollection<Participante>("Participante");
            _equipos = database.GetCollection<Equipo>("Equipo");
        }

        public async Task<List<Participante>> GetAsync() =>
            await _participantes.Find(p => true).ToListAsync();

        public async Task CreateAsync(Participante nuevoParticipante)
        {
            await _participantes.InsertOneAsync(nuevoParticipante);
            var filter = Builders<Equipo>.Filter.Eq(e => e.Id, nuevoParticipante.EquipoId);
            var update = Builders<Equipo>.Update.Push(e => e.Participantes, nuevoParticipante.Id);
            await _equipos.UpdateOneAsync(filter, update);
        }
    }
}