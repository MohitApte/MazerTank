using UnityEngine;
using System.Collections;

public class TankAI : MonoBehaviour {
    public Transform enemy;
    public Transform player;
    private float distance;
    public float shootingRange = 8f;
    public GameObject bulletToShootPlayer;
    public Transform bulletToShootPlayerSpawnPoint;
    private Transform enemyTransform;
    public float fireRateForEnemy;
    private static float nextFireForEnemy;
    void Start ()
    {
        enemyTransform = transform;

    }


    void Update ()
    {
		
            if (Time.time > nextFireForEnemy)
        {
            nextFireForEnemy = Time.time + fireRateForEnemy;
            Fire();
        }

    }

    void Fire()
    {
        GameObject ShootAtPlayer = (GameObject)Instantiate(bulletToShootPlayer, bulletToShootPlayerSpawnPoint.position, bulletToShootPlayerSpawnPoint.rotation);
        ShootAtPlayer.GetComponent<Rigidbody>().AddForce(enemyTransform.forward * 1000);
        enemy.GetComponent<AudioSource>().Play();
        Destroy(ShootAtPlayer, 3f);
    }
}
