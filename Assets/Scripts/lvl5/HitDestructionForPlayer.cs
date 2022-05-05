using UnityEngine;
using System.Collections;

public class HitDestructionForPlayer : MonoBehaviour {
    public GameObject hitEffectCanvas;
    void Start ()
    {
        hitEffectCanvas.SetActive(false);
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "enemybullet")
        {
            Health.playerHealth -= 2;
            StartCoroutine(hitEffect());
        }
    }
    IEnumerator hitEffect ()
    {
        hitEffectCanvas.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        hitEffectCanvas.SetActive(false);
    }
}
