using UnityEngine;

namespace Game.AudioManagement
{

    ///<summary>
    /// A mini-class for playing an audio with random pitch.
    ///</summary>

    public class AudioPlayerRandomizedPitch : MonoBehaviour
    {

        // Plays the audio with an adjusted pitch.
        public void PlayRandomPitchAudio(int audioID = 1)
        {

            AudioManager.PlayAudioWithRandomPitch(audioID);

        }

    }

}