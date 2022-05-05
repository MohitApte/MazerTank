using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MadLevelManager;
namespace mazerTank
{
    public class GoToLevel6 : MonoBehaviour
    {
        public GameObject tank1;
        public GameObject tank2;
        public GameObject tank3;
        public GameObject tank4;
        public GameObject tank5;
        public GameObject tank6;
        public GameObject tank7;
        public GameObject killAllTanksCanvas;

        void Start()
        {
            killAllTanksCanvas.SetActive(false);
        }

        void OnTriggerEnter(Collider other)
        {
            if (tank1 == null && tank2 == null && tank3 == null && tank4 == null && tank5 == null && tank6 == null && tank7 == null)
            {
                MadLevelProfile.SetCompleted(MadLevel.currentLevelName, true);
                MadLevel.LoadLevelByName("Level Select");
            }
            else
            {
                StartCoroutine(killAllTanks());

            }


        }

        IEnumerator killAllTanks()
        {
            killAllTanksCanvas.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            killAllTanksCanvas.SetActive(false);
        }

    }
}

