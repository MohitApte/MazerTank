using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		SceneManager.LoadScene (6);
	}
}
