using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActividadController : Controller
    {
        private readonly ActividadService _actividadService;

        public ActividadController(ActividadService actividadService)
        {
            _actividadService = actividadService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actividad>>> GetAll()
        {
            return await _actividadService.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Actividad>> GetById(string id)
        {
            return await _actividadService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Actividad>> Create(Actividad actividad)
        {
            return await _actividadService.CreateAsync(actividad);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Actividad>> Update(string id, Actividad actividad)
        {
            return await _actividadService.UpdateAsync(id, actividad);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            await _actividadService.DeleteAsync(id);
            return NoContent();
        }
    }
}
