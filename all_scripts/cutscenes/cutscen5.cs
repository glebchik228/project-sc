using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen5 : MonoBehaviour
{
    static public UnityAction _startcutscenfive;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    void Start()
    {
        _startcutscenfive = CutScenFive;
    }
    public void CutScenFive()
    {
            cutPlayer.SetActive(true);
            Time.timeScale = 1;
            StartCoroutine(WaitForCutFive());
    }
    IEnumerator WaitForCutFive()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
        gobcast._startTP.Invoke();
    }
}
