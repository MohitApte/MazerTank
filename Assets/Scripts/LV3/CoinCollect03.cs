using UnityEngine;
using System.Collections;

public class CoinCollect03 : MonoBehaviour {
    public static float score03;

    void Start ()
    {
        score03 = 0;
    }
    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        score03 += 1;
    }
}
