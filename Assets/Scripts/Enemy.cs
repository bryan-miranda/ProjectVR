using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    private Renderer _myRenderer;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Destroy();
        }
    }

    void Start()
    {
        _myRenderer = GetComponent<Renderer>();
    }

    void Destroy()
    {
        gameObject.transform.GetChild(1).gameObject.GetComponent<Renderer>().enabled = false;
    }
}
