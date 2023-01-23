using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    private float range = 100f;

    public ParticleSystem muzzleFlash;
    public Camera camera;
    public AudioSource shot;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            StartCoroutine(Shoot());
            
            yield return new WaitForSeconds(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();

            if (enemy != null)
            {
                GetComponent<Animator>().Play("gunRecoil");
                muzzleFlash.Play();
                shot.Play();
                yield return new WaitForSeconds(0.2f);
                GetComponent<Animator>().Play("New State");
                enemy.TakeDamage(damage);
            }
        }   
     }   
 }
