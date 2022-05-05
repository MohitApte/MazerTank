using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreCheck01 : MonoBehaviour {
    public Text ScoreText01;
    void Start ()
    {
        
    }
    void Update ()
    {
        ScoreText01.text = "Score:" + CoinCollect01.score01;
    }

}
