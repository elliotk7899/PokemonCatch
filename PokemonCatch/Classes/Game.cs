using System.Text.Json;

namespace PokemonCatch.Classes
{
    public class Game
    {
        public static Player User = new Player()
        {
            Name = "User",
            PlayerLevel = new Level(),
            Money = 500,
            PokemonCaught = new List<Pokemon>(),
            PokemonEntered = new List<PokemonReference>()
        };
        public static bool HasData { get; set; } = false;


        public static void SaveData()
        {
            string json = JsonSerializer.Serialize(User);

            File.WriteAllText("user_data.json", json);
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "\\user_data.json";
            File.WriteAllText(fileName, json);
        }

        public static void GetData() {
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "\\user_data.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                User = JsonSerializer.Deserialize<Player>(json) ?? new Player()
                {
                    Name = "User",
                    PlayerLevel = new Level(),
                    Money = 500,
                    PokemonCaught = new List<Pokemon>(),
                    PokemonEntered = new List<PokemonReference>()
                };
            }

            HasData = true;
        }
    }
}
