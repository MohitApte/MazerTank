using UnityEngine;
using System.Collections;
using MadLevelManager;
public class CompletedLevel : MonoBehaviour {
    public GameObject enemyTank1;
    public GameObject enemyTank2;
    public GameObject enemyTank3;
    public GameObject enemyTank4;
    public GameObject enemyTank5;
    public GameObject enemyTank6;

    void OnTriggerEnter(Collider other)
    {
        if (enemyTank1 == null && enemyTank2 == null && enemyTank3 == null && enemyTank4 == null && enemyTank5 == null &&  enemyTank6 == null )
        {
            if (other.tag == "Player")
            {
                MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
                MadLevel.LoadLevelByName("Level Select");
            }
        }
    }
}
