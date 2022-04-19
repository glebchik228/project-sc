using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour
{
    static public bool flowered = false;
    public GameObject player;

    void OnMouseDown()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer < 5f)
        {
            flowered = true;
            Destroy(gameObject);
        }
    }
}
