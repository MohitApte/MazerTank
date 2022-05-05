using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Health : MonoBehaviour {
    public Text playerHealthText;
    public Text enemyHealthText;
    public static float playerHealth;
    public static float enemyHealth;
    void Start ()
    {
        playerHealth = 30;
        enemyHealth = 30;
    }


    void Update ()
    {
        playerHealthText.text = "Player Health: " + playerHealth;
        enemyHealthText.text = "Enemy Health: " + enemyHealth ;
    }

}
