using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Miscellaneous
{
        
    ///<summary>
    /// Timer to do stuff after seconds.
    ///</summary>

    public class Timer : MonoBehaviour
    {
        
        [Tooltip("Wait in how many seconds?")]
        public float secondsToWait = 2f;

        // Do stuff after seconds.
        [SerializeField]
        private UnityEvent onTimerEnd = new UnityEvent();

        public void WaitOnTimer()
        {
            StartCoroutine(Wait());
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(secondsToWait);
            onTimerEnd?.Invoke();
        }
    }

}