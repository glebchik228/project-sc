using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblincont : MonoBehaviour
{

    public bool oncecut = true;
    public float DetectionDistance = 15f;
    public Transform Target;
    private Animator myAn;
    public gobpatrul _patrul;
    private UnityEngine.AI.NavMeshAgent agent;
    private float rotationSpeed;
    private Transform agentTransform;

    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        rotationSpeed = agent.angularSpeed;
        agentTransform = agent.transform;
        myAn = GetComponent<Animator>();
        Vector3 v3Velocity = agent.velocity;
        gobpatrul _patrul = gameObject.GetComponent<gobpatrul>();
    }
    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(Target.transform.position, agent.transform.position);
        if (distanceToPlayer < 3f)
        {
            if (oncecut)
            {
                cutscen3._startcutscenthree.Invoke();
                oncecut = false;
            }
            missioncont._MissionNumber = 3;

        }
        if ((distanceToPlayer <= DetectionDistance) && (distanceToPlayer >= 3f))
        {
            
            RotateToTarget();
            MoveToTarget();
        }

        _patrul.enabled = distanceToPlayer <= DetectionDistance ? false : true;

        var speed = agent.velocity.magnitude;
        myAn.speed = 0.5f;
        myAn.Play(speed >= 0.15f ? "Move01" : "Idle01");
    }

   
    private void RotateToTarget() 
    {
        Vector3 lookVector = Target.position - agentTransform.position;
        lookVector.y = 0;
        if (lookVector == Vector3.zero) return;
        agentTransform.rotation = Quaternion.RotateTowards
            (
                agentTransform.rotation,
                Quaternion.LookRotation(lookVector, Vector3.up),
                rotationSpeed * Time.deltaTime
            );

    }
    private void MoveToTarget() 
    {
        agent.SetDestination(Target.position);
    }


    
}
