using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameStart : MonoBehaviour
{
    private AudioClip splashMusic;
    private bool hasStarted;
    public GameObject splashScreen;



    public void ClickedStart()
    {
        this.hasStarted = true;
        this.splashScreen.SetActive(false);

        //this.GetComponent<AudioSource>().Stop();        //removes music on start button click
    }
}//class
