using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score_Check02 : MonoBehaviour {
    public Text scoreText02;
    void Update ()
    {
        scoreText02.text = "Score: "+ Coin_Collect02.score02;
    }
}
