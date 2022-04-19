using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Rendering.PostProcessing;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class pulse : MonoBehaviour
{
    public PostProcessVolume post;
    public float pls = 0;
    public ChromaticAberration ca;
    void Start()
    {
        post = GetComponent<PostProcessVolume>();
        ca = post.GetComponent<ChromaticAberration>();
    }
    
    void Update()
    {
        ca.intensity.value = pls;
    }
}
