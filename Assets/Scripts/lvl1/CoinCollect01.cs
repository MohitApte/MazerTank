using UnityEngine;
using System.Collections;

public class CoinCollect01 : MonoBehaviour {
    public static float score01;

    void Start()
    {
        score01 = 0f;

    }



    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        score01 += 1;
    }
}
