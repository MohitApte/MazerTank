using UnityEngine;
using System.Collections;

public class HitRespawn05 : MonoBehaviour {
    public Transform RespawnPoint;
    public GameObject Player;

    void OnTriggerEnter (Collider other)
    {
        Player.transform.position = RespawnPoint.position;
        Player.transform.rotation = RespawnPoint.rotation;
    }
	
}
