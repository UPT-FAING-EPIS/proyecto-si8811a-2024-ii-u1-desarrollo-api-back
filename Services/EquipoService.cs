using Microsoft.Extensions.Options;
using MongoDB.Driver;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class EquipoService
    {
        private readonly IMongoCollection<Equipo> _equipos;

        public EquipoService(IMongoClient client, IOptions<MongoDBSettings> settings)
        {
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _equipos = database.GetCollection<Equipo>("Equipo");
        }

        public async Task<List<Equipo>> GetAsync() =>
            await _equipos.Find(e => true).ToListAsync();

        public async Task CreateAsync(Equipo nuevoEquipo) =>
            await _equipos.InsertOneAsync(nuevoEquipo);
    }
}
