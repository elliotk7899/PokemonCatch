namespace PokemonCatch
{
    public class Pokeball
    {
        public static Pokeball[] AllPokeBalls =
        {
            new Pokeball()
            {
                Name = "Poke Ball",
                CatchChance = 1,
                Image = "https://www.serebii.net/itemdex/sprites/sv/pokeball.png",
                Description = "Stuff",
                Price = 100
            },
            new Pokeball()
            {
                Name = "Great Ball",
                CatchChance = 1.5,
                Image = "https://www.serebii.net/itemdex/sprites/sv/pokeball.png",
                Description = "Stuff",
                Price = 100
            },
            new Pokeball()
            {
                Name = "Ultra Ball",
                CatchChance = 2,
                Image = "https://www.serebii.net/itemdex/sprites/sv/pokeball.png",
                Description = "Stuff",
                Price = 100
            },
            new Pokeball()
            {
                Name = "Master Ball",
                CatchChance = 8,
                Image = "https://www.serebii.net/itemdex/sprites/sv/pokeball.png",
                Description = "Stuff",
                Price = 100
            }
        };

        public string Name { get; set; }
        public double CatchChance { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
