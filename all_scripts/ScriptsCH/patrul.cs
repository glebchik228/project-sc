using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrul : MonoBehaviour
{
    private float waittime;
    public float startWaitTime;

    public Transform[] moveSpots;
    private int randonSpot;
    private Animator myAn;
    
    private UnityEngine.AI.NavMeshAgent agent;
    private float rotationSpeed;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        rotationSpeed = agent.angularSpeed;
        waittime = startWaitTime;
        randonSpot = Random.Range(0, moveSpots.Length);
        myAn = GetComponent<Animator>();
        Vector3 v3Velocity = agent.velocity;
        
    }

    // Update is called once per frame
    void Update()
    {
        var speed = agent.velocity.magnitude;
        myAn.speed = 0.5f;
        if (speed >= 0.15f)
        { myAn.Play("Run"); }
        else { myAn.Play("Idle"); }

        //transform.position = Vector3.MoveTowards(transform.position, moveSpots[randonSpot].position, speed * Time.deltaTime);
        agent.SetDestination(moveSpots[randonSpot].position);


        if (Vector3.Distance(transform.position, moveSpots[randonSpot].position) < 0.5f)
        {
            if (waittime <= 0)
            {
                randonSpot = Random.Range(0, moveSpots.Length);
                waittime = startWaitTime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }
}
