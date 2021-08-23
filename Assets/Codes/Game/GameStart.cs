using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    
    ///<summary>
    /// Simple script to start the game.
    ///</summary>

    public class GameStart : MonoBehaviour
    {
        
        [Tooltip("Things to do when starting the game.")]
        [SerializeField]
        private UnityEvent onStart = new UnityEvent();

        //Do the things at start.
        private void Start() => onStart?.Invoke();

    }

}