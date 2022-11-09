using Microsoft.AspNetCore.Mvc;
using Pokedex_API.Models;

namespace Pokedex_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Pokemon>>> Get()
        {
            return Ok();
        }
    }
}