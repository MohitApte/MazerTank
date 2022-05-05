using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MadLevelManager;
public class GOTOLEVEL2 : MonoBehaviour
{
    public Text CoinNotCollectedText;
    public GameObject canvas;


    void Update ()
    {
        CoinNotCollectedText.text = "Gold Not Collected!!!";

    }


    void Start ()
    {
        canvas.SetActive(false);
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (CoinCollect01.score01 == 1)
        {
            MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
            MadLevel.LoadLevelByName("Level Select");
        }
        else
        {
            StartCoroutine(closecanvas());
        }
    }
        IEnumerator closecanvas ()
            {
        canvas.SetActive(true);
            yield return new WaitForSeconds(2);
                 canvas.SetActive(false);
        }

    

}
