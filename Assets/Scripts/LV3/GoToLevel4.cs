using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MadLevelManager;
public class GoToLevel4 : MonoBehaviour {
    public GameObject CoinsNotCollected;
    void OnTriggerEnter()
    {
        if (CoinCollect03.score03 == 5)
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
