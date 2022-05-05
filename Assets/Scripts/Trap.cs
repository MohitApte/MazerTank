using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {
    public float DelayTime;
    
	
	void Start ()
    {
        StartCoroutine(Go());
	}
	
    IEnumerator Go()
    {
        while (true)
        {
            GetComponent<Animation>().Play();
            yield return new WaitForSeconds(DelayTime);
        }
    }
	void Update ()
    {
	
	}
}
