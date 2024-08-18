using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipoController : Controller
    {
        private readonly EquipoService _equipoService;

        public EquipoController(EquipoService equipoService)
        {
            _equipoService = equipoService;
        }

        [HttpGet]
        public async Task<List<Equipo>> Get() =>
            await _equipoService.GetAsync();

        [HttpPost]
        public async Task<IActionResult> Post(Equipo nuevoEquipo)
        {
            await _equipoService.CreateAsync(nuevoEquipo);
            return CreatedAtAction(nameof(Get), new { id = nuevoEquipo.Id }, nuevoEquipo);
        }
    }
}
