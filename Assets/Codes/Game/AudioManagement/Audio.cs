using UnityEngine;

namespace Game.AudioManagement
{
    
    [System.Serializable]
    public class Audio
    {

        public string name = "";

        public AudioType audioType = AudioType.None;

        [HideInInspector]
        public int id = 0;

        [Space]
        [Header("Components:")]

        public AudioClip clip = null;

        [Space]

        public float volume = 0.1f;
        public float pitch = 0.1f;

        [Space]
        public bool isLoop = false;

        [HideInInspector]
        public AudioSource source = null;

    }

}