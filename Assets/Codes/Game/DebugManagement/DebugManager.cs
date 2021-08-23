using UnityEngine;

namespace Game.DebugManagement
{

    ///<summary>
    /// For debugging.
    ///</summary>
    
    public class DebugManager
    {
        
        private static DebugManager INSTANCE = null;

        // Doesn't use Unity to return an instance in Singleton method.
        private static DebugManager getInstance()
        {

            if (INSTANCE == null)
            {
                INSTANCE = new DebugManager();
            }
            
            return INSTANCE;

        }

        // Debug text in DEFAULT mode.
        public static void ShowDebug(string debugText)
        {

            if (getInstance() == null)
                return;

            else if (string.IsNullOrEmpty(debugText))
                return;

            else
            {
                Debug.Log(debugText);
            }

        }

        // Debug text in ALERT mode.
        public static void ShowAlert(string debugText)
        {

            if (getInstance() == null)
                return;

            else if (string.IsNullOrEmpty(debugText))
                return;

            else
            {
                Debug.LogWarning(debugText);
            }

        }

        // Debug text in ERROR mode.
        public static void ShowError(string debugText)
        {

            if (getInstance() == null)
                return;

            else if (string.IsNullOrEmpty(debugText))
                return;

            else
            {
                Debug.LogError(debugText);
            }

        }

    }

}