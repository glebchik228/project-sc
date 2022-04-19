using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen7 : MonoBehaviour
{
    static public UnityAction _startcutscenseven;
    public float waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    bool once = true;
    void Start()
    {
        _startcutscenseven = CutScenSeven;
    }
    public void CutScenSeven()
    {
        if (!once) return;
        cutPlayer.SetActive(true);
        othercanvas.SetActive(false);
        offSndByCutSc.offSndAndEff = true;
        once = false;
        StartCoroutine(WaitForCutSeven());
    }
    IEnumerator WaitForCutSeven()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
        humDragon.letsGo.Invoke();
    }
}
