using UnityEngine;
using System.Collections;

public class Coin_Collect07 : MonoBehaviour {
    public static float score07;
    void Start ()
    {
        score07 = 0;

    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        score07 += 1;
    }

}

