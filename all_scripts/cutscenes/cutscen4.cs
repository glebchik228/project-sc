using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cutscen4 : MonoBehaviour
{
    static public UnityAction _startcutscenfour;
    public int waitTime;
    public GameObject cutPlayer;
    public GameObject othercanvas;
    public GameObject answer;
    void Start()
    {
        _startcutscenfour = CutScenFour;
    }
    public void CutScenFour()
    {
            cutPlayer.SetActive(true);
            othercanvas.SetActive(false);
            answer.SetActive(false);
            offSndByCutSc.offSndAndEff = true;
            StartCoroutine(WaitForCutFour());
        
    }
    IEnumerator WaitForCutFour()
    {
        yield return new WaitForSeconds(waitTime);
        treeAnsSc._starttreeans.Invoke();
    }
}
