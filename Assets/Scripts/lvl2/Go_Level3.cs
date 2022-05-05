using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using MadLevelManager;
public class Go_Level3 : MonoBehaviour {
    public GameObject CoinsNotCollected;
    public Text CoinsNotCollectedText;


    void Update ()
    {
        CoinsNotCollectedText.text = "Gold Not Collected";
    }

void Start()
    {
        CoinsNotCollected.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Coin_Collect02.score02 == 3)
        {
            MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
            MadLevel.LoadLevelByName("Level Select");

        }
        else
        {
            StartCoroutine(CollectAllCoins());
        }
    }

    IEnumerator CollectAllCoins ()
            {
        CoinsNotCollected.SetActive(true);
        yield return new WaitForSeconds(2);
        CoinsNotCollected.SetActive(false);
    }
    
}
