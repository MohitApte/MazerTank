using UnityEngine;
using System.Collections;

public class WallSpikeHitRespawn : MonoBehaviour {
	public Transform respawnPoint;


	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			other.transform.position = respawnPoint.position;
			other.transform.rotation = respawnPoint.rotation;
		}
			
		
	}
}
