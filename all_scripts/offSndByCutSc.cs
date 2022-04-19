using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.PostProcessing;

public class offSndByCutSc : MonoBehaviour
{
    static public bool offSndAndEff = false;
    public PostProcessLayer ppl;
    public Camera cam;
    public AudioMixerGroup MixerMaster;
    void Start()
    {
        ppl = cam.GetComponent<PostProcessLayer>();
    }

    
    void Update()
    {
        if (offSndAndEff)
        {
            ppl.enabled = false;
            MixerMaster.audioMixer.SetFloat("Master", -80);
        }
        else
        {
            ppl.enabled = true;
            MixerMaster.audioMixer.SetFloat("Master", 0);
        }
    }
}
