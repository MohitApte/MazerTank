using UnityEngine;
using System.Collections;
public class movingPlatform : MonoBehaviour {
    public Transform position1;
    public Transform position2;
    public float movingPlatformSpeed;
	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player7")
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position, movingPlatformSpeed);
        }
        
    }
}
