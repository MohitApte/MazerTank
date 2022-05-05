using UnityEngine;
using System.Collections;

public class TurnIntoANonTrigger : MonoBehaviour {
    private BoxCollider bc;
    void Start ()
    {
        bc = GetComponent<BoxCollider>();
    }
     void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {

            bc.isTrigger = false;
        }

    }

}
