using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    
    ///<summary> Exits the game. </summary>

    public class GameExit : MonoBehaviour
    {

        [SerializeField]
        private UnityEvent onQuit = new UnityEvent();

        //Game Exit.
        public void Exit() => Application.Quit();

        ///<summary> Do events on quitting the game. </summary>
        private void OnApplicationQuit() => onQuit?.Invoke();
        
    }

}