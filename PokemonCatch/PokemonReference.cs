namespace PokemonCatch
{
    public class PokemonReference
    {
        public static PokemonReference[] AllPokemon = {
            new PokemonReference() {
                Name = "Pikachu",
                Weight = 13.2,
                Type = PokemonType.Electric,
                HasGender = true,
                Image = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/025.png",
                ShinyImage = "https://helixpedia.fandom.com/wiki/Shiny_Pikachu"
            }
        };

        public string Name { get; set; }
        public double Weight { get; set; }
        public PokemonType Type { get; set; }
        public bool HasGender { get; set; }
        public string Image { get; set; }
        public string ShinyImage { get; set; }
        public double CatchRate { get; set; }
        public bool HasTwoTypes = false;
        public PokemonType Type2 { get; set; }
    }
}
