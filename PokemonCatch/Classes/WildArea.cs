namespace PokemonCatch.Classes
{
    public class WildArea
    {
        public static WildArea[] Areas =
        {
            new WildArea {
                Name = "Route 1",
                RequiredLevel = 1,
                Link = "/route1"
            },
            new WildArea {
                Name = "Route 2",
                RequiredLevel = 5,
                Link = "/route2"
            },
            new WildArea {
                Name = "Route 3",
                RequiredLevel = 8,
                Link = "/route3"
            }
        };
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public string Link { get; set; }

        public static int NumAreasUnlocked(int Level)
        {
            int NumUnlocked = 0;

            foreach (var Area in Areas)
            {
                if (Level >= Area.RequiredLevel)
                {
                    NumUnlocked++;
                }
            }

            return NumUnlocked;
        }
    }
}
