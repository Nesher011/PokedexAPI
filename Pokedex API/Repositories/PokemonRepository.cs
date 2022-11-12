using AutoMapper;
using Pokedex_API.Database;
using Pokedex_API.Dtos;
using Pokedex_API.Interfaces;
using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public class PokemonRepository : BaseRepository<Pokemon, PokemonDto>, IPokemonRepository
    {
        private readonly PokedexContext _dbContext;
        private readonly IMapper _mapper;

        public PokemonRepository(PokedexContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<PokemonDto>> GetByType(PokemonType type)
        {
            return _mapper.Map<List<PokemonDto>>(_dbContext.Pokemons
                .Where(pokemon => (pokemon.PrimaryType == type || pokemon.SecondaryType == type))
                .ToList());
        }
    }
}