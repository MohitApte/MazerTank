using UnityEngine;
using System.Collections;

public class TankShoot : MonoBehaviour {
    public Transform bulletSpawnPoint;
    public GameObject bullet;
    public float shootForce;
    public Transform tank;
    private Transform myTransform;
    public float fireRate;
    private float nextFire;
    void Start ()
    {
        myTransform = tank.transform;
    }
    public void Fire ()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
        GameObject shoot = (GameObject)Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        shoot.GetComponent<Rigidbody>().AddForce(myTransform.forward* shootForce);
        tank.GetComponent<AudioSource>().Play();
        Destroy(shoot, 3f);
        }
    }
}
