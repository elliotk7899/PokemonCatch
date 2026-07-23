namespace PokemonCatch.Classes
{
    public class Pokeball
    {
        public static Pokeball[] AllPokeBalls =
        {
            new Pokeball()
            {
                Name = "Poke Ball",
                CatchChance = 1,
                Image = "Images/Other/PokeBallImage.png",
                Description = "A device for catching wild Pokémon. It is thrown like a ball at the target, comfortably encapsulating its target.",
                Price = 100
            },
            new Pokeball()
            {
                Name = "Great Ball",
                CatchChance = 1.5,
                Image = "Images/Other/GreatBallImage.png",
                Description = "A good, high-performance Ball that provides a higher Pokémon catch rate than a standard Poke Ball.",
                Price = 200
            },
            new Pokeball()
            {
                Name = "Ultra Ball",
                CatchChance = 2,
                Image = "Images/Other/UltraBallImage.png",
                Description = "An ultra-high-performance Poke Ball that provides a higher success rate for catching Pokémon than a Great Ball.",
                Price = 400
            },
            new Pokeball()
            {
                Name = "Master Ball",
                CatchChance = 8,
                Image = "Images/Other/MasterBallImage.png",
                Description = "The ultimate Poké Ball, known for having a guaranteed 100% success rate.",
                Price = 10000
            }
        };

        public string Name { get; set; }
        public double CatchChance { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public static Pokeball AddBallItem(string BallName, int Amount)
        {
            foreach (var CurrentBall in AllPokeBalls)
            {
                if (CurrentBall.Name == BallName)
                {
                    Pokeball Ball = new Pokeball()
                    {
                        Name = CurrentBall.Name,
                        CatchChance = CurrentBall.CatchChance,
                        Number = Amount,
                        Image = CurrentBall.Image
                    };

                    return Ball;
                }
            }

            Pokeball DefBall = new Pokeball()
            {
                Name = AllPokeBalls[0].Name,
                CatchChance = AllPokeBalls[0].CatchChance,
                Number = Amount,
                Image = AllPokeBalls[0].Image
            };

            return DefBall;
        }
    }
}
