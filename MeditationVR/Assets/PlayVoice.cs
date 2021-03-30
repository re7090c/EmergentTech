﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    public AudioSource Voice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        if(Voice.isPlaying == false)
        {
            Voice.Play();
        }
        else if (Voice.isPlaying == true)
        {
            Voice.Pause();
        }

    }
}
