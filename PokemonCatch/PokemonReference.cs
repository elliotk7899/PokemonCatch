namespace PokemonCatch
{
    public class PokemonReference
    {
        public static PokemonReference[] AllPokemon = {
            new PokemonReference() {
                Name = "Pikachu",
                Weight = 13.2,
                Height = "1\' 04\"",
                Type = PokemonType.Electric,
                HasGender = true,
                Image = "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/025.png",
                ShinyImage = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/shiny/25.png",
                CatchRate = 75
            }
        };

        public string Name { get; set; }
        public double Weight { get; set; }
        public string Height { get; set; }
        public PokemonType Type { get; set; }
        public bool HasGender { get; set; }
        public string Image { get; set; }
        public string ShinyImage { get; set; }
        public double CatchRate { get; set; }
        public bool HasTwoTypes = false;

        public PokemonType? Type2 = null;


        public static PokemonReference FindPokemon(string Name)
        {
            foreach (var Reference in AllPokemon)
            {
                if (Name == Reference.Name)
                {
                    return Reference;
                }
            }

            return null;
        }
    }
}
