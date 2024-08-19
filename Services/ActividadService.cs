using Microsoft.Extensions.Options;
using MongoDB.Driver;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class ActividadService
    {
        private readonly IMongoCollection<Actividad> _actividades;

        public ActividadService(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _actividades = database.GetCollection<Actividad>("Actividad");
        }

        public async Task<List<Actividad>> GetAsync() =>
            await _actividades.Find(a => true).ToListAsync();

        public async Task<Actividad> GetByIdAsync(string id) =>
            await _actividades.Find<Actividad>(a => a.Id == id).FirstOrDefaultAsync();

        public async Task<Actividad> CreateAsync(Actividad nuevaActividad)
        {
            await _actividades.InsertOneAsync(nuevaActividad);
            return nuevaActividad;
        }

        public async Task<Actividad> UpdateAsync(string id, Actividad actividad)
        {
            await _actividades.ReplaceOneAsync(a => a.Id == id, actividad);
            return actividad;
        }

        public async Task DeleteAsync(string id) =>
            await _actividades.DeleteOneAsync(a => a.Id == id);
    }
}
