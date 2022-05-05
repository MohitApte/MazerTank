using UnityEngine;
using System.Collections;

public class HitDestructionForEnemy : MonoBehaviour {
   
	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "playerbullet")
        {
            Health.enemyHealth -= 2;
        }
    }
}
