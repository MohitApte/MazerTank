using UnityEngine;
using System.Collections;

public class ShootWithStartDelay : MonoBehaviour {
    public GameObject bullet;
    public Transform spawnpoint;
    public Transform hyTransform;
    private float nextfireforstartenemy;
    public float fireRateForStart;
    public float shootDelay = 3f;
    public float enemyBulletSPeed = 1000f;
	void Start () {
        hyTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("Delay", shootDelay);
      
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
