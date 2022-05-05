using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreCheck05 : MonoBehaviour {
    public Text scoreText05;
	void Update ()
    {
        scoreText05.text = "Score: " + CoinCollect05.score05;
    }
}
