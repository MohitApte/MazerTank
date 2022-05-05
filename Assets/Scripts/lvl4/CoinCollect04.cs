using UnityEngine;
using System.Collections;

public class CoinCollect04 : MonoBehaviour {
    public static float score04;
    void Start ()
    {
        score04 = 0;
    }
    void OnTriggerEnter (Collider other)
    {
        Destroy(gameObject);
        score04 += 1;
    }
}
