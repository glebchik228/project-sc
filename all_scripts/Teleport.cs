using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Teleport : MonoBehaviour
{
    static public UnityAction _startFly;
    public int waitTime;
    public float waitTime2;
    public float waitTime3;
    public Transform pos;
    public GameObject obj;
    private Animator myAn;
    private UnityEngine.AI.NavMeshAgent Ag;
    public bool isFlying = false;
    void Start()
    {
        myAn = GetComponent<Animator>();
        Ag = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _startFly = Teleportation;
    }

   
    public void Teleportation()
    {
        misslook.blockmove = true;
            myAn.Play("Attack");
            StartCoroutine(WaitForTeleport());
    }
    void Update()
    {
        /*///////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.E))
        {
            _startFly.Invoke();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            dragonsc._dragonHum.Invoke();
        }
        //////////////////////////////////////////////////////////////*/
        if (isFlying)
        {
            StartCoroutine(WaitForFly());
            isFlying = false;
        }
    }
    IEnumerator WaitForTeleport()
    {
        yield return new WaitForSeconds(waitTime);
        camcamcam.x = 6;
        myAn.speed = 0;
        Ag.speed = 500;
        Ag.acceleration = 100000;
        Ag.angularSpeed = 10000;
        Ag.SetDestination(pos.transform.position);
        isFlying = true;
    }
    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(waitTime2);
        misslook.blockmove = false;
        myAn.Play("Idle");
        dragonsc._dragon.Invoke();
    }
    IEnumerator WaitForFly()
    {
        yield return new WaitForSeconds(waitTime3);
        Ag.SetDestination(pos.transform.position);
        float distanceToPlayer = Vector3.Distance(pos.transform.position, Ag.transform.position);
        if (distanceToPlayer > 2f)
            isFlying = true;
        else
        {
            Ag.speed = 2.5f;
            Ag.acceleration = 8;
            Ag.angularSpeed = 500;
            myAn.speed = 1;
            camcamcam.x = 0;
            StartCoroutine(WaitFor());
        }
    }
}
