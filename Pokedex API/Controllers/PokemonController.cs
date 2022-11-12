using Microsoft.AspNetCore.Mvc;
using Pokedex_API.Dtos;
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
        public async Task<ActionResult<List<Pokemon>>> GetAll()
        {
            return Ok(await _pokemonRepository.GetAll());
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<List<Pokemon>>> GetByType(PokemonType type)
        {
            return Ok(await _pokemonRepository.GetByType(type));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Pokemon>>> GetById(Guid id)
        {
            return await _pokemonRepository.GetById(id) is PokemonDto p ? Ok(p) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Pokemon>> Create(PokemonDto pokemonDto)
        {
            var pokemon= await _pokemonRepository.Create(pokemonDto);
            if (pokemon == null)
                throw new NotImplementedException();

            return Ok(pokemon);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Pokemon>> Update(PokemonDto pokemonDto)
        {
            var pokemon = await _pokemonRepository.Update(pokemonDto);

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