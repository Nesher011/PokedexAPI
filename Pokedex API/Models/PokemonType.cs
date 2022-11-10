namespace Pokedex_API.Models
{
    public class PokemonType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<PokemonType> Strenghts { get; set; }
        public List<PokemonType> Weaknesses { get; set; }
        public List<PokemonType>? NoEffectOn { get; set; }
        public List<PokemonType?> NoEffectFrom { get; set; }
    }
}