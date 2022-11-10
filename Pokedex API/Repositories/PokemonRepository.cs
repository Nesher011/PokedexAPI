using Pokedex_API.Database;
using Pokedex_API.Interfaces;
using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public class PokemonRepository : BaseRepository<Pokemon>, IPokemonRepository
    {
        private readonly PokedexContext _dbContext;

        public PokemonRepository(PokedexContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Pokemon>> GetByType(PokemonType type)
        {
            throw new NotImplementedException();
        }
    }
}