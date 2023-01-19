using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string button;
    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    void Start()
    {
        _startingPosition = transform.parent.localPosition;
        _myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter()
    {

    }

    public void OnPointerClick()
    {
        
        if (button == "Salir")
        {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
        else if (button == "Volver")
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene(button);
        }
    }

    public void OnPointerExit()
    {

    }
}
