using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WallHitRespawn : MonoBehaviour {
    public Transform RespwanPosition;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
 

    }
}

