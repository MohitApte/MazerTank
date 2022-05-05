using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WinLoseManager : MonoBehaviour {
    public GameObject winCanvas;
    public GameObject LoseCanvas;
    void Start()
    {
        winCanvas.SetActive(false);
        LoseCanvas.SetActive(false);
    }
    void Update()
    {
        if (Health.playerHealth == 0)
        {
            Lose();
        }
        if (Health.enemyHealth == 0)
        {
            Win();
        }
    }
    void Lose ()
    {
		SceneManager.LoadScene (5);
       
    }
    void Win ()
    {

    }
}
