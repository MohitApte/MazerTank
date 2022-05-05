using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BrickHit : MonoBehaviour {
    public  Transform RespawnPoint;
    public GameObject blood;
	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Brick")
        {
            SceneManager.LoadScene(4);
        }
    }
}
