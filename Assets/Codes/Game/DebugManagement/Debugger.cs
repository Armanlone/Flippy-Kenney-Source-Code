using UnityEngine;

namespace Game.DebugManagement
{
    
    ///<summary>
    /// A debug.
    ///</summary>

    public class Debugger : MonoBehaviour
    {

        [SerializeField]
        private DebugType debugType = DebugType.Default;

        [Tooltip("The message to display in console.")]
        [SerializeField]
        [TextArea]
        private string text = string.Empty;

        public void Show()
        {

            if (string.IsNullOrEmpty(text))
                return;

            else
            {

                switch (debugType)
                {

                    case DebugType.Default:
                        DebugManager.ShowDebug(text);
                        break;

                    case DebugType.Alert:
                        DebugManager.ShowAlert(text);
                        break;
                    
                    case DebugType.Error:
                        DebugManager.ShowError(text);
                        break;

                }

            }

        }

    }

}