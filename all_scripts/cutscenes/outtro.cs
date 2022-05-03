using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outtro : MonoBehaviour
{
    public int waitTime;
    void Start()
    {
        StartCoroutine(Final());
    }
    IEnumerator Final()
    {
        yield return new WaitForSeconds(waitTime);
        Application.Quit();
    }
}
