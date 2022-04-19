using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class dragonsc : MonoBehaviour
{
    public GameObject player;
    public GameObject human;
    public int waitTime;
    bool isStarted = false;
    static public UnityAction _dragon;
    static public UnityAction _dragonHum;
    public Animator myAn;
    public NavMeshAgent Ag;
    bool once = true;
    void Start()
    {
        Ag = GetComponent<NavMeshAgent>();
        myAn = GetComponent<Animator>();
        _dragon = Dragon;
        _dragonHum = DragonHuman;
    }

    void Update()
    {
        if (isStarted && Ag.baseOffset>0)
        Ag.baseOffset -= Time.deltaTime*3;
        if (Ag.baseOffset <= 0)
        {
            myAn.Play("Dragon_Wait");
            if (once)
            {
                once = false;
                misslook.blockmove = false;
            }
        }
    }
    public void DragonHuman()
    {
        flower.flowered = false;
    Instantiate(human, transform.position, new Quaternion(0,180,0, 0));
    uiTarget.target = 7;
    Destroy(gameObject);
    }

    public void Dragon()
    {
        uiTarget.target = 4;
        StartCoroutine(PauseBefore());
    }
    IEnumerator PauseBefore()
    {
        yield return new WaitForSeconds(waitTime);
        camcamcam.x = 9;
        myAn.Play("Dragon_Move");
        Ag.SetDestination(player.transform.position);
        isStarted = true;
        misslook.blockmove = true;
        uiTarget.target = 5;
    }
}
