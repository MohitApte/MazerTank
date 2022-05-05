using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreCheck04 : MonoBehaviour {
    public Text scoreText04;
    void Update ()
    {
        scoreText04.text = "Score: " + CoinCollect04.score04;
    }
	
}
