using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misslook2 : MonoBehaviour
{
    public int waitTime;
    static public int i = 1;


    IEnumerator WaitForLook()
    {
        yield return new WaitForSeconds(waitTime);
        camcamcam.x = 0;
        camcamcam.camspeed = 0.125f;
        misslook.blockmove = false;

    }
    void Update()
    {
        if ((missioncont._MissionNumber == 3) && (i == 0) && Bright.mslk)
        {
            camcamcam.x = 8;
            camcamcam.camspeed = 0.005f;
            misslook.blockmove = true;
            StartCoroutine(WaitForLook());
            i++;
        }

    }
}
