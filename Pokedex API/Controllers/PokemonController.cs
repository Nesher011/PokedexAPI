using Microsoft.AspNetCore.Mvc;
using Pokedex_API.Interfaces;
using Pokedex_API.Models;

namespace Pokedex_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pokemon>>> GetAllPokemons()
        {
            return Ok(await _pokemonRepository.GetAll());
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<List<Pokemon>>> GetPokemonsByType(PokemonType type)
        {
            return Ok(await _pokemonRepository.GetByType(type));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Pokemon>>> GetPokemon(int id)
        {
            return await _pokemonRepository.GetById(id) is Pokemon p ? Ok(p) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Pokemon>> Add(Pokemon pokemon)
        {
            await _pokemonRepository.Create(pokemon);

            return Ok(pokemon);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pokemon>> Update(int id, Pokemon pokemon)
        {
            await _pokemonRepository.Update(pokemon);

            return Ok(pokemon);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid guid)
        {
            await _pokemonRepository.Delete(guid);

            return NoContent();
        }
    }
}