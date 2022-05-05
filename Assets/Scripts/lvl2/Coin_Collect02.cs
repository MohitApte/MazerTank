using UnityEngine;
using System.Collections;

public class Coin_Collect02 : MonoBehaviour {
    public static float score02;

    void Start ()
    {

        score02 = 0;
    }
    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        score02 += 1;
    }
	
}
