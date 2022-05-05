using UnityEngine;
using System.Collections;

public class PatrolPoints : MonoBehaviour {
    public Transform [] patrolPoints;
    private int currentPos;
    public float Patrolspeed;



    void Start ()
    {
        currentPos = 0;
        transform.position = patrolPoints[currentPos].position;   


    }
    

    void FixedUpdate ()
    {
       
        if (transform.position == patrolPoints[currentPos].position)
        {
            currentPos ++;
        }
        if (currentPos >= patrolPoints.Length)
        {
            currentPos = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPos].position, Patrolspeed * Time.deltaTime);


    }
	
}
