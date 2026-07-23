namespace PokemonCatch.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public Level PlayerLevel { get; set; }
        public int Money { get; set; }
        public List<Pokemon> PokemonCaught { get; set; }
        public List<PokemonReference> PokemonEntered { get; set; }
        public Pokeball[] Bag =
        {
            Pokeball.AddBallItem("Poke Ball", 15),
            Pokeball.AddBallItem("Great Ball", 0),
            Pokeball.AddBallItem("Ultra Ball", 0),
            Pokeball.AddBallItem("Master Ball", 10)
        };

    }
}
