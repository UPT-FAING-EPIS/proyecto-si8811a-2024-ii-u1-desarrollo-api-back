using Microsoft.Extensions.Options;
using MongoDB.Driver;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services
{
    public class FixtureService
    {
        private readonly IMongoCollection<Fixture> _fixtures;

        public FixtureService(IOptions<MongoDBSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _fixtures = database.GetCollection<Fixture>("Fixture");
        }

        public async Task<List<Fixture>> GetAsync() =>
            await _fixtures.Find(f => true).ToListAsync();

        public async Task<Fixture> GetByIdAsync(string id) =>
            await _fixtures.Find<Fixture>(f => f.Id == id).FirstOrDefaultAsync();

        public async Task<Fixture> CreateAsync(Fixture nuevoFixture)
        {
            await _fixtures.InsertOneAsync(nuevoFixture);
            return nuevoFixture;
        }

        public async Task<Fixture> UpdateAsync(string id, Fixture fixture)
        {
            await _fixtures.ReplaceOneAsync(a => a.Id == id, fixture);
            return fixture;
        }

        public async Task DeleteAsync(string id) =>
            await _fixtures.DeleteOneAsync(f => f.Id == id);
    }
}
