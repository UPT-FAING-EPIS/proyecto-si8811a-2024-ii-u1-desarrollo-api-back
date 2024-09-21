using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

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

	public async Task<List<Participante>> SearchByNameAsync(string nombre)
	{
	    string nombreSinAcentos = RemoveAccents(nombre.ToLower());

	    var participantes = await _participantes.Find(p => true).ToListAsync();

	    var resultados = participantes.FindAll(p => 
	        RemoveAccents(p.Nombre.ToLower()).Contains(nombreSinAcentos)
	    );

	    return resultados;
	}
        public async Task<List<Participante>> GetByEquipoIdAsync(string equipoId) =>
            await _participantes.Find(p => p.EquipoId == equipoId).ToListAsync();

        private string RemoveAccents(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
