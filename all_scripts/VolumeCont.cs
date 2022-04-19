using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeCont : MonoBehaviour
{
    public AudioMixerGroup MixerM;
    public AudioMixerGroup MixerE;
    
    public void SetMusicVolume(float sliderValue)
    {
        MixerM.audioMixer.SetFloat("MusicV", Mathf.Lerp(-80, 0, sliderValue));
    }

    public void SetEffectVolume(float sliderValue)
    {
        MixerE.audioMixer.SetFloat("EffectV", Mathf.Lerp(-80, 0, sliderValue));
    }
}
