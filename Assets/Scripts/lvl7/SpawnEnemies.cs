using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {
    public GameObject enemyTank1;
    public GameObject enemyTank2;
    public GameObject enemyTank3;
    public GameObject enemyTank4;
    public GameObject enemyTank5;
    public GameObject enemyTank6;


    void Start()
    {
        enemyTank1.SetActive(false);
        enemyTank2.SetActive(false);
        enemyTank3.SetActive(false);
        enemyTank4.SetActive(false);
        enemyTank5.SetActive(false);
        enemyTank6.SetActive(false);


    }
    void OnTriggerEnter(Collider other)
    {
        enemyTank1.SetActive(true);
        enemyTank2.SetActive(true);
        enemyTank3.SetActive(true);
        enemyTank4.SetActive(true);
        enemyTank5.SetActive(true);
        enemyTank6.SetActive(true);

    }


}
