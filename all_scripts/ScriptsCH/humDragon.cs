using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class humDragon : MonoBehaviour
{
    static public UnityAction letsGo;
    public NavMeshAgent Ag;
    public Animator myAn;
    public GameObject river;
    public float distanceToRiver;
    
    void Start()
    {
        Ag = GetComponent<NavMeshAgent>();
        myAn = GetComponent<Animator>();
        letsGo = GoToTheRiver;
        river = GameObject.FindGameObjectWithTag("river");
    }

    private void OnMouseDown()
    {
        cutscen7._startcutscenseven.Invoke();
        if (distanceToRiver < 3f)
            cutscen8._startcutsceneight.Invoke();
    }

    public void GoToTheRiver()
    {
        Ag.SetDestination(river.transform.position);
    }

    void Update()
    {
        distanceToRiver = Vector3.Distance(transform.position, river.transform.position);
        var speed = Ag.velocity.magnitude;
        if (speed > 0.5f)
        {
            myAn.SetBool("go", true);
            myAn.SetBool("stop", false);
            myAn.speed = speed * 0.2f;
        }
        else
        {
            myAn.SetBool("go", false);
            myAn.SetBool("stop", true);
            myAn.speed = 1f;
        }
    }
}
