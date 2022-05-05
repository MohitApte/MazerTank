using UnityEngine;
using System.Collections;

public class SpawnGiantTank : MonoBehaviour {
	public GameObject giantTank;

	void Start ()
	{
		giantTank.SetActive (false);
	}
	void OnTriggerEnter (Collider other)
	{
		giantTank.SetActive (true);
	}
}
