using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    
    public Transform player;
    public float howClose;
    public ParticleSystem cannon1Flash;
    public ParticleSystem cannon2Flash;

    private float dist;
    private float damage = 20f;
    private bool closeEnough;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurretShoot());
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);

        if(dist <= howClose)
        {
            transform.LookAt(new Vector3(player.position.x, transform.position.y ,player.position.z));
            //StartCoroutine(TurretShoot());
            closeEnough = true;
        }
        else
        {
            closeEnough = false;
        }

    }

    IEnumerator TurretShoot()
    {
        while (true)
        {
            if (closeEnough)
            {
                Debug.Log("disparo");
                cannon1Flash.Play();
                cannon2Flash.Play();
                player.GetComponent<PlayerHealth>().TakeDamage(damage);
            }
            yield return new WaitForSeconds(2);
        }  
    }
}
