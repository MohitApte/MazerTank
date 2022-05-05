using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MadLevelManager;
public class GoToLevel7 : MonoBehaviour {
	public GameObject enemyTank1;
	public GameObject enemyTank2;
	public GameObject enemyTank3;
	void OnTriggerEnter (Collider other)
	{
		if  (enemyTank1 == null && enemyTank2 == null && enemyTank3 == null)
		{
            MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
            MadLevel.LoadLevelByName("Level Select");
        }
	}
}
