using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthDecreaseForPlayer:MonoBehaviour{

    public float maxHealth = 100f;
    public float currentHealth;
    public GameObject healthBar;
    // Use this for initialization
    void Start()
    {
     
        currentHealth = maxHealth;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemybullet")
        {
            DecreaseHealth();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
    void DecreaseHealth()
    {
        if (currentHealth == 0)
        {
            currentHealth = 0;
        }
        if (currentHealth <= 0)
        {
			SceneManager.LoadScene (5);
        }
        currentHealth -= 2;
        float calculatedHealth = currentHealth / maxHealth;

        ChangeHealthBar(calculatedHealth);
    }
    void ChangeHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);

   
    }
}
