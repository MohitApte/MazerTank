using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WallSpike_Hit : MonoBehaviour {
    public Transform RespawnPoint;
    void Start ()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
	

	
}
