using UnityEngine;


namespace Game.LevelManagement
{

    ///<summary> Class that Loads a level. </summary>

    public class LevelLoader : MonoBehaviour
    {

        ///<summary> Loads the level. </summary>
        public void Load(int levelID)
        {

            if (levelID < 0)
                return;

            LevelManager.LoadLevel(levelID);

        }

    }

}