using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking2d : MonoBehaviour
{
    public int speed;
    public GameObject chel;
    private int k = 0;
    private bool once = true;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 0)
                GoRight();
            else if (k >= 3 && once)
            {
                chel.SetActive(true);
                transform.position = new Vector3(-130f, transform.position.y, transform.position.z);
                once = false;
            }
            else
            {
                if (!once) return;
                transform.position = new Vector3(-130f, transform.position.y, transform.position.z);
                k++;
            }
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -130)
            GoLeft();
        if (Input.GetKey(KeyCode.W) && transform.position.y < 30)
            GoUp();
        if (Input.GetKey(KeyCode.S) && transform.position.y > -30)
            GoDown();
    }

    void GoRight()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    void GoLeft()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);;
    }
    void GoUp()
    {
        transform.position += new Vector3(0,speed * Time.deltaTime,  0);
    }
    void GoDown()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime,  0);
    }
}
