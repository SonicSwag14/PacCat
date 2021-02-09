using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControls : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip p1MenusMusic;
    public AudioClip p1Main;



    private void Awake()
    {
        musicSource.clip = p1MenusMusic;
        musicSource.Play();
    }

    //void OnTriggerEnter2D(Collider2D other)
   // {
        //Detect if the left mouse button is pressed
       // if (other.gameObject.CompareTag("Start"))
        //{
            
       // }
   // }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        { 
        
            
            SceneManager.LoadScene(1);
            
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
