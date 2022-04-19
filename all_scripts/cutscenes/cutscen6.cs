using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen6 : MonoBehaviour
{
    static public UnityAction _startcutscensix;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    bool once = true;
    void Start()
    {
        _startcutscensix = CutScenSix;
    }
    public void CutScenSix()
    {
        if (!once) return;
        cutPlayer.SetActive(true);
        othercanvas.SetActive(false);
        offSndByCutSc.offSndAndEff = true;
        once = false;
        StartCoroutine(WaitForCutSix());
    }
    IEnumerator WaitForCutSix()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
        missioncont._MissionNumber = 4;
        uiTarget.target = 6;
    }
}
