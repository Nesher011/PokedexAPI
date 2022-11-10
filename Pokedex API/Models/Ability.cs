namespace Pokedex_API.Models
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public AbilityCategory Category { get; set; }
        public int PP { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
        public string Description { get; set; }
    }
}