using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misslook : MonoBehaviour
{
    public int waitTime;
    static public int i = 1;
    static public bool blockmove = false;

    IEnumerator WaitForLook()
    {
        yield return new WaitForSeconds(waitTime);
        camcamcam.x = 0;
        camcamcam.camspeed = 0.125f;
        blockmove = false;

    }
    void Update()
    {
        if ((missioncont._MissionNumber == 1) && (i ==0) && Bright.mslk)
        {
            camcamcam.x = 7;
            camcamcam.camspeed = 0.005f;
            blockmove = true;
            StartCoroutine(WaitForLook());
            i++;
        }
        
    }
}
