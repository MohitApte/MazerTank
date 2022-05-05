using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour {

public void levelRestart ()
    {
        SceneManager.LoadScene(5);
    }
}
