namespace Pokedex_API.Models
{
    public class PokemonType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<string> Strenghts { get; set; } = new List<string>();
        public List<string> Weaknesses { get; set; } = new List<string>();
        public List<string>? NoEffectOn { get; set; }
        public List<string>? NoEffectFrom { get; set; }
    }
}