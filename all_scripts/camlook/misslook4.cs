using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misslook4 : MonoBehaviour
{
    public int waitTime;
    bool once = true;
    IEnumerator WaitForLook()
    {
        yield return new WaitForSeconds(waitTime);
        camcamcam.x = 0;
        camcamcam.camspeed = 0.125f;
        misslook.blockmove = false;

    }
    void Update()
    {
        if ((missioncont._MissionNumber == 4) && Bright.mslk && once)
        {
            once = false;
            camcamcam.x = 10;
            camcamcam.camspeed = 0.005f;
            misslook.blockmove = true;
            StartCoroutine(WaitForLook());
        }
    }
}
