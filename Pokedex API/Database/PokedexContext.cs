using Microsoft.EntityFrameworkCore;
using Pokedex_API.Models;

namespace Pokedex_API.Database
{
    public class PokedexContext : DbContext
    {
        public DbSet<Ability> Abilities => Set<Ability>();
        public DbSet<AbilityCategory> AbilityCategories => Set<AbilityCategory>();
        public DbSet<Pokemon> Pokemons => Set<Pokemon>();
        public DbSet<PokemonCategory> PokemonCategories => Set<PokemonCategory>();
        public DbSet<PokemonType> PokemonTypes => Set<PokemonType>();

        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options)
        {
        }
    }
}