using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip p1MenusMusic;
    public AudioClip p1Main;

    // private Camera camera;
    //public int targetDisplay;


    private void Awake()
    {
        musicSource.clip = p1Main;
        musicSource.Play();
        
    }
}
