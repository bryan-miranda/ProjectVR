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
        gameObject.transform.GetComponent<Collider>().enabled = false;
        gameObject.transform.GetComponent<TurretControl>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.GetChild(1).gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.GetChild(1).transform.GetChild(0).gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.transform.GetChild(1).transform.GetChild(1).gameObject.GetComponent<Renderer>().enabled = false;
    }
}
