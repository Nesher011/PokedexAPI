using Pokedex_API.Models;

namespace Pokedex_API.Dtos
{
    public class PokemonDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; } = string.Empty;
        public PokemonType PrimaryType { get; set; } = new PokemonType();
        public PokemonType? SecondaryType { get; set; }
        public List<string> Weaknesses { get; set; } = new List<string>();
        public PokemonCategory Category { get; set; } = new PokemonCategory();
        public PokemonStatistics Statistics { get; set; } = new PokemonStatistics();
        public Ability FirstAbility { get; set; } = new Ability();
        public Ability? SecondAbility { get; set; }
        public Ability? HiddenAbility { get; set; }
    }
}