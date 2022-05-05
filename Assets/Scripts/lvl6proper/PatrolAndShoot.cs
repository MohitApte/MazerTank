using UnityEngine;
using System.Collections;

public class PatrolAndShoot : MonoBehaviour {
	public Transform[] patrolPoints; 
	public float patrolSpeed;
	public int currentPos;

	void Start ()
	{
		currentPos = 0;
		transform.position = patrolPoints [currentPos].position;
	}
	void Update ()
	{
		if (transform.position == patrolPoints[currentPos].position)
		{
			currentPos++;
		}
		if (currentPos >= patrolPoints.Length)
		{
			currentPos = 0;
		}
		transform.position = Vector3.MoveTowards(transform.position,patrolPoints[currentPos].position,patrolSpeed * Time.deltaTime);
	}
}
