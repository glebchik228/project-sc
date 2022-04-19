using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gobcast : MonoBehaviour
{
    static public UnityAction _startTP;
    public int waitTime;
    public goblincont _goblincont;
    private Animator myAn;
    void Start()
    {
        goblincont _goblincont = gameObject.GetComponent<goblincont>();
        myAn = GetComponent<Animator>();
        _startTP = StartTP;
    }

    
    public void StartTP()
    {
            _goblincont.enabled = false;
            myAn.Play("Attack01");
            StartCoroutine(WaitForTeleportation());
    }
    IEnumerator WaitForTeleportation()
    {
        yield return new WaitForSeconds(waitTime);
        Teleport._startFly.Invoke();
    }
}
