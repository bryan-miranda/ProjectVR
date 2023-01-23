using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float MAX_HEALTH;
    private float health;

    public Image healthbar;
    public AudioSource playerHit;

    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
    }

    public void TakeDamage(float amount)
    {
        playerHit.Play();
        health -= amount;
        healthbar.fillAmount = health / MAX_HEALTH;

        if (health <= 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health += amount;
        if (health > MAX_HEALTH){
            health = MAX_HEALTH;
        }
        healthbar.fillAmount = health / MAX_HEALTH;
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
