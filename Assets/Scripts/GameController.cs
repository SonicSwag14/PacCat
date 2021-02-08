using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public AudioSource musicSource;

    public AudioClip p1MenusMusic;
    public AudioClip p1Main;

   // private SceneName level1;
   
    private void Awake()
    {
        musicSource.clip = p1MenusMusic;
        musicSource.Play();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.T))     //(Input.GetMouseButtonDown(0)) //if (Input.GetKey(MouseButton.LeftMouse))
        //{
            //if (gameObject.CompareTag("Tutorial"))
                SceneManager.LoadScene(1);
       // }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    

}
