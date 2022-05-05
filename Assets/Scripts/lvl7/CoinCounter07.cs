using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CoinCounter07 : MonoBehaviour {
    public Text scoreText;
    void Update ()
    {
        scoreText.text = "Score:" + Coin_Collect07.score07;

    }
}
