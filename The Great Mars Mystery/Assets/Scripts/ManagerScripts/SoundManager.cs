﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


// Add FindObjectOfType<SoundManager>().Play("name of clip in the sound manager");
// in the function that needs an effect or sound
public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.playOnAwake=s.playOnAwake;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound sound = null;
        foreach (Sound s in sounds)
        {
            if (s.name==name)
            {
                sound = s;
                break;
            }
        }

        if(sound!=null)
        {
            sound.source.Play();
        }
        
    }

}
