using UnityEngine;
using System.Collections;
using CnControls;
public class Player_Movement : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;


	void Update ()
    {
        transform.Translate(0f, 0f, CnInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(0f, CnInputManager.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0f);
    }
}
