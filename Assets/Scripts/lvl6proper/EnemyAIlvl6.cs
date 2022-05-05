using UnityEngine;
using System.Collections;

public class EnemyAIlvl6 : MonoBehaviour {
	public GameObject player;
	public GameObject bullet;
	public Transform spawnpoint;
	public Transform hyTransform;
	private float nextfireforstartenemy;
	public float fireRateForStart;
	public float shootDelay;
	public float enemyBulletSPeed = 1000f;
	
	void Start () {
		hyTransform = transform;
	}
	void Update ()
	{
		Quaternion rotation = Quaternion.LookRotation (player.transform.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, 10 * Time.deltaTime);
		
		Invoke("Delay", shootDelay);
	

	}
	void FixedUpdate ()
	{

		Vector3.MoveTowards (transform.position, player.transform.position, 100 * Time.deltaTime);
	}



	void Delay ()
	{
		if (Time.time > nextfireforstartenemy)
		{
			nextfireforstartenemy = Time.time + fireRateForStart;
			Firetheturrent();

		}

	}
	void Firetheturrent ()
	{
		GameObject lo = (GameObject)    Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
		lo.GetComponent<Rigidbody>().AddForce(hyTransform.forward * enemyBulletSPeed);
		gameObject.GetComponent<AudioSource>().Play();
	}
}
