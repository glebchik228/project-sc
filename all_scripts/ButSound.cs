using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButSound : MonoBehaviour
{
    public AudioSource ch;
    public AudioClip chik;
    static public bool snd;
    void Start()
    {
        ch = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (snd)
        {
            ch.PlayOneShot(chik);
            snd = false;
        }
        //else
          //  ch.Stop();
    }
}
