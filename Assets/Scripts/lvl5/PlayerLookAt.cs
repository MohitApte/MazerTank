using UnityEngine;
using System.Collections;

public class PlayerLookAt : MonoBehaviour {
    public float DistanceBetweenPlayerAndEnemy;
    public float distanceToBeRotated;
    public GameObject player;
    public float speedOfRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        DistanceBetweenPlayerAndEnemy =Vector3.Distance( player.transform.position , transform.position);

       
        if (DistanceBetweenPlayerAndEnemy <= 12)
        {
            LookAt();
        }
	}
    void LookAt ()
    {
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speedOfRotation);
    }
}
