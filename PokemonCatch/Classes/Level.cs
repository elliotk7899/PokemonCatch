namespace PokemonCatch.Classes
{
    public class Level
    {
        public int LevelNum { get; set; } = 1;
        public int Xp { get; set; } = 0;

        // Adds new xp gained to the Xp attribute and checks for a level up.
        public void AddExp(int Amount)
        {
            if (LevelNum >= 100)
            {
                LevelNum = 100;
                Xp = LevelNum * 25;
                return;
            }

            Xp += Amount;

            CheckForLevelUp();
        }

        // Checks to see if there is enough xp for a level and increases the level by 1 for each time there is enough xp to do so.
        public void CheckForLevelUp()
        {
            while (Xp >= (LevelNum * 25))
            {
                Xp -= LevelNum * 25;
                LevelNum++;
            }

            if (LevelNum >= 100)
            {
                LevelNum = 100;
                Xp = LevelNum * 25;
            }
        }
    }
}
