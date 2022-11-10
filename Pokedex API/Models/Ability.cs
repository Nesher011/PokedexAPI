namespace Pokedex_API.Models
{
    public class Ability : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public PokemonType Type { get; set; } = new PokemonType();
        public AbilityCategory Category { get; set; } = new AbilityCategory();
        public int PP { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}