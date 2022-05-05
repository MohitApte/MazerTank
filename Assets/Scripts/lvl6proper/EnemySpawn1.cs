using UnityEngine;
using System.Collections;

public class EnemySpawn1 : MonoBehaviour {
	public GameObject enemyTank1;
	public GameObject enemyTank2;
    public GameObject enemyTank3;




    void Start ()
	{
		enemyTank1.SetActive (false);
		enemyTank2.SetActive (false);
        enemyTank3.SetActive(false);


    }
    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{

			enemyTank1.SetActive (true);
			enemyTank2.SetActive (true);
            enemyTank3.SetActive(true);



        }

    }

}
