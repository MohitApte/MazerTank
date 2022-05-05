using UnityEngine;
using System.Collections;

public class CoinsNotCollected : MonoBehaviour {
    public GameObject coinsNotCollectedCanvas;
    private BoxCollider bc;
   private  bool collected = false;
    void Start()
    {
        bc = GetComponent<BoxCollider>();
        coinsNotCollectedCanvas.SetActive(false);
    } 
    void OnCollisionEnter(Collision col)
    {
        if (collected == false)
        {
            StartCoroutine(goldNotCollected());
        }


    }
    void Update ()
    {
        if (Coin_Collect07.score07 == 9)
        {
            bc.isTrigger = true;
            collected = true;

        }
        else
        {
            bc.isTrigger = false;
            collected = false;
        }
    }
    IEnumerator goldNotCollected()

    {
        coinsNotCollectedCanvas.SetActive(true);
        yield return new WaitForSeconds(1);
        coinsNotCollectedCanvas.SetActive(false);

    }


}
