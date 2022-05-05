using UnityEngine;
using System.Collections;

public class HealthDecreaseForEnemy : MonoBehaviour {
    public float maxHealth = 100f;
    public float currentHealth = 0f;
    public GameObject healthBar;
    public float killed = 0;
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
       
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBullet")
        {
            DecreaseHealth();
        }
        
    }
	// Update is called once per frame
	void Update () {
        if (killed == 7)
        {

        }
        if (gameObject.activeInHierarchy == false)
        {
            killed += 1;
        }
	}
    void DecreaseHealth ()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
          
        }
        currentHealth -= 10;
        float calculatedHealth = currentHealth / maxHealth;
        
        ChangeHealthBar(calculatedHealth);
    }
    void ChangeHealthBar (float enemyHealth)
    {
        healthBar.transform.localScale = new Vector3(enemyHealth,healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
   
}
