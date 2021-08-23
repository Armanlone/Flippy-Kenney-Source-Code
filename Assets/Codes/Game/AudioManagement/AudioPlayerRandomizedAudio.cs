using UnityEngine;

namespace Game.AudioManagement
{
    
    ///<summary> Plays random audio through given audio indeces. </summary>

    public class AudioPlayerRandomizedAudio : MonoBehaviour
    {

        public int[] audioClipIndeces;

        // Picks a randomized audio.
        public void PickRandomAudio() => AudioManager.PlayRandomAudio(audioClipIndeces);
        
    }

}
