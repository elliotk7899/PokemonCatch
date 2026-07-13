namespace PokemonCatch
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Money { get; set; }
        public List<Pokemon> PokemonCaught { get; set; }
        public Pokeball[] Bag =
        {
            new Pokeball()
            {
                Name = "Poke Ball",
                CatchChance = 1,
                Number = 5,
                Image = "https://www.serebii.net/itemdex/sprites/sv/pokeball.png"
            },
            new Pokeball()
            {
                Name = "Great Ball",
                CatchChance = 1.5,
                Number = 0
            },
            new Pokeball()
            {
                Name = "Ultra Ball",
                CatchChance = 2,
                Number = 0
            },
            new Pokeball()
            {
                Name = "Master Ball",
                CatchChance = 8,
                Number = 10
            }
        };

    }
}
