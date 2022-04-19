using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen8 : MonoBehaviour
{
    static public UnityAction _startcutsceneight;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    bool once = true;
    void Start()
    {
        _startcutsceneight = CutScenEight;
    }
    public void CutScenEight()
    {
        if (!once) return;
        cutPlayer.SetActive(true);
        othercanvas.SetActive(false);
        offSndByCutSc.offSndAndEff = true;
        once = false;
        StartCoroutine(WaitForCutEight());
    }
    IEnumerator WaitForCutEight()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        offSndByCutSc.offSndAndEff = false;
        uiTarget.target = 7;
    }
}
