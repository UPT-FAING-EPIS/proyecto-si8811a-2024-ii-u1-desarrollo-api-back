using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly ParticipanteService _participanteService;

        public ParticipanteController(ParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpGet]
        public async Task<List<Participante>> Get() =>
            await _participanteService.GetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Participante>> GetById(string id)
        {
            var participante = await _participanteService.GetByIdAsync(id);
            if (participante == null)
            {
                return NotFound();
            }
            return participante;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Participante nuevoParticipante)
        {
            await _participanteService.CreateAsync(nuevoParticipante);
            return CreatedAtAction(nameof(GetById), new { id = nuevoParticipante.Id }, nuevoParticipante);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Participante participanteActualizado)
        {
            var participante = await _participanteService.GetByIdAsync(id);
            if (participante == null)
            {
                return NotFound();
            }

            await _participanteService.UpdateAsync(id, participanteActualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var participante = await _participanteService.GetByIdAsync(id);
            if (participante == null)
            {
                return NotFound();
            }

            await _participanteService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("search/{nombre}")]
        public async Task<List<Participante>> SearchByName(string nombre) =>
            await _participanteService.SearchByNameAsync(nombre);

        [HttpGet("equipo/{equipoId}")]
        public async Task<List<Participante>> GetByEquipoId(string equipoId) =>
            await _participanteService.GetByEquipoIdAsync(equipoId);
    }
}