using UnityEngine;
using System.Collections;

public class Coin_Rotation : MonoBehaviour {
    public float CoinRotateSpeed;
    void FixedUpdate()
    {
        CoinRotate();
    }
    void CoinRotate ()
    {
        transform.Rotate(0f, 1f * CoinRotateSpeed * Time.deltaTime, 0f);
    }
}
