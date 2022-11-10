namespace Pokedex_API.Models
{
    public class PokemonType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<PokemonType> Strenghts { get; set; } = new List<PokemonType>();
        public List<PokemonType> Weaknesses { get; set; } = new List<PokemonType>();
        public List<PokemonType>? NoEffectOn { get; set; }
        public List<PokemonType>? NoEffectFrom { get; set; }
    }
}