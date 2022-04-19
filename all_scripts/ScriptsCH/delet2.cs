using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delet2 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Destroy(gameObject);
        scorecont.score++;
    }
}
