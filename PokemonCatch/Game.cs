namespace PokemonCatch
{
    public class Game
    {
        public static Player User = new Player()
        {
            Name = "User",
            Level = 1,
            Money = 100,
            PokemonCaught = new List<Pokemon>()
        };
    }
}
