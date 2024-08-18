using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipanteController : Controller
    {
        private readonly ParticipanteService _participanteService;

        public ParticipanteController(ParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Participante nuevoParticipante)
        {
            await _participanteService.CreateAsync(nuevoParticipante);
            return CreatedAtAction(nameof(Get), new { id = nuevoParticipante.Id }, nuevoParticipante);
        }

        [HttpGet]
        public async Task<List<Participante>> Get() =>
            await _participanteService.GetAsync();
    }
}
