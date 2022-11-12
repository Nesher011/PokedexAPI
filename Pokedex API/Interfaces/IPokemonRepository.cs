using Pokedex_API.Dtos;
using Pokedex_API.Models;

namespace Pokedex_API.Interfaces
{
    public interface IPokemonRepository : IBaseRepository<Pokemon, PokemonDto>
    {
        Task<List<PokemonDto>> GetByType(PokemonType type);
    }
}