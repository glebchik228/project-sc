using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen2 : MonoBehaviour
{
    static public UnityAction _startcutscentwo;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    void Start()
    {
        _startcutscentwo = CutScenTwo;
    }
    public void CutScenTwo()
    {
            cutPlayer.SetActive(true);
            othercanvas.SetActive(false);
            offSndByCutSc.offSndAndEff = true;
            StartCoroutine(WaitForCutTwo());
    }
    IEnumerator WaitForCutTwo()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        misslook3.i--;
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
    }
}
