using System.Text.Json;

namespace PokemonCatch.Classes
{
    public class Game
    {
        public static Player User = new Player()
        {
            Name = "Beginner",
            PlayerLevel = new Level(),
            Money = 500,
            PokemonCaught = new List<Pokemon>(),
            PokemonEntered = new List<PokemonReference>()
        };
        public static bool HasData { get; set; } = false;

        // Saves the player's data using a JSON file.
        public static void SaveData()
        {
            string json = JsonSerializer.Serialize(User);

            File.WriteAllText("user_data.json", json);
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "\\user_data.json";
            File.WriteAllText(fileName, json);
        }

        // Grabs the player's data located in a JSON file and creates a default player objects if no data is found.
        public static void GetData()
        {
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "\\user_data.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                User = JsonSerializer.Deserialize<Player>(json) ?? new Player()
                {
                    Name = "Beginner",
                    PlayerLevel = new Level(),
                    Money = 500,
                    PokemonCaught = new List<Pokemon>(),
                    PokemonEntered = new List<PokemonReference>()
                };
            }

            HasData = true;
        }

        // Sets the player's data to a default player object.
        public static void ResetData()
        {
            User = new Player()
            {
                Name = "Beginner",
                PlayerLevel = new Level(),
                Money = 500,
                PokemonCaught = new List<Pokemon>(),
                PokemonEntered = new List<PokemonReference>()
            };

            SaveData();
        }
    }
}
