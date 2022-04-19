using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Walking : MonoBehaviour
{
    public LayerMask CanBeClicked;
    private NavMeshAgent Ag;
    private Animator myAn;

    void Start()
    {
        Ag = GetComponent<NavMeshAgent>();
        myAn = GetComponent<Animator>();
        Vector3 v3Velocity = Ag.velocity; 
        
    }

    public static bool IsAnimationPlaying(Animator animator, string animationName)
    {
        // ����� ���������� � ��������� 
        var animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        // �������, ���� �� � ��� ��� �����-�� ��������, �� ���������� true
        if (animatorStateInfo.IsName(animationName))
            return true;
        return false;
    }

    void LateUpdate()
    {
        var speed = Ag.velocity.magnitude;
        if (misslook.blockmove) return;
        
        
            if (speed >= 0.5f)
            {
                myAn.ResetTrigger("Idle");
                    myAn.SetTrigger("Walk");
                    myAn.speed = speed * 0.4f;
            }
            else
            {
                myAn.ResetTrigger("Walk");
                myAn.SetTrigger("Idle");
                    myAn.speed = 1;
            }


            if (Input.GetMouseButtonDown(1))
            {
                camcamcam.x = 0;
                Ray _r = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(_r, out hitInfo, 100, CanBeClicked))
                {
                    Ag.SetDestination(hitInfo.point);
                }
            }
        

    }
}
