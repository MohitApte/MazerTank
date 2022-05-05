using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class HitRespawn : MonoBehaviour {

    public Transform respawnPosition;

    void OnTriggerEnter (Collider other)
    {
        SceneManager.LoadScene(3);
    }
}
