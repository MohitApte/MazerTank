using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MadLevelManager;
public class GoToLevel5 : MonoBehaviour {
    public GameObject CoinsNotCollectedCanvas;
    void OnTriggerEnter()
    {
        if (CoinCollect04.score04 == 2)
        {
            MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
            MadLevel.LoadLevelByName("Level Select");
        }
        else
        {
            StartCoroutine(CollectAllCoins());
        }

    }

    IEnumerator CollectAllCoins()
    {
        CoinsNotCollectedCanvas.SetActive(true);
        yield return new WaitForSeconds(2);
        CoinsNotCollectedCanvas.SetActive(false);
    }
}
