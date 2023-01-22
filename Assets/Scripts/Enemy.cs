using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    
    public float MAX_HEALTH = 100f;
    private float health;
    private Renderer _myRenderer;

    public Image healthbar;

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthbar.fillAmount = health / MAX_HEALTH;

        if (health <= 0f)
        {
            Destroy();
        }
    }

    void Start()
    {
        health = MAX_HEALTH;
        _myRenderer = GetComponent<Renderer>();
    }

    void Destroy()
    {
        gameObject.transform.GetChild(1).gameObject.GetComponent<Renderer>().enabled = false;
    }
}
