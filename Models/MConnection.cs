using MongoDB.Driver;
using Microsoft.Extensions.Options;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models
{
    public class MConnection
    {
        private readonly IMongoDatabase _database;
        public MConnection(IOptions<MongoDBSettings> settings)
        {
            var connectionString = Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING")
                                   ?? settings.Value.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("La cadena de conexión a MongoDB no está configurada.");
            }

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}