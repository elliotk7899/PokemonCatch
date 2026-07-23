namespace PokemonCatch.Classes
{
    public class PokemonReference
    {
        public static PokemonReference[] AllPokemon = {
            new PokemonReference() {
                Name = "Pikachu",
                Weight = 13.2,
                Height = "1\' 04\"",
                Type = PokemonType.Electric,
                PokeDexNum = 25,
                HasGender = true,
                CatchRate = 75
            }
        };

        public string Name { get; set; }
        public double Weight { get; set; }
        public string Height { get; set; }
        public PokemonType Type { get; set; }
        public int PokeDexNum { get; set; }
        public bool HasGender { get; set; }
        public double CatchRate { get; set; }
        public int Value { get; set; } = 10;
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

        public static PokemonReference FindPokemonByDex(int Num)
        {
            Console.WriteLine(Num);
            foreach (var Reference in AllPokemon)
            {
                if (Reference.PokeDexNum == Num)
                {
                    return Reference;
                }
            }

            return null;
        }

        public static bool PokemonFoundInList(PokemonReference Target, List<PokemonReference> GivenList)
        {
            foreach (var Reference in GivenList)
            {
                if (Reference == Target)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
