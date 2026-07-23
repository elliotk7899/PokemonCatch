namespace PokemonCatch.Classes
{
    public class Game
    {
        public static Player User = new Player()
        {
            Name = "User",
            PlayerLevel = new Level(),
            Money = 1000,
            PokemonCaught = new List<Pokemon>(),
            PokemonEntered = new List<PokemonReference>()
        };
    }
}
