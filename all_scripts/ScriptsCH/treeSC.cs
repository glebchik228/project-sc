using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class treeSC : MonoBehaviour
{
    public bool i = true;
    public float DetectionDistance = 10f;
    public Transform Target;
    public Transform Goblin;
    private UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(Target.transform.position, agent.transform.position);
        float distanceToGoblin = Vector3.Distance(Goblin.transform.position, agent.transform.position);
        if ((distanceToPlayer <= DetectionDistance)&& (distanceToGoblin <= DetectionDistance) && i)
        {
            cutscen4._startcutscenfour.Invoke();
            i = false;
        }

    }
}
