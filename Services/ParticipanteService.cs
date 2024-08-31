using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class ParticipanteService
    {
        private readonly IMongoCollection<Participante> _participantes;
        private readonly IMongoCollection<Equipo> _equipos;

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

        public async Task<Participante> GetByIdAsync(string id) =>
            await _participantes.Find(p => p.Id == id).FirstOrDefaultAsync();
        public async Task UpdateAsync(string id, Participante participanteActualizado) =>
            await _participantes.ReplaceOneAsync(p => p.Id == id, participanteActualizado);
        public async Task DeleteAsync(string id) =>
            await _participantes.DeleteOneAsync(p => p.Id == id);
        public async Task<List<Participante>> SearchByNameAsync(string nombre) =>
            await _participantes.Find(p => p.Nombre.Contains(nombre)).ToListAsync();
        public async Task<List<Participante>> GetByEquipoIdAsync(string equipoId) =>
            await _participantes.Find(p => p.EquipoId == equipoId).ToListAsync();
    }
}