using UnityEngine;
using System.Collections;
using MadLevelManager;
public class GoToMainMenu : MonoBehaviour {
       public void mainMenu ()
    {
        MadLevel.LoadLevelByName("Level Select");

    }


}
