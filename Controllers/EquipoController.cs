using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipoController : ControllerBase
    {
        private readonly EquipoService _equipoService;

        public EquipoController(EquipoService equipoService)
        {
            _equipoService = equipoService;
        }

        [HttpGet]
        public async Task<List<Equipo>> Get() =>
            await _equipoService.GetAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Equipo>> GetById(string id)
        {
            var equipo = await _equipoService.GetByIdAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return equipo;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Equipo nuevoEquipo)
        {
            await _equipoService.CreateAsync(nuevoEquipo);
            return CreatedAtAction(nameof(GetById), new { id = nuevoEquipo.Id }, nuevoEquipo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Equipo equipoActualizado)
        {
            var equipo = await _equipoService.GetByIdAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            await _equipoService.UpdateAsync(id, equipoActualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var equipo = await _equipoService.GetByIdAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }

            await _equipoService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("search/{nombre}")]
        public async Task<List<Equipo>> SearchByName(string nombre) =>
            await _equipoService.SearchByNameAsync(nombre);

        [HttpGet("{equipoId}/participantes")]
        public async Task<List<Participante>> GetParticipantes(string equipoId) =>
            await _equipoService.GetParticipantesAsync(equipoId);
    }
}