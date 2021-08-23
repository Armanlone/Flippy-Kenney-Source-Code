
namespace Game
{
    
    ///<summary>
    /// Handles the game logics.
    ///<summary>

    public class GameManager
    {

        private static GameManager INSTANCE = null;

        // Doesn't use Unity's Awake() to return an instance using Singleton Pattern.
        private static GameManager getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new GameManager();
            }
            
            return INSTANCE;

        }

        // Bools for generic game.
        private bool IsGamePause = false;
        private bool IsGameOver = false;

        private bool IsLevelClear = false;

        #region Setter(s)
        public static void setIsGamePause(bool isGamePause)
        {
            getInstance().IsGamePause = isGamePause;
        }

        public static void setIsGameOver(bool isGameOver)
        {
            getInstance().IsGameOver = isGameOver;
        }

        public static void setIsLevelClear(bool isLevelClear)
        {
            getInstance().IsLevelClear = isLevelClear;
        }

        #endregion

        #region Getter(s)
        
        public static bool getIsGamePause()
        {
            return getInstance().IsGamePause;
        }

        public static bool getIsGameOver()
        {
            return getInstance().IsGameOver;
        }

        public static bool getIsLevelClear()
        {
            return getInstance().IsLevelClear;
        }

        #endregion

    }

}