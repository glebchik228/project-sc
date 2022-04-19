using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen3 : MonoBehaviour
{
    static public UnityAction _startcutscenthree;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    void Start()
    {
        _startcutscenthree = CutScenThree;
    }
    public void CutScenThree()
    {
        
            cutPlayer.SetActive(true);
            othercanvas.SetActive(false);
            offSndByCutSc.offSndAndEff = true;
            StartCoroutine(WaitForCutThree());
        
    }
    IEnumerator WaitForCutThree()
    {
        yield return new WaitForSeconds(waitTime);
        cutPlayer.SetActive(false);
        othercanvas.SetActive(true);
        misslook2.i--;
        Bright.bright = true;
        offSndByCutSc.offSndAndEff = false;
    }
}
