using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GoToLevel6 : MonoBehaviour {
    public GameObject coinsnotcollectedcanvas;

    void Start ()
    {
        coinsnotcollectedcanvas.SetActive(false);
    }

    void OnTriggerEnter (Collider other)
    {
        if (CoinCollect05.score05 == 3)
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            StartCoroutine(CoinsNotCollected());
        }
    }
    IEnumerator CoinsNotCollected ()
    {
        coinsnotcollectedcanvas.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        coinsnotcollectedcanvas.SetActive(false);
    }

}
