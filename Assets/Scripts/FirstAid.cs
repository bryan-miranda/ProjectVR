using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{
    public float healing;
    public Transform player;
    public AudioSource healSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerClick()
    {
        healSound.Play();
        player.GetComponent<PlayerHealth>().Heal(healing);
        gameObject.transform.GetComponent<Collider>().enabled = false;
        gameObject.transform.GetComponent<Renderer>().enabled = false;
    }
}
