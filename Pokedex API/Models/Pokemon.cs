namespace Pokedex_API.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public PokemonType PrimaryType { get; set; }
        public PokemonType? SecondaryType { get; set; }
        public List<PokemonType> Weaknesses { get; set; }
        public PokemonCategory Category { get; set; }
        public PokemonStatistics Statistics { get; set; }
        public Ability FirstAbility { get; set; }
        public Ability? SecondAbility { get; set; }
        public Ability? HiddenAbility { get; set; }
        public List<int> PossibleGenders { get; set; }
    }
}