using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCwalk : MonoBehaviour
{

    public float ViewDistance = 15f;
    public float DetectionDistance = 3f;

    public Transform Target;
    private Animator myAn;
    public bool oncecut = true;
    public bool oncecut2 = true;
    private NavMeshAgent agent;
    private float rotationSpeed;
    private Transform agentTransform;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        rotationSpeed = agent.angularSpeed;
        agentTransform = agent.transform;
        myAn = GetComponent<Animator>();
        Vector3 v3Velocity = agent.velocity;
    }
    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(Target.transform.position, agent.transform.position);
        if (distanceToPlayer < 3f)
        {
            missioncont._MissionNumber = (scorecont.score >= 10) ? 2 : 1;
            if (oncecut)
            {
                oncecut = false;
                cutscen1._startcutscenone.Invoke();
                uiTarget.target = 1;
            }
            if (missioncont._MissionNumber == 2 && oncecut2)
            {
                cutscen2._startcutscentwo.Invoke();
                oncecut2 = false;
                uiTarget.target = 2;
            }
        }

        if (missioncont._MissionNumber == 1 && scorecont.score >= 10)
            uiTarget.target = 0;
        if ((distanceToPlayer <= DetectionDistance) && (distanceToPlayer > 2f))
        {
            RotateToTarget();
            MoveToTarget();
        }
        

        var speed = agent.velocity.magnitude;
        myAn.speed = 0.5f;
        myAn.Play(speed >= 0.5f ? "Run" : "Idle");
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
