using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreCheck03 : MonoBehaviour {
    public Text scoreText;

    void Update ()
    {
        scoreText.text = "Score: " + CoinCollect03.score03;
    }
	
}
