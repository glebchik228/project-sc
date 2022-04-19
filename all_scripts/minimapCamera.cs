using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {
        offset = player.transform.position - gameObject.transform.position;
    }

    
    void LateUpdate()
    {
        gameObject.transform.position = player.transform.position - offset;
        transform.rotation = Quaternion.Euler(90, player.transform.eulerAngles.y, 0);
    }
}
