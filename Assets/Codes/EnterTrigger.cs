
using UnityEngine;
using UnityEngine.Events;

namespace Essentials
{

    ///<summary> When triggered, do an event. </summary>
    
    public class EnterTrigger : MonoBehaviour
    {

        [SerializeField]
        private string tagName = null;

        [Space]

        [SerializeField]
        private UnityEvent enterTrigger = new UnityEvent();

        //Method that manages triggering the event.
        private void OnTriggerEnter2D(Collider2D collision)
        {

            //It will return if the tagName is null or empty,
            if (string.IsNullOrEmpty(tagName))
                return;

            //Or if the tagName is not the same as the one triggers it.
            else if (!collision.CompareTag(tagName))
                return;

            else
                enterTrigger?.Invoke();

        }

    }   
}