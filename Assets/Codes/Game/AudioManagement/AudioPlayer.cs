using UnityEngine;

namespace Game.AudioManagement
{
    
    public class AudioPlayer : MonoBehaviour
    {
        
        public int audioIndex;

        public void Play()
        {
            AudioManager.PlayAudio(audioIndex);
        }

    }

}
