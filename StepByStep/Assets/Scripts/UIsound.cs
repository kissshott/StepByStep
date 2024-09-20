using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIsound : MonoBehaviour
{
    private AudioSource ui_sound;
    void Start()
    {
        ui_sound = GameObject.FindGameObjectWithTag("UI").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void click() 
    {
        ui_sound.Play();
    }
}
