using UnityEngine;
using System.Collections;

public class CoinCollect05 : MonoBehaviour {
    public static float score05;
    void Start ()
    {
        score05 = 0;
    }

    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        score05 += 1;
    }	
}
