namespace PokemonCatch.Classes
{
    public class Level
    {
        public int LevelNum { get; set; } = 1;
        public int Xp { get; set; } = 0;

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
