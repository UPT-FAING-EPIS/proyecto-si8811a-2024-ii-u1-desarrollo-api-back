using Microsoft.Extensions.Options;
using MongoDB.Driver;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class EquipoService
    {
        private readonly IMongoCollection<Equipo> _equipos;
        private readonly IMongoCollection<Participante> _participantes;

        public EquipoService(IMongoClient client, IOptions<MongoDBSettings> settings)
        {
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _equipos = database.GetCollection<Equipo>("Equipo");
            _participantes = database.GetCollection<Participante>("Participante");
        }

        public async Task<List<Equipo>> GetAsync() =>
            await _equipos.Find(e => true).ToListAsync();

        public async Task CreateAsync(Equipo nuevoEquipo) =>
            await _equipos.InsertOneAsync(nuevoEquipo);

        public async Task<Equipo> GetByIdAsync(string id) =>
            await _equipos.Find(e => e.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(string id, Equipo equipoActualizado) =>
            await _equipos.ReplaceOneAsync(e => e.Id == id, equipoActualizado);

        public async Task DeleteAsync(string id) =>
            await _equipos.DeleteOneAsync(e => e.Id == id);

        public async Task<List<Equipo>> SearchByNameAsync(string nombre) =>
            await _equipos.Find(e => e.Nombre.Contains(nombre)).ToListAsync();

        public async Task<List<Participante>> GetParticipantesAsync(string equipoId)
        {
            var equipo = await _equipos.Find(e => e.Id == equipoId).FirstOrDefaultAsync();
            if (equipo == null || equipo.Participantes == null || !equipo.Participantes.Any())
            {
                return new List<Participante>();
            }

            var filter = Builders<Participante>.Filter.In(p => p.Id, equipo.Participantes);
            var participantes = await _participantes.Find(filter).ToListAsync();

            return participantes;
        }
    }
}