using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MAX_HEALTH;
    private float health;

    public Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthbar.fillAmount = health / MAX_HEALTH;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
