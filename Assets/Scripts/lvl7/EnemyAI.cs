using UnityEngine;
using System.Collections;
public class EnemyAI : MonoBehaviour {
    public GameObject player;
    public GameObject bullet;
    public Transform spawnpoint;
    public Transform hyTransform;
    private float nextfireforstartenemy;
    public float fireRateForStart;
    public float shootDelay;
    public float enemyBulletSPeed = 1000f;
    private float distanceBetweenPlayerAndEnemy;
    private bool canFire = false;
    public float enemyMoveSpeed = 2;



    void Start()
    {
        hyTransform = transform;
    }


    void Update()
    {
        distanceBetweenPlayerAndEnemy = Vector3.Distance(transform.position, player.transform.position);
            if(distanceBetweenPlayerAndEnemy >= 5 && distanceBetweenPlayerAndEnemy <= 10)
        {
            Walk();
        }


        if (distanceBetweenPlayerAndEnemy<= 10)
        {
            canFire = true;
        }
        else
        {
            canFire = false;
        }
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10 * Time.deltaTime);

        Invoke("Delay", shootDelay);


    }


    void FixedUpdate()
    {

        Vector3.MoveTowards(transform.position, player.transform.position, 100 * Time.deltaTime);
    }




    void Delay()
    {
        if (Time.time > nextfireforstartenemy && canFire == true)
        {
            nextfireforstartenemy = Time.time + fireRateForStart;
            Firetheturrent();

        }

    }
    void Firetheturrent()
    {
        GameObject lo = (GameObject)Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
        lo.GetComponent<Rigidbody>().AddForce(hyTransform.forward * enemyBulletSPeed);
        gameObject.GetComponent<AudioSource>().Play();
    }
    void Walk ()
    {
        transform.Translate(Vector3.forward * enemyMoveSpeed * Time.deltaTime);
    }


}
