namespace PokemonCatch.Classes
{
    public class Pokemon
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Height { get; set; }
        public PokemonType Type1 { get; set; }
        public string Gender { get; set; }

        public bool IsShiny = false;
        public string Image { get; set; }
        public int Value { get; set; }

        public PokemonType? Type2 = null;
        public string TypeName { get; set; }
        
        public static Pokemon CreatePokemon(PokemonReference Reference)
        {
            Random rand = new Random();

            Pokemon NewPokemon = new Pokemon()
            {
                Name = Reference.Name,
                Height = Reference.Height,
                Type1 = Reference.Type
            };

            NewPokemon.Weight = Math.Round(Reference.Weight + (rand.Next(-50, 51) / 10.0), 1);

            if (NewPokemon.Weight < 0.2)
            {
                NewPokemon.Weight = 0.2;
            }

            if (Reference.HasGender)
            {
                if (Reference.HasSetGender)
                {
                    NewPokemon.Gender = Reference.SetGender ?? "";
                } 
                else
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
            }
            else
            {
                NewPokemon.Gender = "Genderless";
            }

            if (Reference.HasTwoTypes)
            {
                NewPokemon.Type2 = Reference.Type2;

                NewPokemon.TypeName = NewPokemon.Type1 + "/" + NewPokemon.Type2;
            } else
            {
                NewPokemon.TypeName = NewPokemon.Type1.ToString();
            }

            if (rand.Next(1, 4097) == 4098) // Will never happen because they're aren't any images for shiny pokemon yet.
            {
                NewPokemon.IsShiny = true;
            } else
            {
                NewPokemon.IsShiny = false;
            }

            if (NewPokemon.IsShiny)
            {
                NewPokemon.Image = "Images/PokemonImages/" + Reference.Name + "ShinyImage.png";
            }
            else
            {
                NewPokemon.Image = "Images/PokemonImages/" + Reference.Name + "Image.png";
            }

            NewPokemon.Value = (int)(Math.Round(Reference.Value * (NewPokemon.Weight / Reference.Weight)));

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
