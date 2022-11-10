using Pokedex_API.Models;

namespace Pokedex_API.Interfaces
{
    public interface IPokemonRepository : IBaseRepository<Pokemon>
    {
        Task<List<Pokemon>> GetByType(PokemonType type);
    }
}