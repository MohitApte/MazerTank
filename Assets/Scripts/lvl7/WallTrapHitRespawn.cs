using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WallTrapHitRespawn : MonoBehaviour {
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(7);

        }
    }
}
