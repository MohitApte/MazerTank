using UnityEngine;
using System.Collections;

public class PlatformWait : MonoBehaviour {
public GameObject Base;
 void OnCollisionEnter(Collision hello)
    {

if (hello.gameObject == Base.gameObject)
        {
            Destroy(gameObject);

        }

    }
}
