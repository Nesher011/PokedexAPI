using Pokedex_API.Models;

namespace Pokedex_API.Interfaces
{
    public interface IPokemonRepository
    {
        Task<List<Pokemon>> GetAllPokemons();

        Task<List<Pokemon>> GetPokemonsByType(PokemonType type);

        Task<Pokemon> GetPokemon(int id);

        Task<Pokemon> Add(Pokemon pokemon);

        Task<Pokemon> Update(int id, Pokemon pokemon);

        Task Delete(int id);
    }
}