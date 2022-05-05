using UnityEngine;
using System.Collections;
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerFire : MonoBehaviour {
    public Transform bulletSpawnPoint;
    public GameObject bullet;
    public float shootForce;
    public Transform tank;
    private Transform myTransform;
    public float fireRate;
    private float nextFire;
   
    public GUITexture fire;
  

   
    private bool canFire = false;
    void Start ()
    {
        myTransform = tank.transform;
    }
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                if (fire.HitTest(t.position, Camera.main))
                {
                    canFire = true;
                }
                else
                {
                    canFire = false;
                }

               
            }
       
            if (t.phase == TouchPhase.Ended)
            {
               
                canFire = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (fire.HitTest(Input.mousePosition, Camera.main))
            {
                canFire = true;
            }
            else
            {
                canFire = false;
            }

          
        }
        if (Input.GetMouseButtonUp(0))
            {
                canFire = false;
            }
    }
        void FixedUpdate()
    {
            if(canFire == true)
        {
            Fire();
        }
      }
    void Fire()
    {
        if (canFire == true)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject shoot = (GameObject)Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                shoot.GetComponent<Rigidbody>().AddForce(myTransform.forward * shootForce);
                tank.GetComponent<AudioSource>().Play();
                Destroy(shoot, 3f);
            }
        }
    }

}
