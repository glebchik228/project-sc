using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen1 : MonoBehaviour
{
    static public UnityAction _startcutscenone;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    void Start()
    {
        _startcutscenone = CutScenOne;
    }
    public void CutScenOne()
    {
            cutPlayer.SetActive(true);
            othercanvas.SetActive(false);
            offSndByCutSc.offSndAndEff = true;
            StartCoroutine(WaitForCutOne());
    }
    IEnumerator WaitForCutOne()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        misslook.i--;
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
    }
}
