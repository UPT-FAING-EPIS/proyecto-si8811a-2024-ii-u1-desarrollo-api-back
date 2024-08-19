using Microsoft.AspNetCore.Mvc;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;

namespace proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FixtureController : Controller
    {
        private readonly FixtureService _fixtureService;

        public FixtureController(FixtureService fixtureService)
        {
            _fixtureService = fixtureService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fixture>>> GetFixtures()
        {
            return await _fixtureService.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fixture>> GetFixture(string id)
        {
            return await _fixtureService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Fixture>> CreateFixture(Fixture fixture)
        {
            return await _fixtureService.CreateAsync(fixture);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Fixture>> UpdateFixture(string id, Fixture fixture)
        {
            return await _fixtureService.UpdateAsync(id, fixture);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFixture(string id)
        {
            await _fixtureService.DeleteAsync(id);
            return NoContent();
        }
    }
}
