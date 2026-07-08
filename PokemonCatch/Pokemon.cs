namespace PokemonCatch
{
    public class Pokemon
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public PokemonType Type1 { get; set; }
        public string Gender { get; set; }

        public bool IsShiny = false;
        public string Image { get; set; }
        public PokemonType Type2 { get; set; }
        
        public static Pokemon CreatePokemon(PokemonReference Reference)
        {
            Random rand = new Random();

            Pokemon NewPokemon = new Pokemon()
            {
                Name = Reference.Name,
                Weight = Reference.Weight,
                Height = Reference.Height,
                Type1 = Reference.Type
            };

            if (Reference.HasGender)
            {
                if (rand.Next(1, 3) == 1)
                {
                    NewPokemon.Gender = "Male";
                }
                else
                {
                    NewPokemon.Gender = "Female";
                }
            }
            else
            {
                NewPokemon.Gender = "Genderless";
            }

            if (Reference.HasTwoTypes)
            {
                NewPokemon.Type2 = Reference.Type2;
            }

            if (rand.Next(1, 4096) == 4096)
            {
                NewPokemon.IsShiny = true;
            } else
            {
                NewPokemon.IsShiny = false;
            }

            if (NewPokemon.IsShiny)
            {
                NewPokemon.Image = Reference.ShinyImage;
            }
            else
            {
                NewPokemon.Image = Reference.Image;
            }

            return NewPokemon;
        }
    }

    public enum PokemonType
    {
        Attacking,
        Normal,
        Fire,
        Water,
        Electric,
        Grass,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }
}
