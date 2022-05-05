using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

	public GameObject bullet;
	void OnTriggerEnter(Collider other)
	{
		Destroy (bullet);
	}
}
