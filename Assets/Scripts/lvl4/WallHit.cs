using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WallHit : MonoBehaviour {
    public GameObject player;
    public Transform RespawnPoint;
void OnTriggerEnter (Collider other)
    {
        
         SceneManager.LoadScene(4);
       
    }
}
