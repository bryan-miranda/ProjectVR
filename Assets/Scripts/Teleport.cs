using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject teleport;
    public string destination;
    public AudioSource final;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerClick()
    {
        if(destination == "Portal")
        {
            player.transform.position = teleport.transform.position;
            final.Play();
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
